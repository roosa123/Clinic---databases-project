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
    public partial class ExaminationForm : BaseForm
    {
        private PhysicalExamination examination;

        public ExaminationForm(Appointment appointment)
        {
            InitializeComponent();
            examination = new PhysicalExamination();
            examination.Appointment = appointment;
            FillTextBoxes();
        }

        private void FillTextBoxes()
        {
            Person patient = examination.Appointment.Patient.Person;
            Person doctor = examination.Appointment.Doctor.Employee.Person;
            patientLabel.Text = patient.First_Name + " " + patient.Last_Name;
            codeLabel.Text = examination.ExaminationCode;
            doctorLabel.Text = doctor.First_Name + " " + doctor.Last_Name;
            dateLabel.Text = examination.Appointment.dt_Complete_Cancel.ToString();
            label8.Text = examination.Id.ToString();
            resultTextBox.Text = examination.Result;
            examinationLabel.Text = examination.Examinations.Name;
        }

        public ExaminationForm(PhysicalExamination examination)
        {
            InitializeComponent();
            this.examination = examination;

            //TODO download data from DB, fill in controls
            FillTextBoxes();
            searchButton.Visible = false;
            saveButton.Visible = false;
            resultTextBox.ReadOnly = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            OpenForm(new ExaminationListForm(examination));
            //TODO update controls
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //TODO update examination and appointment objects

            Return();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Return();
        }
    }
}
