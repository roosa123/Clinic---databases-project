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
    public partial class DetailedPatientForm : BaseForm
    {
        private Patient patient;
        private GridWrapper appointmentsCustomGrid;
        private GridWrapper examinationsCustomGrid;
        private GridWrapper laboratoryCustomGrid;
        private GridScheme appointmentsGridScheme;
        private GridScheme examinationGridScheme;
        private GridScheme laboratoryGridScheme;

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

            this.patient = patient;

            nameTextBox.Text = patient.Person.First_Name;
            surnameTextBox.Text = patient.Person.Last_Name;
            birthdatePicker.Value = patient.Person.Date_of_birth.Value;
            sexComboBox.Text = patient.Person.Sex;
            peselTextBox.Text = patient.PESEL;
            insuranceTextBox.Text = patient.Insurance_Number;
            countryTextBox.Text = patient.Person.Address.Country;
            cityTextBox.Text = patient.Person.Address.City;
            postcodeTextBox.Text = patient.Person.Address.Post_Code;
            streetTextBox.Text = patient.Person.Address.Street;
            houseTextBox.Text = patient.Person.Address.House_Number == null ? "" : patient.Person.Address.House_Number.Value.ToString();
            apartmentTextBox.Text = patient.Person.Address.Flat_Number == null ? "" : patient.Person.Address.Flat_Number.Value.ToString();
            phoneTextBox.Text = patient.Person.Phone_number;

            saveButton.Enabled = editable;


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

                if (Program.CurrentUser.Position == "Registrar")
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
            patient.Person.First_Name = nameTextBox.Text;
            patient.Person.Last_Name = surnameTextBox.Text;
            patient.Person.Date_of_birth = birthdatePicker.Value;
            patient.Person.Sex = sexComboBox.Text;
            patient.PESEL = peselTextBox.Text;
            patient.Insurance_Number = insuranceTextBox.Text;
            patient.Person.Address.Country = countryTextBox.Text;
            patient.Person.Address.City = cityTextBox.Text;
            patient.Person.Address.Post_Code = postcodeTextBox.Text;
            patient.Person.Address.Street = streetTextBox.Text;
            int number = 0;
            int.TryParse(houseTextBox.Text, out number);
            patient.Person.Address.House_Number = number;
            int.TryParse(apartmentTextBox.Text, out number);
            patient.Person.Address.Flat_Number = number;
            patient.Person.Phone_number = phoneTextBox.Text;

            Common.UpdatePatient(patient);

            Return();
        }

        private void InitializeGrids()
        {
            appointmentsGridScheme = new GridScheme();
            appointmentsGridScheme.AddColumn("firstName", "Patient first name").AddColumn("lastName", "Patient last name").AddColumn("desc", "Description");
            appointmentsGridScheme.AddColumn("diag", "Diagnosis").AddColumn("status", "Status").AddColumn("registerDT", "Register Date").AddColumn("completeDT", "Complete Date");
            appointmentsGridScheme.AddColumn("id", "Appointment ID", true);
            appointmentsCustomGrid = new GridWrapper(appointmentsDataGrid, appointmentsGridScheme);
            
            examinationGridScheme = new GridScheme();
            examinationGridScheme.AddColumn("firstName", "Patient first name").AddColumn("lastName", "Patient last name");
            examinationGridScheme.AddColumn("exCode", "Examination Code").AddColumn("name", "Name").AddColumn("type", "Type").AddColumn("labEx", "Laboratory Examinations").AddColumn("physEx", "Physical Examinations").AddColumn("res", "Result");
            examinationGridScheme.AddColumn("id", "Examination ID", true);
            examinationsCustomGrid = new GridWrapper(appointmentsDataGrid, appointmentsGridScheme);

            laboratoryGridScheme = new GridScheme();
            laboratoryGridScheme.AddColumn("firstName", "Patient first name").AddColumn("lastName", "Patient last name");
            laboratoryGridScheme.AddColumn("dNote", "Doctor Note").AddColumn("requestDT", "Date of request").AddColumn("labPers", "Laboratory Person").AddColumn("stat", "Status").AddColumn("res", "Result").AddColumn("supNote", "Laboratory Supervisor Note");
            laboratoryGridScheme.AddColumn("exCode", "Examination Code").AddColumn("id", "Examination ID", true);
            laboratoryCustomGrid = new GridWrapper(appointmentsDataGrid, appointmentsGridScheme);
        }

        private void returnButton1_Click(object sender, EventArgs e)
        {
            Return();
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
                        MessageBox.Show("Proszę wybrać jedną wizytę!");
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

        private PhysicalExamination GetExaminationFromGrid()
        {
            int code;
            int cellsNo = examinationsCustomGrid.Grid.GetCellCount(DataGridViewElementStates.Selected);
            if (cellsNo == 0)
            {
                MessageBox.Show("Proszę wybrać badanie!");
                return null;
            }

            try
            {
                var cells = examinationsCustomGrid.Grid.SelectedCells;
                var row = cells[0].OwningRow;
                var IDcell = row.Cells[row.Cells.Count - 2];
                code = int.Parse(IDcell.Value.ToString());
                foreach (DataGridViewCell cell in cells)
                {
                    if (cell.OwningRow != row)
                    {
                        MessageBox.Show("Proszę wybrać jedno badanie!");
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
            return Common.GetPhysicalExaminationByCode(code);
        }

        private LaboratoryExamination GetLaboratoryExaminationFromGrid()
        {
            int code;
            int cellsNo = laboratoryCustomGrid.Grid.GetCellCount(DataGridViewElementStates.Selected);
            if (cellsNo == 0)
            {
                MessageBox.Show("Proszę wybrać badanie!");
                return null;
            }

            try
            {
                var cells = laboratoryCustomGrid.Grid.SelectedCells;
                var row = cells[0].OwningRow;
                var IDcell = row.Cells[row.Cells.Count - 2];
                code = int.Parse(IDcell.Value.ToString());
                foreach (DataGridViewCell cell in cells)
                {
                    if (cell.OwningRow != row)
                    {
                        MessageBox.Show("Proszę wybrać jedno badanie!");
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
            return Common.GetLaboratoryExaminationByCode(code);
        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            switch(tabControl.SelectedIndex)
            {
            case 0:
                    Appointment appointment = GetAppointmentFromGrid();
                    OpenForm(new DetailedAppointmentForm(appointment, false));
                    break;
            case 1:
                    PhysicalExamination examination = GetExaminationFromGrid();
                    OpenForm(new ExaminationForm(examination));
                break;
             case 2:
                    LaboratoryExamination laboratory = GetLaboratoryExaminationFromGrid();
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
