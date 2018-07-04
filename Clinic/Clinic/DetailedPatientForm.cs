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
            FillTextBoxes();
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

        private void FillTextBoxes()
        {
            try {
                Person p = patient.Person;
                nameTextBox.Text = p.First_Name;
                surnameTextBox.Text = p.Last_Name;
                if (p.Date_of_birth.HasValue)
                    birthdatePicker.Value = p.Date_of_birth.Value;
                peselTextBox.Text = patient.PESEL;
                insuranceTextBox.Text = patient.Insurance_Number;
                phoneTextBox.Text = p.Phone_number;
                sexComboBox.SelectedItem = p.Sex;
                cityTextBox.Text = p.Address.City;
                streetTextBox.Text = p.Address.Street;
                countryTextBox.Text = p.Address.Country;
                postcodeTextBox.Text = p.Address.Post_Code;
                apartmentTextBox.Text = p.Address.Flat_Number.ToString();
                houseTextBox.Text = p.Address.House_Number.ToString();
            }
            catch(NullReferenceException)
            {
                
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
