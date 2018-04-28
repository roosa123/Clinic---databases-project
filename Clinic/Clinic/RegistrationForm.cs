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
    public partial class RegistrationForm :BaseForm
    {
        public RegistrationForm()
        {
            InitializeComponent();
            statusComboBox.SelectedItem = "Zarejestrowana";
            //TODO dowload doctor list from DB
        }

        private void searchPatientButton_Click(object sender, EventArgs e)
        {
            //TODO download data from DB
        }

        private void newPatientButton_Click(object sender, EventArgs e)
        {
            OpenForm(new DetailedPatientForm());
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            //TODO assign selected patient to variable patient
            OpenForm(new DetailedPatientForm(patient, true));
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            //TODO assign selected patient to variable patient
            OpenForm(new DetailedPatientForm(patient, false));
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //TODO validate appointment
            if(true)
            {
                //TODO update DB
                MessageBox.Show("Zarejestrowano wizytę");
            }
            else
            {
                MessageBox.Show("Błąd rejestracji");
            }
            appointmentDatePicker.Value = DateTime.Today;
            appointmentTimePicker.Value = DateTime.Now;
            doctorComboBox.SelectedIndex = -1;
        }

        private void searchAppointmentButton_Click(object sender, EventArgs e)
        {
            //TODO download data from DB
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //TODO update DB
            MessageBox.Show("Wizyta została anulowana");
        }
    }
}
