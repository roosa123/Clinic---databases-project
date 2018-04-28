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
    public partial class DetailedAppointmentForm : BaseForm
    {
        private Appointment appointment;

        public DetailedAppointmentForm(Appointment appointment, bool editable)
        {
            InitializeComponent();

            //TODO download data from DB, fill in controls with values
            this.appointment = appointment;

            if(!editable)
            {
                addExaminationButton.Enabled = false;
                addLaboratoryButton.Enabled = false;
                confirmButton.Enabled = false;
                cancelButton.Enabled = false;
                descriptionTextBox.ReadOnly = true;
                diagnosisTextBox.ReadOnly = true;

                //TODO download historical data about appointment, fill in controls with values
            }
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            OpenForm(new DetailedPatientForm(appointment.Patient, false));
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //TODO update DB

            Return();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //TODO update DB

            Return();
        }

        private void returnButton2_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void addExaminationButton_Click(object sender, EventArgs e)
        {
            OpenForm(new ExaminationForm(appointment));
            //TODO add examination to datagrid
        }

        private void examinationDetailsButton_Click(object sender, EventArgs e)
        {
            PhysicalExamination examination = new PhysicalExamination();
            //TODO assign selected examination to variable examination
            OpenForm(new ExaminationForm(examination));
        }

        private void addLaboratoryButton_Click(object sender, EventArgs e)
        {
            OpenForm(new DetailedLaboratoryForm(appointment));
            //TODO add examination to datagrid
        }

        private void laboratoryDetailsButton_Click(object sender, EventArgs e)
        {
            LaboratoryExamination laboratory = new LaboratoryExamination();
            //TODO assign selected examination to variable laboratory
            OpenForm(new DetailedLaboratoryForm(laboratory, false));
        }
    }
}
