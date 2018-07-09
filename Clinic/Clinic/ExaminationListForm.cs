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
    public partial class ExaminationListForm : BaseForm
    {
        LaboratoryExamination laboratoryExamination;
        PhysicalExamination physicalExamination;
        private List<Examinations> examinationsList = new List<Examinations>();
        private GridWrapper examinationsCustomGrid;
        private GridScheme examinationGridScheme;
        bool ifPhysical;

        public ExaminationListForm(ref PhysicalExamination examination)
        {
            InitializeComponent();
            this.physicalExamination = examination;
            this.physicalExamination.Examinations = new Examinations();
            ifPhysical = true;
            InitializeGrids();
        }

        public ExaminationListForm(ref LaboratoryExamination examination)
        {
            InitializeComponent();
            this.laboratoryExamination = examination;
            this.laboratoryExamination.Examinations = new Examinations();
            ifPhysical = false;
            InitializeGrids();
        }


        private void InitializeGrids()
        {
            examinationGridScheme = new GridScheme();
            examinationGridScheme.AddColumn("exCode", "Kod badania").AddColumn("name", "Nazwa").AddColumn("type", "Typ");
            examinationsCustomGrid = new GridWrapper(dataGridView1, examinationGridScheme);
        }

        private void assignPhysicalExamination(PhysicalExamination newExamination)
        {
            if (newExamination == null)
                return;

            physicalExamination.ExaminationCode = newExamination.ExaminationCode;
            physicalExamination.Examinations.Name = newExamination.Examinations.Name;
            physicalExamination.Examinations.Type = newExamination.Examinations.Type;
            physicalExamination.Id = newExamination.Id;
        }

        private void FillGrid()
        {
            List<Tuple<List<string>, bool>> scheme = new List<Tuple<List<string>, bool>>();
            foreach (Examinations ex in examinationsList)
            {
                List<string> row = new List<string>();
                row.Add(ex.Code);
                row.Add(ex.Name);
                row.Add(ex.Type);
                scheme.Add(new Tuple<List<string>, bool>(row, true));
            }
            examinationsCustomGrid.SetRows(scheme);
        }

        private void assignLaboratoryExamination(LaboratoryExamination newExamination)
        {
            if (newExamination == null)
                return;

            laboratoryExamination.ExaminationCode = newExamination.ExaminationCode;
            laboratoryExamination.Examinations.Name = newExamination.Examinations.Name;
            laboratoryExamination.Examinations.Type = newExamination.Examinations.Type;
            laboratoryExamination.Id = newExamination.Id;
        }
        private Examinations handleError(Examinations querryResult)
        {
            if (querryResult == null)
                MessageBox.Show("Nie znaleziono badania", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return querryResult;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int number = 0;
            int.TryParse(codeTextBox.Text, out number);
            Examinations exam = null;
            if (codeTextBox.Text == string.Empty && nameTextBox.Text != string.Empty)
            {
                
                if (ifPhysical)
                    exam = handleError(Common.GetOnlyPhysicalExaminationByName(nameTextBox.Text));
                else
                    exam = handleError( Common.GetOnlyLaboratoryExaminationByName(nameTextBox.Text));                

            }
            else if (codeTextBox.Text != string.Empty && nameTextBox.Text == string.Empty)
            {
                if (ifPhysical)
                    exam = handleError(Common.GetOnlyPhysicalExaminationByCode(number));
                else
                    exam = handleError(Common.GetOnlyLaboratoryExaminationByCode(number));
            }
            else if (codeTextBox.Text != string.Empty && nameTextBox.Text != string.Empty)
            {
                if (ifPhysical)
                    exam = handleError( Common.GetOnlyPhysicalExaminationByCodeAndName(number, nameTextBox.Text));
                else
                    exam = handleError(Common.GetOnlyLaboratoryExaminationByCodeAndName(number, nameTextBox.Text));
            }
            if (exam!= null)
                examinationsList.Add(exam);
            FillGrid();
        }

        private PhysicalExamination GetPhysicalExaminationFromGrid()
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
            return Common.GetLaboratoryExaminationByCode(code);
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            string name = "";
            string code = "";
            if (ifPhysical)
            {
                PhysicalExamination ex = GetPhysicalExaminationFromGrid();

                if (ex == null)
                    return;

                assignPhysicalExamination(ex);

                name = ex.Examinations.Name;
                code = ex.ExaminationCode;
            }
            else
            {
                LaboratoryExamination ex = GetLaboratoryExaminationFromGrid();

                if (ex == null)
                    return;

                assignLaboratoryExamination(ex);

                name = ex.Examinations.Name;
                code = ex.ExaminationCode;
            }

            codeTextBox.Text = code;
            nameTextBox.Text = name;
            
            Return();
        }


        private void returnButton_Click(object sender, EventArgs e)
        {
            Return();
        }
    }
}
