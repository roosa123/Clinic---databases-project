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
            //TODO download user data from DB, fill in controls

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

        private void returnButton1_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void newPasswordButton_Click(object sender, EventArgs e)
        {
            //TODO validate password
            if(passTextBox1.Text == passTextBox2.Text)
            {
                //TODO update DB
                MessageBox.Show("Hasło zostało zmienione");
            }
            else
            {
                MessageBox.Show("Hasło jest niepoprawne");
            }
            passTextBox1.Text = "";
            passTextBox2.Text = "";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //TODO update DB

            Return();
        }
    }
}
