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
        private bool ifNewPatient = false;

        public DetailedPatientForm()
        {
            InitializeComponent();
            tabControl.Enabled = false;
            detailsButton.Visible = false;
            returnButton2.Visible = false;
            ifNewPatient = true;

            InitializeGrids();
        }

        public DetailedPatientForm(Patient patient, bool editable)
        {
            InitializeComponent();

            InitializeGrids();
            this.patient = patient;

            nameTextBox.Text = patient.Person.First_Name;
            surnameTextBox.Text = patient.Person.Last_Name;
            birthdatePicker.Value = (patient.Person.Date_of_birth == null ? DateTime.Today : patient.Person.Date_of_birth.Value);
            sexComboBox.SelectedItem = (patient.Person.Sex == "Male" ? sexComboBox.Items[0] : sexComboBox.Items[1]);
            peselTextBox.Text = patient.PESEL;
            insuranceTextBox.Text = patient.Insurance_Number;
            countryTextBox.Text = (patient.Person.Address == null ? "" : patient.Person.Address.Country);
            cityTextBox.Text = (patient.Person.Address == null ? "" : patient.Person.Address.City);
            postcodeTextBox.Text = (patient.Person.Address == null ? "" : patient.Person.Address.Post_Code);
            streetTextBox.Text = (patient.Person.Address == null ? "" : patient.Person.Address.Street);
            houseTextBox.Text = (patient.Person.Address == null ? "" : (patient.Person.Address.House_Number == null ? "" : patient.Person.Address.House_Number.Value.ToString()));
            apartmentTextBox.Text = (patient.Person.Address == null ? "" : (patient.Person.Address.Flat_Number == null ? "" : patient.Person.Address.Flat_Number.Value.ToString()));
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

            FillAppointmentGrid(Common.GetAppointmentByPatinetId(patient.Id));
            FillLaboratoryExaminationGrid(Common.GetLabExamiantionByPatinetId(patient.Id));
            FillPhysicalExaminationGrid(Common.GetPhysExaminationByPatinetId(patient.Id));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (patient == null)
            {
                patient = new Patient();
            }

            if (patient.Person == null)
            {
                patient.Person = new Person();
            }

            if(patient.Person.Address == null)
            {
                patient.Person.Address = new Address();
            }

            patient.Person.First_Name = nameTextBox.Text;
            patient.Person.Last_Name = surnameTextBox.Text;
            patient.Person.Date_of_birth = birthdatePicker.Value;
            patient.Person.Sex = (sexComboBox.SelectedIndex == 0 ? "Male" : "Female");
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

            int result = 0;

            if (ifNewPatient)
                result = Common.InsertPatient(patient);
            else
                result = Common.UpdatePatient(patient);

            if(result != 0)
                MessageBox.Show("Zaktualizowano dane pacjenta.");
            else
                MessageBox.Show("Nie udało się zaktualizować danych pacjenta!");

            Return();
        }

        private void InitializeGrids()
        {
            appointmentsGridScheme = new GridScheme();
            appointmentsGridScheme.AddColumn("diag", "Diagnoza").AddColumn("status", "Status").AddColumn("registerDT", "Data rejestracji").AddColumn("completeDT", "Data wizyty");
            appointmentsGridScheme.AddColumn("id", "ID wizyty", true);
            appointmentsCustomGrid = new GridWrapper(appointmentsDataGrid, appointmentsGridScheme);
            
            examinationGridScheme = new GridScheme();
            examinationGridScheme.AddColumn("exCode", "Kod badania").AddColumn("name", "Nazwa").AddColumn("type", "Typ").AddColumn("res", "Wynik");
            examinationsCustomGrid = new GridWrapper(examinationsDataGrid, examinationGridScheme);

            laboratoryGridScheme = new GridScheme();
            laboratoryGridScheme.AddColumn("requestDT", "Data zgłoszenia").AddColumn("labPers", "Laborant").AddColumn("stat", "Status").AddColumn("res", "Wynik").AddColumn("supNote", "Notatka kierownika laboratorium").AddColumn("dNote", "Notatka lekarza");
            laboratoryGridScheme.AddColumn("exCode", "Kod badania").AddColumn("id", "ID badania", true);
            laboratoryCustomGrid = new GridWrapper(laboratoryDataGrid, laboratoryGridScheme);
        }

        void FillAppointmentGrid(List<Appointment> appointments)
        {
            List<Tuple<List<string>, bool>> scheme = new List<Tuple<List<string>, bool>>();
            foreach (Appointment app in appointments)
            {
                Patient patient = Common.GetPatientById(app.PatientId);
                List<string> row = new List<string>();
                row.Add(app.Diagnosis);
                row.Add(app.Status);
                row.Add(app.dt_Register.ToString());
                row.Add(app.dt_Complete_Cancel.ToString());
                row.Add(app.Id.ToString());
                scheme.Add(new Tuple<List<string>, bool>(row, true));
            }
            appointmentsCustomGrid.SetRows(scheme);
        }

        void FillLaboratoryExaminationGrid(List<LaboratoryExamination> labExaminations)
        {
            List<Tuple<List<string>, bool>> scheme = new List<Tuple<List<string>, bool>>();
            foreach (LaboratoryExamination ex in labExaminations)
            {
                List<string> row = new List<string>();
                row.Add(ex.dt_Request.ToString());
                row.Add(ex.LaboratoryPerson.Employee.Person.First_Name + " " + ex.LaboratoryPerson.Employee.Person.Last_Name);
                row.Add(ex.Status);
                row.Add(ex.Result);
                row.Add(ex.Supervisor_Note);
                row.Add(ex.Doctor_Note);
                row.Add(ex.ExaminationCode);
                scheme.Add(new Tuple<List<string>, bool>(row, true));
            }
            laboratoryCustomGrid.SetRows(scheme);
        }

        void FillPhysicalExaminationGrid(List<PhysicalExamination> physExaminations)
        {
            List<Tuple<List<string>, bool>> scheme = new List<Tuple<List<string>, bool>>();
            foreach (PhysicalExamination ex in physExaminations)
            {
                List<string> row = new List<string>();
                row.Add(ex.ExaminationCode);
                row.Add(ex.Examinations.Name);
                row.Add(ex.Examinations.Type);
                row.Add(ex.Result);
                row.Add(ex.Id.ToString());
                scheme.Add(new Tuple<List<string>, bool>(row, true));
            }
            examinationsCustomGrid.SetRows(scheme);
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
                var IDcell = row.Cells[0];
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
                var IDcell = row.Cells[row.Cells.Count - 1];
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

                    if (appointment != null)
                        OpenForm(new DetailedAppointmentForm(appointment, false));

                    break;
            case 1:
                    PhysicalExamination examination = GetExaminationFromGrid();

                    if (examination != null)
                        OpenForm(new ExaminationForm(examination));

                    break;
             case 2:
                    LaboratoryExamination laboratory = GetLaboratoryExaminationFromGrid();

                    if (laboratory != null)
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
