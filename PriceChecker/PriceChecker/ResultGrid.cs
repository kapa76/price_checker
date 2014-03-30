using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PriceChecker.search;

namespace PriceChecker
{
    public partial class ResultGrid : Form
    {
        public List<ResultRowCell> DataResult;

        public ResultGrid()
        {
            InitializeComponent();
            DataResult = new List<ResultRowCell>();
        }

        private void ResultGrid_Shown(object sender, EventArgs e)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            var p = new List<object>();

            var val1 = new DataGridViewRow();

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = @"Поставщик";
            grid.Columns.Add(col);

            var createCells = DataResult[0].getCells();

            foreach (ResultCell c in createCells)
            {
                DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
                col1.HeaderText = c.CellName;
                grid.Columns.Add(col1);
            }


            foreach (ResultRowCell row in DataResult)
            {
                var lCells = row.getCells();
                var val = new DataGridViewRow();

                var p1 = new DataGridViewTextBoxCell();
                val.Cells.Add(p1);

                val.Cells[0].Value = row.VSupplierName;
                int index = 1;
                foreach (ResultCell cell in lCells)
                {
                    var local = new DataGridViewTextBoxCell();

                    val.Cells.Add(local);
                    val.Cells[index++].Value = cell.Value;
                }
                grid.Rows.Add(val);
            }
        }
    }
}
