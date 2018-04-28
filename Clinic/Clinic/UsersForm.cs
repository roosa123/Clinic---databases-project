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
    public partial class UsersForm : BaseForm
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //TODO download data from DB
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Employee user = new Employee();
            //TODO assign selected user to variable user
            OpenForm(new DetailedUserForm(user, true));
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OpenForm(new DetailedUserForm());
        }
    }
}
