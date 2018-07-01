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
        private const int INTERNAL_ERROR_FLAG = -1;
        private const int MULTIPLE_SELECTION_FLAG = -2;
 
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
            ExaminationGridInfo = new List<Tuple<string, string>>();
            ExaminationGridInfo.Add(new Tuple<string, string>("code", "Code"));
            ExaminationGridInfo.Add(new Tuple<string, string>("name", "Name"));
            ExaminationGridInfo.Add(new Tuple<string, string>("result", "Result"));
            ExaminationGridInfo.Add(new Tuple<string, string>("id", "ID"));
            foreach (Tuple<string, string> desc in ExaminationGridInfo)
            {
                examinationsDataGrid.Columns.Add(desc.Item1, desc.Item2);
            }
            examinationsDataGrid.AutoGenerateColumns = false;
            examinationsDataGrid.RowHeadersVisible = false;
            int columnsCount = examinationsDataGrid.ColumnCount;
            examinationsDataGrid.Columns[columnsCount - 1].Visible = false;
        }

        private void InitializeLaboratyGrid()
        {
            LaboratoryGridInfo = new List<Tuple<string, string>>();
            LaboratoryGridInfo.Add(new Tuple<string, string>("code", "Code"));
            LaboratoryGridInfo.Add(new Tuple<string, string>("name", "Name"));
            LaboratoryGridInfo.Add(new Tuple<string, string>("result", "Result"));
            LaboratoryGridInfo.Add(new Tuple<string, string>("status", "Status"));
            LaboratoryGridInfo.Add(new Tuple<string, string>("note", "Supervisor note"));
            LaboratoryGridInfo.Add(new Tuple<string, string>("id", "ID"));
            foreach (Tuple<string, string> desc in LaboratoryGridInfo)
            {
                laboratoryDataGrid.Columns.Add(desc.Item1, desc.Item2);
            }
            laboratoryDataGrid.AutoGenerateColumns = false;
            laboratoryDataGrid.RowHeadersVisible = false;
            int columnsCount = laboratoryDataGrid.ColumnCount;
            laboratoryDataGrid.Columns[columnsCount - 1].Visible = false;
        }

        private void FillGrids()
        {
            FillExaminationGrid();
            FillLaboratoryGrid();
        }
        
        private void FillLaboratoryGrid()
        {
            laboratoryDataGrid.Rows.Clear();
            foreach(LaboratoryExamination lExam in appointment.LaboratoryExamination)
            {
                DataGridViewRow gridRow = new DataGridViewRow();
                List<string> row = new List<string>();
                row.Add(lExam.ExaminationCode);
                row.Add(lExam.Examinations.Name);
                row.Add(lExam.Result);
                row.Add(lExam.Status);
                row.Add(lExam.Supervisor_Note);
                row.Add(lExam.Id.ToString());
                gridRow.CreateCells(laboratoryDataGrid, row.ToArray());
                gridRow.ReadOnly = true;
                laboratoryDataGrid.Rows.Add(gridRow);
            }
            laboratoryDataGrid.AutoResizeColumns();
            laboratoryDataGrid.AutoResizeRows();
        }

        private void FillExaminationGrid()
        {
            examinationsDataGrid.Rows.Clear();
            foreach( PhysicalExamination pExam in appointment.PhysicalExamination)
            {
                DataGridViewRow gridRow = new DataGridViewRow();
                List<string> row = new List<string>();
                row.Add(pExam.ExaminationCode);
                row.Add(pExam.Examinations.Name);
                row.Add(pExam.Result);
                row.Add(pExam.Id.ToString());
                gridRow.CreateCells(examinationsDataGrid, row.ToArray());
                gridRow.ReadOnly = true;
                examinationsDataGrid.Rows.Add(gridRow);
            }
            examinationsDataGrid.AutoResizeColumns();
            examinationsDataGrid.AutoResizeRows();
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
            catch(NullReferenceException) { return INTERNAL_ERROR_FLAG; }
            return id;
        }
        private PhysicalExamination GetSelectedPhysicalExamination()
        {
            int idx = HandleErrorFlag(GetSelectedIndex(examinationsDataGrid));
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
            int idx = HandleErrorFlag(GetSelectedIndex(laboratoryDataGrid));
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
