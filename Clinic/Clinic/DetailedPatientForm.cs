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
    public partial class DetailedPatientForm : BaseForm
    {
        private Patient patient;

        public DetailedPatientForm()
        {
            InitializeComponent();
            tabControl.Enabled = false;
            detailsButton.Visible = false;
            returnButton2.Visible = false;
        }

        public DetailedPatientForm(Patient patient, bool editable)
        {
            InitializeComponent();

            //TODO download patient data from DB, fill in controls
            this.patient = patient;

            if (editable)
            {
                tabControl.Enabled = false;
                detailsButton.Visible = false;
                returnButton2.Visible = false;
            }
            else
            {
                nameTextBox.ReadOnly = true;
                surnameTextBox.ReadOnly = true;
                birthdatePicker.Enabled = false;
                sexComboBox.Enabled = false;
                peselTextBox.ReadOnly = true;
                insuranceTextBox.ReadOnly = true;
                countryTextBox.ReadOnly = true;
                cityTextBox.ReadOnly = true;
                postcodeTextBox.ReadOnly = true;
                streetTextBox.ReadOnly = true;
                houseTextBox.ReadOnly = true;
                apartmentTextBox.ReadOnly = true;
                phoneTextBox.ReadOnly = true;
                saveButton.Enabled = false;
                if(Program.CurrentUser.Position == "Registrar")
                {
                    tabControl.Enabled = false;
                    detailsButton.Visible = false;
                    returnButton2.Visible = false;
                }
                else
                {
                    saveButton.Visible = false;
                    returnButton1.Visible = false;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //TODO update DB

            Return();
        }

        private void returnButton1_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            switch(tabControl.SelectedIndex)
            {
            case 0:
                Appointment appointment = new Appointment();
                //TODO assign selected appointment to variable appointment
                OpenForm(new DetailedAppointmentForm(appointment, false));
                break;
            case 1:
                PhysicalExamination examination = new PhysicalExamination();
                //TODO assign selected examination to variable examination
                OpenForm(new ExaminationForm(examination));
                break;
             case 2:
                LaboratoryExamination laboratory = new LaboratoryExamination();
                //TODO assign selected examination to variable laboratory
                OpenForm(new DetailedLaboratoryForm(laboratory, false));
                break;
            }
        }

        private void returnButton2_Click(object sender, EventArgs e)
        {
            Return();
        }
    }
}
