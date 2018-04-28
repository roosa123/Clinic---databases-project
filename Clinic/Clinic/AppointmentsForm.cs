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
    public partial class AppointmentsForm : BaseForm
    {
        public AppointmentsForm()
        {
            InitializeComponent();
            statusComboBox.SelectedItem = "Zarejestrowana";
            //TODO dowload doctor list from DB
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //TODO download data from DB
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            //TODO assign selected appointment to variable appointment
            OpenForm(new DetailedAppointmentForm(appointment, true));
        }

        private void appointmentDetailsButton_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            //TODO assign selected appointment to variable appointment
            OpenForm(new DetailedAppointmentForm(appointment, false));
        }
    }
}
