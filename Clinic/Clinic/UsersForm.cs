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
    public partial class UsersForm : BaseForm
    {
        private GridWrapper usersCustomGrid;
        private GridScheme usersGridScheme;

        public UsersForm()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            usersGridScheme = new GridScheme();
            usersGridScheme.AddColumn("fName", "First Name").AddColumn("lName", "Last Name");
            usersGridScheme.AddColumn("fromDT", "Account Validity From").AddColumn("toDT", "Account Validity To").AddColumn("login", "Login").AddColumn("position", "Position");
            usersGridScheme.AddColumn("id", "Employee ID", true);
            usersCustomGrid = new GridWrapper(usersDataGrid, usersGridScheme);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Employee> employees = Common.GetEmployeeByRoleAndStatus(roleComboBox.SelectedItem.ToString(), statusComboBox.SelectedIndex);
            FillGrid(employees);
        }

        private void FillGrid(List<Employee> employees)
        {
            List<Tuple<List<string>, bool>> scheme = new List<Tuple<List<string>, bool>>();
            foreach (Employee item in employees)
            {
                List<string> row = new List<string>();
                row.Add(item.Person.First_Name);
                row.Add(item.Person.Last_Name);
                row.Add(item.dt_AccountValidityFrom.ToString());
                row.Add(item.dt_AccountValidityTo.ToString());
                row.Add(item.Login);
                row.Add(item.Position);
                row.Add(item.Id.ToString());
                scheme.Add(new Tuple<List<string>, bool>(row, true));
            }
            usersCustomGrid.SetRows(scheme);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Employee user = GetUserFromGrid();

            if(user != null)
                OpenForm(new DetailedUserForm(user, true));
        }

        private Employee GetUserFromGrid()
        {
            int id;
            int cellsNo = usersCustomGrid.Grid.GetCellCount(DataGridViewElementStates.Selected);
            if (cellsNo == 0)
            {
                MessageBox.Show("Proszę wybrać użytkownika!");
                return null;
            }

            try
            {
                var cells = usersCustomGrid.Grid.SelectedCells;
                var row = cells[0].OwningRow;
                var IDcell = row.Cells[row.Cells.Count - 1];
                id = int.Parse(IDcell.Value.ToString());
                foreach (DataGridViewCell cell in cells)
                {
                    if (cell.OwningRow != row)
                    {
                        MessageBox.Show("Proszę wybrać tylko jednego użytkownika!");
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
            return Common.GetEmployeeById(id);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            OpenForm(new DetailedUserForm());
        }
    }
}
