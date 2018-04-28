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
    public partial class DetailedLaboratoryForm : BaseForm
    {
        LaboratoryExamination examination;

        public DetailedLaboratoryForm(Appointment appointment)
        {
            InitializeComponent();

            InitializeComponent();
            examination = new LaboratoryExamination();
            examination.Appointment = appointment;

            laboratorianPanel.Enabled = false;
            supervisorPanel.Enabled = false;

            //TODO fill in textboxes
        }

        public DetailedLaboratoryForm(LaboratoryExamination examination, bool editable)
        {
            InitializeComponent();
            this.examination = examination;

            //TODO download data from DB, fill in controls

            doctorPanel.Enabled = false;
            supervisorPanel.Enabled = false;
            laboratorianPanel.Enabled = false;
            if (Program.CurrentUser.Position == "Laboratorian")
            {
                laboratorianPanel.Enabled = true;
                if(!editable)
                {
                    executeButton.Enabled = false;
                    cancelButton1.Enabled = false;
                    resultsTextBox.ReadOnly = true;
                }
            }
            else if (Program.CurrentUser.Position == "Supervisor")
            {
                supervisorPanel.Enabled = true;
                if (!editable)
                {
                    confirmButton.Enabled = false;
                    cancelButton2.Enabled = false;
                    supervisorCommentTextBox.ReadOnly = true;
                }
            }
            else
            {
                doctorPanel.Enabled = true;
                if (!editable)
                {
                    requestButton.Enabled = false;
                    searchButton.Enabled = false;
                    doctorCommentTextBox.ReadOnly = true;
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            OpenForm(new ExaminationListForm(examination));
            //TODO update controls values
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            //TODO update examination and appointment objects

            Return();
        }

        private void returnButton1_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            //TODO update examination and appointment objects

            Return();
        }

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            //TODO update examination and appointment objects

            Return();
        }

        private void returnButton2_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //TODO update examination and appointment objects

            Return();
        }

        private void cancelButton2_Click(object sender, EventArgs e)
        {
            //TODO update examination and appointment objects

            Return();
        }

        private void returnButton3_Click(object sender, EventArgs e)
        {
            Return();
        }
    }
}
