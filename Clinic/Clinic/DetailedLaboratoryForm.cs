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

            doctorLabel.Text = appointment.Doctor.Employee.Person.First_Name + " " + appointment.Doctor.Employee.Person.Last_Name;
            patientLabel.Text = appointment.Patient.Person.First_Name + " " + appointment.Patient.Person.Last_Name;
            requestDateLabel.Text = DateTime.Today.ToString();
        }

        public DetailedLaboratoryForm(LaboratoryExamination examination, bool editable)
        {
            InitializeComponent();
            this.examination = examination;

            examinationLabel.Text = examination.Examinations.Name;
            codeLabel.Text = examination.ExaminationCode;
            label1.Text = examination.Id.ToString();
            doctorLabel.Text = examination.Appointment.Doctor.Employee.Person.First_Name + " " + examination.Appointment.Doctor.Employee.Person.Last_Name;
            patientLabel.Text = examination.Appointment.Patient.Person.First_Name + " " + examination.Appointment.Patient.Person.Last_Name;
            requestDateLabel.Text = examination.dt_Request.ToString();
            doctorCommentTextBox.Text = examination.Doctor_Note;
            laboratorianLabel.Text = examination.LaboratoryPerson.Employee.Person.First_Name + " " + examination.LaboratoryPerson.Employee.Person.Last_Name;
            executionDateLlabel.Text = examination.dt_Complete_Cancel.ToString();
            resultsTextBox.Text = examination.Result;
            supervisorLabel.Text = examination.LaboratorySupervisor.Employee.Person.First_Name + " " + examination.LaboratorySupervisor.Employee.Person.Last_Name;
            confirmationDateLabel.Text = examination.dt_Confirmation.ToString();
            supervisorCommentTextBox.Text = examination.Supervisor_Note;

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
            OpenForm(new ExaminationListForm(ref examination));

            examinationLabel.Text = examination.Examinations.Name;
            codeLabel.Text = examination.ExaminationCode;
            label1.Text = examination.Id.ToString();
            doctorCommentTextBox.Text = examination.Doctor_Note;
            laboratorianLabel.Text = examination.LaboratoryPerson.Employee.Person.First_Name + " " + examination.LaboratoryPerson.Employee.Person.Last_Name;
            executionDateLlabel.Text = examination.dt_Complete_Cancel.ToString();
            resultsTextBox.Text = examination.Result;
            supervisorLabel.Text = examination.LaboratorySupervisor.Employee.Person.First_Name + " " + examination.LaboratorySupervisor.Employee.Person.Last_Name;
            confirmationDateLabel.Text = examination.dt_Confirmation.ToString();
            supervisorCommentTextBox.Text = examination.Supervisor_Note;
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            examination.Examinations.Name = examinationLabel.Text;
            examination.ExaminationCode = codeLabel.Text;
            int number = 0;
            int.TryParse(label1.Text, out number);
            examination.Id = number;

            string[] ducky = doctorLabel.Text.Split(' ');
            examination.Appointment.Doctor.Employee.Person.First_Name = ducky[0];
            examination.Appointment.Doctor.Employee.Person.Last_Name = ducky[1];

            ducky = patientLabel.Text.Split(' ');

            examination.Appointment.Patient.Person.First_Name = ducky[0];
            examination.Appointment.Patient.Person.Last_Name = ducky[1];

            DateTime date;
            DateTime.TryParse(requestDateLabel.Text, out date);

            examination.dt_Request = date;
            examination.Doctor_Note = doctorCommentTextBox.Text;

            ducky = laboratorianLabel.Text.Split(' ');

            examination.LaboratoryPerson.Employee.Person.First_Name = ducky[0];
            examination.LaboratoryPerson.Employee.Person.Last_Name = ducky[1];

            DateTime.TryParse(executionDateLlabel.Text, out date);

            examination.dt_Complete_Cancel = date;
            examination.Result = resultsTextBox.Text;

            ducky = supervisorLabel.Text.Split(' ');

            examination.LaboratorySupervisor.Employee.Person.First_Name = ducky[0];
            examination.LaboratorySupervisor.Employee.Person.Last_Name = ducky[1];

            DateTime.TryParse(confirmationDateLabel.Text, out date);

            examination.dt_Confirmation = date;
            examination.Supervisor_Note = supervisorCommentTextBox.Text;

            if (Common.InsertLaboratoryExamination(examination) != 0)
                MessageBox.Show("Zlecono badanie.");
            else
                MessageBox.Show("Nie udało się zlecić badania!");

            Return();
        }

        private void returnButton1_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            examination.Status = "done";
            examination.Result = resultsTextBox.Text;
            examination.dt_Complete_Cancel = DateTime.Today;

            if (Common.UpdateLaboratoryExamination(examination) != 0)
                MessageBox.Show("Badanie wykonano.");
            else
                MessageBox.Show("Nie udało się wykonać badania!");

            Return();
        }

        private void cancelButton1_Click(object sender, EventArgs e)
        {
            examination.Status = "cancelled";
            examination.Result = resultsTextBox.Text;
            examination.dt_Complete_Cancel = DateTime.Today;

            if (Common.UpdateLaboratoryExamination(examination) != 0)
                MessageBox.Show("Badanie anulowano.");
            else
                MessageBox.Show("Nie udało się anulować badania!");

            Return();
        }

        private void returnButton2_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            examination.Status = "confirmed";
            examination.Supervisor_Note = supervisorCommentTextBox.Text;
            examination.dt_Confirmation = DateTime.Today;

            if (Common.UpdateLaboratoryExamination(examination) != 0)
                MessageBox.Show("Badanie potwierdzono.");
            else
                MessageBox.Show("Nie udało się potwierdzić badania!");

            Return();
        }

        private void cancelButton2_Click(object sender, EventArgs e)
        {
            examination.Status = "cancelled";
            examination.Supervisor_Note = supervisorCommentTextBox.Text;
            examination.dt_Complete_Cancel = DateTime.Today;

            if (Common.UpdateLaboratoryExamination(examination) != 0)
                MessageBox.Show("Badanie anulowano.");
            else
                MessageBox.Show("Nie udało się anulować badania!");

            Return();
        }

        private void returnButton3_Click(object sender, EventArgs e)
        {
            Return();
        }
    }
}
