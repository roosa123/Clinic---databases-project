using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public class GridScheme
    {
        private List<Tuple<string, string, bool>> _Columns;

        public GridScheme ()
        {
            _Columns = new List<Tuple<string, string, bool>>();
        }
        public GridScheme(List<Tuple<string, string, bool>> columns)
        {
            _Columns = columns;
        }
        public List<Tuple<string, string, bool>> Columns
        {
            get
            {
                return _Columns;
            }
            set
            {
                _Columns = value;
            }
        }
        public GridScheme AddColumn(string name, string header, bool hidden=false)
        {
            _Columns.Add(new Tuple<string, string, bool>(name, header, hidden));
            return this;
        }
    }

    public class GridWrapper : DataGridView
    {
        private DataGridView _Grid;
        private GridScheme _gridScheme;
        public GridWrapper(DataGridView grid, GridScheme scheme)
        {
            _Grid = grid;
            _gridScheme = scheme;
            InitializeColumns();
            _Grid.AutoGenerateColumns = false;
            _Grid.RowHeadersVisible = false;
            _Grid.AllowUserToAddRows = false;
            FitToWindow();
        }
        private void InitializeColumns()
        {
            foreach(var column in _gridScheme.Columns)
            {
                _Grid.Columns.Add(column.Item1, column.Item2);
                _Grid.Columns[_Grid.Columns.Count - 1].Visible = !(column.Item3);
            }
        }
        private void FitToWindow()
        {
            int GridWidth = _Grid.Width;
            ScrollBar verticalScroll = VerticalScrollBar;
            int scrollWidth = verticalScroll.Width;
            int ColumnsWidth = _Grid.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            int diff = GridWidth -ColumnsWidth;
            if (diff <=4)
                return;
            if (diff > scrollWidth)
                diff += scrollWidth;
            double margin = diff / _Grid.ColumnCount;
            foreach(DataGridViewColumn column in _Grid.Columns)
            {
                column.Width += (int)margin;
                diff -= (int)margin;
            }
            _Grid.Columns.GetFirstColumn(DataGridViewElementStates.Visible).Width += (diff-1);
        }
        public GridWrapper AddRow(List<string>row, bool readOnly=true)
        {
            DataGridViewRow gridRow = new DataGridViewRow();
            gridRow.CreateCells(_Grid, row.ToArray());
            return AddRow(gridRow, readOnly);
        }
        public GridWrapper AddRow(DataGridViewRow row, bool readOnly=true)
        {
            row.ReadOnly = readOnly;
            _Grid.Rows.Add(row);
            return this;
        }
        public GridWrapper SetRows(List<Tuple<List<string>,bool>> rows)
        {
            _Grid.Rows.Clear();
            foreach(var row in rows)
            {
                AddRow(row.Item1, row.Item2);
            }
            FitToWindow();
            return this;
        }
        public System.Windows.Forms.DataGridView Grid
        {
            get
            {
                return _Grid;
            }
            set
            {
                _Grid = value;
            }
        }
        public GridScheme GridScheme
        {
            get
            {
                return _gridScheme;
            }
            set
            {
                _gridScheme = value;
            }
        }
    }
}
