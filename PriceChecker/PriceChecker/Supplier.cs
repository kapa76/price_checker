using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using PriceChecker.Common;

namespace PriceChecker
{
    public partial class Supplier : Form
    {
        public Fields localFields;

        public SupplierType Supp;

        public Supplier()
        {
            InitializeComponent();
            localFields = new Fields();
            Supp = new SupplierType();
        }

        private static Fields LoadFields()
        {
            var readedFields = new Fields();
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<FieldType>));
            var file = new FileStream("fieldtype.xml", FileMode.Open);
            readedFields.Types = (List<FieldType>)reader.Deserialize(file);
            file.Close();
            return readedFields;
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            SaveFields();
        }

        private void SaveFields()
        {
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<FieldType>));
            var file = new FileStream("fieldtype.xml", FileMode.Create);
            reader.Serialize(file, localFields.Types);
            file.Close();
        }

        private void BtnNewTypeClick(object sender, EventArgs e)
        {
            if (newTypeField.Text.Length > 0 && !typeFieldList.Items.Contains(newTypeField.Text))
            {
                typeFieldList.Items.Add(newTypeField.Text);
                typeFieldList.SelectedIndex = 0;

                var v = new FieldType();
                v.FieldName = newTypeField.Text;
                localFields.Types.Add(v);
                newTypeField.Text = "";
            }

            if (typeFieldList.Items.Contains(newTypeField.Text))
            {
                MessageBox.Show(@"Такое наименование поля уже есть.");
                newTypeField.Text = "";
            }
        }

        private void Supplier_Shown(object sender, EventArgs e)
        {
            localFields = LoadFields();
            typeFieldList.Items.Clear();
            for (int i = 0; i < localFields.Types.Count; i++)
            {
                typeFieldList.Items.Add(localFields.Types[i].FieldName);
            }

            if (typeFieldList.Items.Count > 0)
                typeFieldList.SelectedIndex = 0;
        }

        private void BtnAddColumnClick(object sender, EventArgs e)
        {
            if (typeFieldList.SelectedIndex != -1 )
            {
                var cell = new Cell();
                cell.Name = (string) typeFieldList.Items[typeFieldList.SelectedIndex];
                cell.Row = Convert.ToInt32(row.Text);
                cell.Col = Convert.ToInt32(col.Text);

                Supp.ListCell.Add(cell);
                var val = new DataGridViewRow();


                val.CreateCells(grid, "cell1", "cell2", "cell3");
                val.Cells[0].Value = cell.Row.ToString();
                val.Cells[1].Value = cell.Col.ToString();
                val.Cells[2].Value = cell.Name.ToString();

                grid.Rows.Add(val);


            }

        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            Supp.Name = suppName.Text;
            SaveFields();
        }

        private void DelCell_Click(object sender, EventArgs e)
        {
            if(grid.SelectedRows.Count>0)
            {
                grid.Rows.Remove(grid.SelectedRows[0]);
            }
        }


    }
}
