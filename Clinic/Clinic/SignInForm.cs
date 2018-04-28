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

namespace Przychodnia
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            //TODO authorization

            if (loginTextBox.Text == "Doctor" || loginTextBox.Text == "Registrar"
                || loginTextBox.Text == "Laboratorian" || loginTextBox.Text == "Supervisor"
                || loginTextBox.Text == "Admin")
            {
                Program.CurrentUser = new Employee();
                Program.CurrentUser.Position = loginTextBox.Text;
                Program.CurrentUser.Login = loginTextBox.Text;
                loginTextBox.Text = "";
                passwordTextBox.Text = "";
                switch (Program.CurrentUser.Position)
                {
                    case "Registrar":
                        new RegistrationForm().Show();
                        this.Hide();
                        break;
                    case "Doctor":
                        new AppointmentsForm().Show();
                        this.Hide();
                        break;
                    case "Laboratorian":
                        new LaboratoryForm().Show();
                        this.Hide();
                        break;
                    case "Supervisor":
                        new LaboratoryForm().Show();
                        this.Hide();
                        break;
                    case "Admin":
                        new UsersForm().Show();
                        this.Hide();
                        break;
                }
            }
            else
                MessageBox.Show(@"W polu login wprowadź jedną z ról: 
                    Doctor, Registrar, Laboratorian, Supervisor, Admin",
                    "Użytkownik nie istnieje");
        }
    }
}
