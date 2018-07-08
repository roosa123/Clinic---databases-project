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
    public partial class BaseForm : Form
    {

        protected bool userClose = false;

        public BaseForm()
        {
            InitializeComponent();
            userButton.Text = Program.CurrentUser.Login;
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailedUserForm wnd = new DetailedUserForm(Program.CurrentUser,false);
            wnd.Show(this);
            wnd.Location = this.Location;
            this.Hide();
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy chcesz się wylogować?",
                "Wylogowywanie", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Program.CurrentUser = null;
                userClose = true;
                while (Application.OpenForms.Count > 1)
                    Application.OpenForms[1].Close();
                Application.OpenForms[0].Show();
            }
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!userClose && !Program.Close)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz wyjść z programu?",
                    "Wyjście", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Program.Close = true;
                    Application.Exit();
                }
                else
                    e.Cancel = true;
            }
            else
                userClose = false;
        }

        protected void Return()
        {
            userClose = true;

            if(Owner != null)
            {
                this.Owner.Location = this.Location;
                this.Owner.Show();
            }

            this.Close();
        }

        protected void OpenForm(BaseForm form)
        {
            form.Show(this);
            form.Location = this.Location;
            this.Hide();
        }
    }
}
