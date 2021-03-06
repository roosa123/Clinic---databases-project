﻿using DataLayer;
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
    public partial class RegistrationForm :BaseForm
    {
        private GridWrapper patientsCustomGrid;
        private GridWrapper appointmentsCustomGrid;
        private GridScheme patientsGridScheme;
        private GridScheme appointmentsGridScheme;

        public RegistrationForm()
        {
            InitializeComponent();
            statusComboBox.SelectedItem = "Zarejestrowana";
            InitializeDoctorsList();
            InitializeGrids();
        }

        private void InitializeDoctorsList()
        {
            List<Person> doctors = Common.GetDoctors();
            foreach (Person doc in doctors)
            {
                doctorComboBox.Items.Add(doc.First_Name + " " + doc.Last_Name);
                doctorComboBox1.Items.Add(doc.First_Name + " " + doc.Last_Name);
            }
            doctorComboBox.SelectedItem = doctorComboBox.Items[0];
            doctorComboBox1.SelectedItem = doctorComboBox.Items[0];
        }

        private void InitializeGrids()
        {
            patientsGridScheme = new GridScheme();
            patientsGridScheme.AddColumn("firstName", "Imię pacjenta").AddColumn("lastName", "Nazwisko pacjenta");
            patientsGridScheme.AddColumn("pesel", "PESEL").AddColumn("birthDT", "Data urodzenia").AddColumn("insurNo", "Numer ubezpieczenia").AddColumn("phone", "Numer telefonu");
            patientsGridScheme.AddColumn("id", "ID osoby", true);
            patientsCustomGrid = new GridWrapper(patientsDataGrid, patientsGridScheme);

            appointmentsGridScheme = new GridScheme();
            appointmentsGridScheme.AddColumn("firstName", "Imię pacjenta").AddColumn("lastName", "Nazwisko pacjenta").AddColumn("desc", "Opis");
            appointmentsGridScheme.AddColumn("diag", "Diagnoza").AddColumn("status", "Status").AddColumn("registerDT", "Data rejestracji").AddColumn("completeDT", "Data wizyty");
            appointmentsGridScheme.AddColumn("id", "ID wizyty", true);
            appointmentsCustomGrid = new GridWrapper(appointmentsDataGrid, appointmentsGridScheme);
        }

        private void searchPatientButton_Click(object sender, EventArgs e)
        {
            List<Patient> patients;
            if (peselTextBox.Text == string.Empty)
                patients = Common.GetPatientByName(nameTextBox.Text, surnameTextBox.Text);
            else
            {
                patients = new List<Patient>();
                patients.Add(Common.GetPatientByNameAndPESEL(nameTextBox.Text, surnameTextBox.Text, peselTextBox.Text));
            }

            FillPatientGrid(patients);
        }

        void FillPatientGrid(List<Patient> patients)
        {
            List<Tuple<List<string>, bool>> scheme = new List<Tuple<List<string>, bool>>();
            foreach (Patient item in patients)
            {
                List<string> row = new List<string>();
                row.Add(item.Person.First_Name);
                row.Add(item.Person.Last_Name);
                row.Add(item.PESEL);
                row.Add(item.Person.Date_of_birth.ToString());
                row.Add(item.Insurance_Number);
                row.Add(item.Person.Phone_number);
                row.Add(item.Id.ToString());
                scheme.Add(new Tuple<List<string>, bool>(row, true));
            }
            patientsCustomGrid.SetRows(scheme);
        }

        void FillAppointmentGrid(List<Appointment> appointments)
        {
            List<Tuple<List<string>, bool>> scheme = new List<Tuple<List<string>, bool>>();
            foreach (Appointment app in appointments)
            {
                Patient patient = Common.GetPatientById(app.PatientId);
                List<string> row = new List<string>();
                row.Add(patient.Person.First_Name);
                row.Add(patient.Person.Last_Name);
                row.Add(app.Description);
                row.Add(app.Diagnosis);
                row.Add(app.Status);
                row.Add(app.dt_Register.ToString());
                row.Add(app.dt_Complete_Cancel.ToString());
                row.Add(app.Id.ToString());
                scheme.Add(new Tuple<List<string>, bool>(row, true));
            }
            appointmentsCustomGrid.SetRows(scheme);
        }

        private void newPatientButton_Click(object sender, EventArgs e)
        {
            OpenForm(new DetailedPatientForm());
        }

        private Patient GetPatientFromGrid()
        {
            int id;
            int cellsNo = patientsCustomGrid.Grid.GetCellCount(DataGridViewElementStates.Selected);
            if(cellsNo == 0)
            {
                MessageBox.Show("Proszę wybrać pacjenta!");
                return null;
            }

            try
            {
                var cells = patientsCustomGrid.Grid.SelectedCells;
                var row = cells[0].OwningRow;
                var IDcell = row.Cells[row.Cells.Count - 1];
                id = int.Parse(IDcell.Value.ToString());
                foreach (DataGridViewCell cell in cells)
                {
                    if (cell.OwningRow != row)
                    {
                        MessageBox.Show("Please select only one appointment");
                        return null;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("internal error - invalid cell index");
                return null;
            }
            catch (FormatException)
            {
                MessageBox.Show("internal error - index parsing");
                return null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select the appointment");
                return null;
            }
            return Common.GetPatientById(id);
        }

        private Appointment GetAppointmentFromGrid()
        {
            int id;
            int cellsNo = appointmentsCustomGrid.Grid.GetCellCount(DataGridViewElementStates.Selected);
            if (cellsNo == 0)
            {
                MessageBox.Show("Proszę wybrać wizytę!");
                return null;
            }

            try
            {
                var cells = appointmentsCustomGrid.Grid.SelectedCells;
                var row = cells[0].OwningRow;
                var IDcell = row.Cells[row.Cells.Count - 1];
                id = int.Parse(IDcell.Value.ToString());
                foreach (DataGridViewCell cell in cells)
                {
                    if (cell.OwningRow != row)
                    {
                        MessageBox.Show("Please select only one appointment");
                        return null;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("internal error - invalid cell index");
                return null;
            }
            catch (FormatException)
            {
                MessageBox.Show("internal error - index parsing");
                return null;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select the appointment");
                return null;
            }
            return Common.GetAppointmentById(id);
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            Patient patient = GetPatientFromGrid();

            if (patient != null)
                OpenForm(new DetailedPatientForm(patient, true));
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            Patient patient = GetPatientFromGrid();

            if (patient != null)
                OpenForm(new DetailedPatientForm(patient, false));
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            DateTime date = appointmentDatePicker.Value;
            DateTime time = appointmentTimePicker.Value;
            string doctor = doctorComboBox.SelectedItem.ToString();
            Patient patient = GetPatientFromGrid();

            if(patient == null)
                return;

            int registrarId = 0;

            if(Program.CurrentUser.Position == "RegistrationPerson")
            {
                int regCount = Program.CurrentUser.RegistrationPerson.Count;

                if (regCount != 1)
                    return;

                RegistrationPerson reg = Program.CurrentUser.RegistrationPerson.First();

                if(reg != null)
                    registrarId = reg.Id;
            }

            if (Common.InsertAppointment(date, time, doctor, patient, registrarId) != 0)
                MessageBox.Show("Zarejestrowano wizytę");
            else
                MessageBox.Show("Błąd rejestracji");
        }

        private void searchAppointmentButton_Click(object sender, EventArgs e)
        {
            string[] ducky = doctorComboBox1.SelectedItem.ToString().Split(' ');
            string firstName = ducky[0];
            string lastName = ducky[1];
            DateTime dt = fromDateTimePicker.Value;

            List<Appointment> appointmentsList;

            if (!fromDateTimePicker.Checked)
                appointmentsList = Common.GetAppointmentsForDoctor(firstName, lastName, null, statusComboBox.SelectedItem.ToString());
            else
                appointmentsList = Common.GetAppointmentsForDoctor(firstName, lastName, dt, statusComboBox.SelectedItem.ToString());

            FillAppointmentGrid(appointmentsList);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Appointment appointment = GetAppointmentFromGrid();

            if (appointment == null)
                return;

            if (Common.DeleteAppointment(appointment) != 0)
                MessageBox.Show("Wizyta została anulowana");
            else
                MessageBox.Show("Nie udało się usunąć wizyty.");
        }
    }
}
