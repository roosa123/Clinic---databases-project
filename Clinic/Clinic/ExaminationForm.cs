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

namespace Przychodnia
{
    public partial class ExaminationForm : BaseForm
    {
        private Appointment _appointment;
        private PhysicalExamination examination;
        public ExaminationForm(ref Appointment appointment)
        {
            InitializeComponent();
            examination = new PhysicalExamination();
            examination.Appointment = appointment;
            _appointment = appointment;
            FillPatientDoctorLabels();
        }

        private void FillPatientDoctorLabels()
        {
            Person patient = examination.Appointment.Patient.Person;
            Person doctor = examination.Appointment.Doctor.Employee.Person;

            patientLabel.Text = patient.First_Name + " " + patient.Last_Name;
            doctorLabel.Text = doctor.First_Name + " " + doctor.Last_Name;
            dateLabel.Text = DateTime.Now.ToLongDateString();
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
            FillTextBoxes();
            searchButton.Visible = false;
            saveButton.Visible = false;
            resultTextBox.ReadOnly = true;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            ExaminationListForm examinationList = new ExaminationListForm(ref examination);
            DialogResult res = examinationList.ShowDialog(this);
            if (res == DialogResult.Cancel)
            {
                codeLabel.Text = examination.ExaminationCode;
                examinationLabel.Text = examination.Examinations.Name;
                examination.Id = Common.GetPhysicalExaminationsCount() + 1;
                label8.Text = examination.Id.ToString();
                examination.Examinations.Code = examination.ExaminationCode;
                examination.AppointmentId = _appointment.Id;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //TODO update examination and appointment objects
            examination.Result = resultTextBox.Text;
            _appointment.PhysicalExamination.Add(examination);
            Common.InsertPhysicalExamination(examination);
            Return();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Return();
        }
    }
}
