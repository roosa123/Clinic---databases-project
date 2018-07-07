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

        public DetailedUserForm()
        {
            InitializeComponent();
            newPasswordButton.Visible = false;
        }

        public DetailedUserForm(Employee user, bool editable)
        {
            InitializeComponent();

            this.user = user;

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
                newPasswordButton.Visible = false;
                passTextBox1.Visible = false;
                passTextBox2.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
            }
        }

        private void FillInControls()       // nie da sie wypelnic pol PESEL i mail, bo nie ma takich kolumn w bazie :(
        {
            nameTextBox.Text = user.Person.First_Name;
            surnameTextBox.Text = user.Person.Last_Name;
            sexComboBox.SelectedItem = (user.Person.Sex == "Male" ? sexComboBox.Items[0] : sexComboBox.Items[1]);
            //peselTextBox.Text = user.Person
            birthdatePicker.Value = (user.Person.Date_of_birth == null ? DateTime.Today : user.Person.Date_of_birth.Value);
            phoneTextBox.Text = user.Person.Phone_number;
            //mailTextBox.Text = user.Person.
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

            if (Common.UpdatePassword(user) != 0)
                MessageBox.Show("Hasło zostało zmienione");
            else
                MessageBox.Show("Nie udało się zmienić hasła!");

            passTextBox1.Text = "";
            passTextBox2.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(Common.UpdateEmployee(user) != 0)
                MessageBox.Show("Dane zaktualizowano pomyślnie.");
            else
                MessageBox.Show("Nie udało się zaktualizować danych.");

            Return();
        }
    }
}
