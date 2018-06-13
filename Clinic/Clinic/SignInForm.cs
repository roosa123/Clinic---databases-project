using BusinessLayer;
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
            if(loginTextBox.Text==null)
            {
                MessageBox.Show("Wprowadź login i hasło!","Brak poświadczeń");
                return;
            }

            if(!Authorization.UserExists(loginTextBox.Text))
            {
                MessageBox.Show("Wprowadono błędny login!", "Użytkownik nie istnieje");
                return;
            }

            if(!Authorization.LogIn(loginTextBox.Text,passwordTextBox.Text))
            {
                MessageBox.Show("Wprowadono błędne hasło!", "Błąd logowania");
                return;
            }

            Program.CurrentUser = Authorization.GetUser(loginTextBox.Text, passwordTextBox.Text);
            switch (Program.CurrentUser.Position)
            {
                case "RegistrationPerson":
                    new RegistrationForm().Show();
                    this.Hide();
                    break;
                case "Doctor":
                    new AppointmentsForm().Show();
                    this.Hide();
                    break;
                case "LaboratoryPerson":
                    new LaboratoryForm().Show();
                    this.Hide();
                    break;
                case "LaboratorySupervisor":
                    new LaboratoryForm().Show();
                    this.Hide();
                    break;
                case "Admin":
                    new UsersForm().Show();
                    this.Hide();
                    break;
            }

            loginTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
