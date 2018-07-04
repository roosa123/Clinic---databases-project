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
    public partial class AppointmentsForm : BaseForm
    {
        private List<Tuple<string, string>> appointmentGridInfo;

        public AppointmentsForm()
        {
            InitializeComponent();
            statusComboBox.SelectedItem = "-";
            InitializeDoctorsCombo();
            InitializeAppointmentGrid();
        }

        private void InitializeDoctorsCombo()
        {
            List<Person> doctors = Common.GetDoctors();
            foreach (Person doc in doctors)
            {
                doctorComboBox.Items.Add(doc.First_Name + " " + doc.Last_Name);
            }
            doctorComboBox.SelectedItem = doctorComboBox.Items[0];
        }

        private void InitializeAppointmentGrid()
        {
            appointmentGridInfo = new List<Tuple<string, string>>();
            appointmentGridInfo.Add(new Tuple<string, string>("firstName", "Patient first name"));
            appointmentGridInfo.Add(new Tuple<string, string>("lastName", "Patient last name"));
            appointmentGridInfo.Add(new Tuple<string, string>("desc", "Description"));
            appointmentGridInfo.Add(new Tuple<string, string>("diag", "Diagnosis"));
            appointmentGridInfo.Add(new Tuple<string, string>("status", "Status"));
            appointmentGridInfo.Add(new Tuple<string, string>("registerDT", "Register Date"));
            appointmentGridInfo.Add(new Tuple<string, string>("completeDT", "Complete Date"));
            appointmentGridInfo.Add(new Tuple<string, string>("id", "Appointment ID"));
            foreach (Tuple <string, string> desc in appointmentGridInfo)
            {
                appointmentsDataGrid.Columns.Add(desc.Item1, desc.Item2);
            }
            //TODO: resize grid to fit the window.
            appointmentsDataGrid.AutoGenerateColumns = false;
            int columnsCount = appointmentsDataGrid.ColumnCount;
            appointmentsDataGrid.Columns[columnsCount - 1].Visible = false;
            appointmentsDataGrid.RowHeadersVisible = false; // = appointmentsDataGrid.Width;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string[] ducky = doctorComboBox.SelectedItem.ToString().Split(' ');
            string firstName = ducky[0];
            string lastName = ducky[1];
            DateTime dt = fromDateTimePicker.Value;
            if (!fromDateTimePicker.Checked)
                dt = DateTime.MinValue;
            List<Appointment> appointmentsList = Common.GetAppointmentsForDoctor(firstName, lastName,
                dt, statusComboBox.SelectedItem.ToString());
            FillAppointmentsGrid(appointmentsList);
        }

        private void FillAppointmentsGrid(List<Appointment> content)
        {
            appointmentsDataGrid.Rows.Clear();
            foreach ( Appointment app in content)
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
                DataGridViewRow gridRow = new DataGridViewRow();
                gridRow.CreateCells(appointmentsDataGrid, row.ToArray());
                gridRow.ReadOnly = true;
                appointmentsDataGrid.Rows.Add(gridRow);
            }
            appointmentsDataGrid.AutoResizeColumns();
            appointmentsDataGrid.AutoResizeRows();
        }

        private Appointment GetSelectedAppointment()
        {
            int id;
            try {
                var cells = appointmentsDataGrid.SelectedCells;
                var row = cells[0].OwningRow;
                var IDcell = row.Cells[row.Cells.Count - 1];
                id = int.Parse( IDcell.Value.ToString());
                foreach (DataGridViewCell cell in cells)
                {
                    if(cell.OwningRow!= row)
                    {
                        MessageBox.Show("Please select only one appointment");
                        return null;
                    }
                }
            }
            catch(IndexOutOfRangeException)
            {
                MessageBox.Show("internal error - invalid cell index");
                return null;
            }
            catch( FormatException )
            {
                MessageBox.Show("internal error - index parsing");
                return null;
            }
            catch ( NullReferenceException )
            {
                MessageBox.Show("Please select the appointment");
                return null;
            }
            return Common.GetAppointmentById(id);
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            Appointment appointment = GetSelectedAppointment();
            if (appointment != null)
                OpenForm(new DetailedAppointmentForm(appointment, false));
        }

        private void appointmentDetailsButton_Click(object sender, EventArgs e)
        {
            Appointment appointment = GetSelectedAppointment();
            if(appointment!=null)
                OpenForm(new DetailedAppointmentForm(appointment, false));
        }
    }
}
