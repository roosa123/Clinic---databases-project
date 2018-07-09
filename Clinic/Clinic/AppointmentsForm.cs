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
        private GridWrapper custromGrid;
        private GridScheme gridScheme;

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
            
            gridScheme = new GridScheme();
            gridScheme.AddColumn("firstName", "Imię pacjenta").AddColumn("lastName", "Nazwisko pacjenta").AddColumn("desc", "Opis");
            gridScheme.AddColumn("diag", "Diagnoza").AddColumn("status", "Status").AddColumn("registerDT", "Data rejestracji").AddColumn("completeDT", "Data wizyty");
            gridScheme.AddColumn("id", "ID wizyty", true);
            custromGrid = new GridWrapper(appointmentsDataGrid, gridScheme);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            GetAppointmentsData();
        }

        private void GetAppointmentsData()
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
            List<Tuple<List<string>, bool>> scheme = new List<Tuple<List<string>, bool>>();
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
                scheme.Add(new Tuple<List<string>, bool>(row, true));
            }
            custromGrid.SetRows(scheme);
        }

        private Appointment GetSelectedAppointment()
        {
            int id;
            try {
                var cells = custromGrid.Grid.SelectedCells;
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
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select the appointment");
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
            {
                DetailedAppointmentForm detailedAppointmentForm = new DetailedAppointmentForm(appointment, true);
                DialogResult res = detailedAppointmentForm.ShowDialog(this);
                if(res==DialogResult.Cancel)
                    GetAppointmentsData();
            }
        }

        private void appointmentDetailsButton_Click(object sender, EventArgs e)
        {
            Appointment appointment = GetSelectedAppointment();
            if (appointment != null)
            {
                OpenForm(new DetailedAppointmentForm(appointment, false));
            }
        }
    }
}
