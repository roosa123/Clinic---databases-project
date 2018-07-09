using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using System.Security.Cryptography;

namespace Przychodnia
{
    public partial class DetailedUserForm : BaseForm
    {
        Employee user;
        bool ifNewUser = false;

        public DetailedUserForm()
        {
            InitializeComponent();
            newPasswordButton.Visible = false;
            ifNewUser = true;

            user = new Employee();
            user.Person = new Person();
            user.Person.Address = new Address();
            user.PersonId = user.Person.Id;
            user.Person.AddressId = user.Person.Address.Id;

            InitializeCombos();
        }

        public DetailedUserForm(Employee user, bool editable)
        {
            InitializeComponent();

            this.user = user;

            InitializeCombos();
            FillInControls();

            if(!editable)
            {
                personalGroupBox.Enabled = false;
                workerGroupBox.Enabled = false;
                loginTextBox.ReadOnly = true;
                saveButton.Visible = false;
            }
            else
            {

                if(Program.CurrentUser.Position != "Admin")
                {
                    newPasswordButton.Visible = false;
                    passTextBox1.Visible = false;
                    passTextBox2.Visible = false;
                    label19.Visible = false;
                    label20.Visible = false;

                    roleComboBox.Enabled = false;
                    validityDateFromPicker.Enabled = false;
                    validityDateToPicker.Enabled = false;
                    termlessCheckBox.Enabled = false;

                    if(Program.CurrentUser.Position != "Doctor")
                    {
                        permissionTextBox.Enabled = false;
                        specializationTextBox.Enabled = false;
                    }
                }
            }
        }

        private void InitializeCombos()
        {
            sexComboBox.SelectedIndex = 0;
            roleComboBox.SelectedIndex = 0;
        }

        private void FillInControls()       // nie da sie wypelnic pol PESEL i mail, bo nie ma takich kolumn w bazie :(
        {
            nameTextBox.Text = user.Person.First_Name;
            surnameTextBox.Text = user.Person.Last_Name;
            sexComboBox.SelectedItem = (user.Person.Sex == "Male" ? sexComboBox.Items[0] : sexComboBox.Items[1]);
            birthdatePicker.Value = (user.Person.Date_of_birth == null ? DateTime.Today : user.Person.Date_of_birth.Value);
            phoneTextBox.Text = user.Person.Phone_number;

            switch (user.Position)
            {
                case "RegistrationPerson":
                    roleComboBox.SelectedItem = roleComboBox.Items[1];
                    break;
                case "Doctor":
                    roleComboBox.SelectedItem = roleComboBox.Items[2];

                    Doctor doc = Common.GetDoctorById(user.Id);
                    permissionTextBox.Text = doc.NPWZ;
                    specializationTextBox.Text = doc.Profession;

                    break;
                case "LaboratoryPerson":
                    roleComboBox.SelectedItem = roleComboBox.Items[3];
                    break;
                case "LaboratorySupervisor":
                    roleComboBox.SelectedItem = roleComboBox.Items[4];
                    break;
                case "Admin":
                    roleComboBox.SelectedItem = roleComboBox.Items[5];
                    break;
                default:
                    roleComboBox.SelectedItem = roleComboBox.Items[0];
                    break;
            }

            validityDateFromPicker.Value = (user.dt_AccountValidityFrom == null ? DateTime.Today : user.dt_AccountValidityFrom.Value);
            validityDateToPicker.Value = (user.dt_AccountValidityTo == null ? DateTime.Today : user.dt_AccountValidityTo.Value);
            loginTextBox.Text = user.Login;
        }

