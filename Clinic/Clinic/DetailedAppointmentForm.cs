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
    
    public partial class DetailedAppointmentForm : BaseForm
    {
        private GridWrapper ExaminationGrid;
        private GridScheme ExaminationGridScheme;
        private GridWrapper LaboratoryGrid;
        private GridScheme LaboratoryGridScheme;
        private const int INTERNAL_ERROR_FLAG = -1;
        private const int MULTIPLE_SELECTION_FLAG = -2;
        private const int NO_SELECTION = -3;

        private Appointment appointment;
        private Patient patient;
        private List<Tuple<string,string>> ExaminationGridInfo;
        private List<Tuple<string, string>> LaboratoryGridInfo;
        public DetailedAppointmentForm(Appointment appointment, bool editable)
        {
            InitializeComponent();

            this.appointment = appointment;
            this.patient = appointment.Patient;
            InitializePatientSection();
            InitializeAppointmentSection();
            InitializeTextBoxes();
            InitializeGrids();
            FillGrids();
            if (!editable)
            {
                addExaminationButton.Enabled = false;
                addLaboratoryButton.Enabled = false;
                confirmButton.Enabled = false;
                cancelButton.Enabled = false;
                descriptionTextBox.ReadOnly = true;
                diagnosisTextBox.ReadOnly = true;

                //TODO download historical data about appointment, fill in controls with values
            }
        }
        private int HandleErrorFlag(int flag)
        {
            switch (flag)
            {
                case INTERNAL_ERROR_FLAG:
                    MessageBox.Show("Internal error");
                    break;
                case MULTIPLE_SELECTION_FLAG:
                    MessageBox.Show("Please select single item");
                    break;
                case NO_SELECTION:
                    MessageBox.Show("Please select record");
                    break;
            }
            return flag;
        }
        private void InitializePatientSection()
        {
            nameLabel.Text = patient.Person.First_Name;
            surnameLabel.Text = patient.Person.Last_Name;
            birthdateLabel.Text = patient.Person.Date_of_birth.ToString();
            peselLabel.Text = patient.PESEL;
        }

        private void InitializeAppointmentSection()
        {
            statusLabel.Text = appointment.Status.ToString();
            dateLabel.Text = appointment.dt_Complete_Cancel.Date.ToString();
            timeLabel.Text = appointment.dt_Complete_Cancel.TimeOfDay.ToString();
            doctorLabel.Text = appointment.Doctor.Employee.Person.First_Name + " " + appointment.Doctor.Employee.Person.Last_Name;
            label12.Text = appointment.RegistrationPerson.Employee.Person.First_Name + " " + appointment.RegistrationPerson.Employee.Person.Last_Name;
            label11.Text = appointment.dt_Register.ToString();
        }

        private void InitializeTextBoxes()
        {
            descriptionTextBox.Text = appointment.Description;
            diagnosisTextBox.Text = appointment.Diagnosis;
        }

        private void InitializeGrids()
        {
            InitializeExaminationsGrid();
            InitializeLaboratyGrid();
        }

        private void InitializeExaminationsGrid()
        {
            ExaminationGridScheme = new GridScheme();
            ExaminationGridScheme.AddColumn("code", "Code").AddColumn("name", "Name").AddColumn("result", "Result");
            ExaminationGridScheme.AddColumn("id", "ID", true);
            ExaminationGrid = new GridWrapper(examinationsDataGrid, ExaminationGridScheme);
        }

        private void InitializeLaboratyGrid()
        {
            LaboratoryGridScheme = new GridScheme();
            LaboratoryGridScheme.AddColumn("code", "Code").AddColumn("name", "Name").AddColumn("result", "Result");
            LaboratoryGridScheme.AddColumn("status", "Status").AddColumn("note", "Supervisor note").AddColumn("id", "ID", true);
            LaboratoryGrid = new GridWrapper(laboratoryDataGrid, LaboratoryGridScheme);
        }

        private void FillGrids()
        {
            FillExaminationGrid();
            FillLaboratoryGrid();
        }
        
        private void FillLaboratoryGrid()
        {
            List<Tuple<List<string>, bool>> scheme = new List<Tuple<List<string>, bool>>();
            foreach (LaboratoryExamination lExam in appointment.LaboratoryExamination)
            {
                DataGridViewRow gridRow = new DataGridViewRow();
                List<string> row = new List<string>();
                row.Add(lExam.ExaminationCode);
                row.Add(lExam.Examinations.Name);
                row.Add(lExam.Result);
                row.Add(lExam.Status);
                row.Add(lExam.Supervisor_Note);
                row.Add(lExam.Id.ToString());
                scheme.Add(new Tuple<List<string>, bool>(row, true));
            }
            LaboratoryGrid.SetRows(scheme);
        }

        private void FillExaminationGrid()
        {
            List<Tuple<List<string>, bool>> scheme = new List<Tuple<List<string>, bool>>();
            foreach ( PhysicalExamination pExam in appointment.PhysicalExamination)
            {
                DataGridViewRow gridRow = new DataGridViewRow();
                List<string> row = new List<string>();
                row.Add(pExam.ExaminationCode);
                row.Add(pExam.Examinations.Name);
                row.Add(pExam.Result);
                row.Add(pExam.Id.ToString());
                scheme.Add(new Tuple<List<string>, bool>(row, true));
            }
            ExaminationGrid.SetRows(scheme);
        }

        private int GetSelectedIndex(DataGridView grid)
        {
            int id;
            try
            {
                var cells = grid.SelectedCells;
                var row = cells[0].OwningRow;
                var IDcell = row.Cells[row.Cells.Count - 1];
                id = int.Parse(IDcell.Value.ToString());
                foreach (DataGridViewCell cell in cells)
                {
                    if (cell.OwningRow != row)
                    {
                        return MULTIPLE_SELECTION_FLAG;
                    }
                }
            }
            catch (IndexOutOfRangeException )  { return INTERNAL_ERROR_FLAG;}
            catch (FormatException) { return INTERNAL_ERROR_FLAG; }
            catch(NullReferenceException) { return NO_SELECTION; }
            return id;
        }
        private PhysicalExamination GetSelectedPhysicalExamination()
        {
            int idx = HandleErrorFlag(GetSelectedIndex(ExaminationGrid.Grid));
            foreach (PhysicalExamination pExam in appointment.PhysicalExamination)
            {
                if (pExam.Id == idx)
                {
                    return pExam;
                }
            }
            return null;
        }
        private LaboratoryExamination GetSelectedLaboratoryExamination()
        {
            int idx = HandleErrorFlag(GetSelectedIndex(LaboratoryGrid.Grid));
            foreach (LaboratoryExamination lExam in appointment.LaboratoryExamination)
            {
                if (lExam.Id == idx)
                {
                    return lExam;
                }
            }
            return null;

        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            if(appointment.Patient!=null)
                OpenForm(new DetailedPatientForm(appointment.Patient, false));
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //TODO update DB

            Return();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //TODO update DB

            Return();
        }

        private void returnButton2_Click(object sender, EventArgs e)
        {
            Return();
        }

        private void addExaminationButton_Click(object sender, EventArgs e)
        {
            OpenForm(new ExaminationForm(appointment));
            //TODO add examination to datagrid
        }

        private void examinationDetailsButton_Click(object sender, EventArgs e)
        {
            PhysicalExamination examination = GetSelectedPhysicalExamination();
            if (examination!=null)
                OpenForm(new ExaminationForm(examination));
        }

        private void addLaboratoryButton_Click(object sender, EventArgs e)
        {
            OpenForm(new DetailedLaboratoryForm(appointment));
            //TODO add examination to datagrid
        }

        private void laboratoryDetailsButton_Click(object sender, EventArgs e)
        {
            LaboratoryExamination laboratory = GetSelectedLaboratoryExamination();
            if(laboratory!=null)
                OpenForm(new DetailedLaboratoryForm(laboratory, false));
        }
    }
}
