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
    public partial class LaboratoryForm : BaseForm
    {
        private GridWrapper examinationCustomGrid;
        private GridScheme examinationGridScheme;

        public LaboratoryForm()
        {
            InitializeComponent();
            if (Program.CurrentUser.Position == "LaboratoryPerson")
                statusComboBox.SelectedItem = "Zlecone";
            else
                statusComboBox.SelectedItem = "Wykonane";

            InitializeGrid();
        }

        private void InitializeGrid()
        {
            examinationGridScheme = new GridScheme();
            examinationGridScheme.AddColumn("exCode", "Kod badania").AddColumn("name", "Nazwa").AddColumn("lab", "Laborant").AddColumn("reqDT", "Data zgłoszenia").AddColumn("complDT", "Data wykonania").AddColumn("confDT", "Data zatwierdzenia").AddColumn("res", "Wynik").AddColumn("status", "Status");
            examinationGridScheme.AddColumn("id", "ID badania", true);
            examinationCustomGrid = new GridWrapper(examinationsDataGrid, examinationGridScheme);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string status = statusComboBox.SelectedItem.ToString();
            List<LaboratoryExamination> examinationsList;

            if (!fromDateTimePicker.Checked)
                examinationsList = Common.GetLaboratoryExaminationByStatus(status);
            else
                examinationsList = Common.GetLaboratoryExaminationByDateAndStatus(fromDateTimePicker.Value, status);

            FillExaminationGrid(examinationsList);
        }

        private void FillExaminationGrid(List<LaboratoryExamination> examinationsList)
        {
            List<Tuple<List<string>, bool>> scheme = new List<Tuple<List<string>, bool>>();
            foreach (LaboratoryExamination ex in examinationsList)
            {
                List<string> row = new List<string>();
                row.Add(ex.ExaminationCode);
                row.Add(ex.Examinations.Name);
                row.Add(ex.LaboratoryPerson.Employee.Person.First_Name + " " + ex.LaboratoryPerson.Employee.Person.Last_Name);
                row.Add(ex.dt_Request.ToString());
                row.Add(ex.dt_Complete_Cancel.ToString());
                row.Add(ex.dt_Confirmation.ToString());
                row.Add(ex.Result);
                row.Add(ex.Status);
                row.Add(ex.Id.ToString());
                scheme.Add(new Tuple<List<string>, bool>(row, true));
            }
            examinationCustomGrid.SetRows(scheme);
        }

        private LaboratoryExamination GetLaboratoryExaminationFromGrid()
        {
            int id;
            int cellsNo = examinationCustomGrid.Grid.GetCellCount(DataGridViewElementStates.Selected);
            if (cellsNo == 0)
            {
                MessageBox.Show("Proszę wybrać badanie!");
                return null;
            }

            try
            {
                var cells = examinationCustomGrid.Grid.SelectedCells;
                var row = cells[0].OwningRow;
                var IDcell = row.Cells[row.Cells.Count - 1];
                id = int.Parse(IDcell.Value.ToString());
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
            return Common.GetLaboratoryExaminationById(id);
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            LaboratoryExamination examination = GetLaboratoryExaminationFromGrid();

            if (examination != null)
                OpenForm(new DetailedLaboratoryForm(examination, true));
            else
                MessageBox.Show("Nierozpoznane ID badania.");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            LaboratoryExamination examination = GetLaboratoryExaminationFromGrid();

            if(examination != null)
                OpenForm(new DetailedLaboratoryForm(examination, false));
        }
    }
}
