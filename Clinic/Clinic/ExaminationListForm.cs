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
        List<LaboratoryExamination> laboratoryExaminationList = new List<LaboratoryExamination>();
        List<PhysicalExamination> physicalExaminationList = new List<PhysicalExamination>();
        private GridWrapper examinationsCustomGrid;
        private GridScheme examinationGridScheme;
        bool ifPhysical;

        public ExaminationListForm(ref PhysicalExamination examination)
        {
            InitializeComponent();
            this.physicalExamination = examination;
            ifPhysical = true;
        }

        public ExaminationListForm(ref LaboratoryExamination examination)
        {
            InitializeComponent();
            this.laboratoryExamination = examination;
            ifPhysical = false;
        }

        private void InitializeGrids()
        {
            examinationGridScheme = new GridScheme();
            examinationGridScheme.AddColumn("exCode", "Examination Code").AddColumn("name", "Name").AddColumn("type", "Type");
            examinationGridScheme.AddColumn("id", "Examination ID", true);
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

        private void assignLaboratoryExamination(LaboratoryExamination newExamination)
        {
            if (newExamination == null)
                return;

            laboratoryExamination.ExaminationCode = newExamination.ExaminationCode;
            laboratoryExamination.Examinations.Name = newExamination.Examinations.Name;
            laboratoryExamination.Examinations.Type = newExamination.Examinations.Type;
            laboratoryExamination.Id = newExamination.Id;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int number = 0;

            if (codeTextBox.Text == string.Empty && nameTextBox.Text != string.Empty)
            {
                int.TryParse(codeTextBox.Text, out number);

                if (ifPhysical)
                {
                    physicalExaminationList.Add(Common.GetPhysicalExaminationByName(nameTextBox.Text));
                }
                else
                {
                    laboratoryExaminationList.Add(Common.GetLaboratoryExaminationByName(nameTextBox.Text));
                }

            }
            else if (codeTextBox.Text != string.Empty && nameTextBox.Text == string.Empty)
            {
                if (ifPhysical)
                {
                    physicalExaminationList.Add(Common.GetPhysicalExaminationByCode(number));
                }
                else
                {
                    laboratoryExaminationList.Add(Common.GetLaboratoryExaminationByCode(number));
                }
            }
            else if (codeTextBox.Text != string.Empty && nameTextBox.Text != string.Empty)
            {
                int.TryParse(codeTextBox.Text, out number);

                if (ifPhysical)
                {
                    physicalExaminationList.Add(Common.GetPhysicalExaminationByCodeAndName(number, nameTextBox.Text));
                }
                else
                {
                    laboratoryExaminationList.Add(Common.GetLaboratoryExaminationByCodeAndName(number, nameTextBox.Text));
                }
            }
            else
                return;
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

        private void selectButton_Click(object sender, EventArgs e)
        {
            string name = "";
            string code = "";
            if (ifPhysical)
            {
                PhysicalExamination ex = GetPhysicalExaminationFromGrid();
                assignPhysicalExamination(ex);

                name = ex.Examinations.Name;
                code = ex.ExaminationCode;
            }
            else
            {
                LaboratoryExamination ex = GetLaboratoryExaminationFromGrid();
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