        private void returnButton1_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void newPasswordButton_Click(object sender, EventArgs e)
        {
            string passwd = user.Password;

            if(passTextBox1.Text == passwd)
            {
                MessageBox.Show("Nowe hasło jest takie samo jak stare. Proszę wprowadzić inne.");
                return;
            }

            if(passTextBox1.Text != passTextBox2.Text)
            {
                MessageBox.Show("Wprowadzone hasła są różne. Proszę wprowadzić jednakowe hasła.");
                return;
            }

            SHA1 sha = new SHA1CryptoServiceProvider();
            passwd = BitConverter.ToString(sha.ComputeHash(Encoding.UTF8.GetBytes(passTextBox1.Text)));
            passwd = passwd.Replace("-", "");

            user.Password = passwd;

            if (Common.UpdatePassword(user) != 0)
                MessageBox.Show("Hasło zostało zmienione");
            else
                MessageBox.Show("Nie udało się zmienić hasła!");

            passTextBox1.Text = "";
            passTextBox2.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            user.Person.First_Name = nameTextBox.Text;
            user.Person.Last_Name = surnameTextBox.Text;
            user.Person.Sex = sexComboBox.SelectedIndex == 0 ? "Male" : "Female";
            user.Person.Date_of_birth = birthdatePicker.Value;
            user.Person.Phone_number = phoneTextBox.Text;
            user.Login = loginTextBox.Text;

            if (termlessCheckBox.Checked)
            {
                user.dt_AccountValidityFrom = null;
                user.dt_AccountValidityTo = null;
            }
            else
            {
                user.dt_AccountValidityFrom = validityDateFromPicker.Value;
                user.dt_AccountValidityTo = validityDateToPicker.Value;
            }

            if(Common.CheckLogin(loginTextBox.Text) == -1 && ifNewUser)
            {
                MessageBox.Show("Użytkownik o podanym loginie już istnieje.");
                return;
            }

            bool changedRole = false;
            List<string> positions = new List<string>();

            positions.Add("-");
            positions.Add("RegistrationPerson");
            positions.Add("Doctor");
            positions.Add("LaboratoryPerson");
            positions.Add("LaboratorySupervisor");
            positions.Add("Admin");

            if (Program.CurrentUser.Position == "Admin" && user.Position != positions[roleComboBox.SelectedIndex])
            {
                int success = 0;

                if (!ifNewUser)
                {
                    switch (user.Position)
                    {
                        case "RegistrationPerson":
                            success = Common.DeleteRegistrar(user);
                            break;
                        case "Doctor":
                            success = Common.DeleteDoctor(user);
                            break;
                        case "LaboratoryPerson":
                            success = Common.DeleteLaboratoryPerson(user);
                            break;
                        case "LaboratorySupervisor":
                            success = Common.DeleteLaboratorySupervisor(user);
                            break;
                        case "Admin":
                            success = 1;
                            break;
                        default:
                            break;
                    }

                    if (success == 0)
                    {
                        MessageBox.Show("Nie udało się zmienić roli!");
                        return;
                    }
                }

                user.Position = positions[roleComboBox.SelectedIndex];

                switch (roleComboBox.SelectedIndex)
                {
                    case 1:
                        RegistrationPerson reg = new RegistrationPerson();

                        reg.Employee = user;
                        reg.EmployeeId = user.Id;

                        success = Common.InsertRegistrar(reg);
                        break;
                    case 2:
                        Doctor doc = new Doctor();

                        doc.Employee = user;
                        doc.EmployeeId = user.Id;
                        doc.NPWZ = permissionTextBox.Text;
                        doc.Profession = specializationTextBox.Text;

                        success = Common.InsertDoctor(doc);
                        break;
                    case 3:
                        LaboratoryPerson lab = new LaboratoryPerson();

                        lab.Employee = user;
                        lab.EmployeeId = user.Id;

                        success = Common.InsertLaboratoryPerson(lab);
                        break;
                    case 4:
                        LaboratorySupervisor klab = new LaboratorySupervisor();

                        klab.Employee = user;
                        klab.EmployeeId = user.Id;

                        success = Common.InsertLaboratorySupervisor(klab);
                        break;
                    case 5:
                        success = 1;
                        break;
                    default:
                        break;
                }

                if (success == 0 && !ifNewUser)
                {
                    MessageBox.Show("Nie udało się zmienić roli!");
                    return;
                }
                else if(success == 0 && ifNewUser)
                {
                    MessageBox.Show("Nie udało się dodać nowego użytkownika!");
                    return;
                }
                else if(success != 0 && ifNewUser)
                {
                    MessageBox.Show("Użytkownika dodano pomyślnie.");
                    Return();
                }
                else
                    changedRole = true;
            }

            if (!ifNewUser)
                if (Common.UpdateEmployee(user) != 0 || changedRole)
                    MessageBox.Show("Dane zaktualizowano pomyślnie.");
                else
                {
                    MessageBox.Show("Nie zaktualizowano danych.");
                    return;
                }

            Return();
        }
    }
}
