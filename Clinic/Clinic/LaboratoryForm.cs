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
    public partial class LaboratoryForm : BaseForm
    {
        public LaboratoryForm()
        {
            InitializeComponent();
            if (Program.CurrentUser.Position == "Laboratorian")
                statusComboBox.SelectedItem = "Zlecone";
            else
                statusComboBox.SelectedItem = "Wykonane";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //TODO download data from DB
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            LaboratoryExamination examination = new LaboratoryExamination();
            //TODO assign selected examination to variable examination
            OpenForm(new DetailedLaboratoryForm(examination, true));
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            LaboratoryExamination examination = new LaboratoryExamination();
            //TODO assign selected examination to variable examination
            OpenForm(new DetailedLaboratoryForm(examination, false));
        }
    }
}
