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
        
        public SupplierEditMode vSupplierEditMode { get; set;}

        public SupplierType Supp;

        public Supplier()
        {
            InitializeComponent();
            localFields = new Fields();
            Supp = new SupplierType();

            listWords.ContextMenuStrip = listWordsMenu;
            listSynonim.ContextMenuStrip = listSynonimMenu;
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
            suppName.Text = Supp.Name;

            for (int i = 0; i < Supp.ListCell.Count; i++)
            {
                AddRow(Supp.ListCell[i]);
            }

            localFields = LoadFields();
            typeFieldList.Items.Clear();
            for (int i = 0; i < localFields.Types.Count; i++)
            {
                typeFieldList.Items.Add(localFields.Types[i].FieldName);
            }

            if (typeFieldList.Items.Count > 0)
                typeFieldList.SelectedIndex = 0;

            listWords.Items.Clear();
            for (int i = 0; i < Supp.ListWords._words.Count; i++)
            {
                listWords.Items.Add(Supp.ListWords._words[i]._words);
            }
            if (listWords.Items.Count > 0)
                listWords.SelectedIndex = 0;

        }

        private void AddRow(Cell cell)
        {
            var val = new DataGridViewRow();

            val.CreateCells(grid, "cell1", "cell2", "cell3");
            val.Cells[0].Value = cell.Row.ToString();
            val.Cells[1].Value = cell.Col.ToString();
            val.Cells[2].Value = cell.Name;

            grid.Rows.Add(val);
        }

        private void BtnAddColumnClick(object sender, EventArgs e)
        {
            if (typeFieldList.SelectedIndex != -1)
            {
                var cell = new Cell();
                cell.Name = (string)typeFieldList.Items[typeFieldList.SelectedIndex];
                cell.Row = Convert.ToInt32(row.Text);
                cell.Col = Convert.ToInt32(col.Text);

                Supp.ListCell.Add(cell);
                AddRow(cell);

            }

        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            Supp.Name = suppName.Text;
            SaveFields();
        }

        private void DelCell_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 0)
            {
                grid.Rows.Remove(grid.SelectedRows[0]);
            }
        }

        private void ListWordsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (listWords.SelectedIndex != -1)
            {
                var currentWord = (string) listWords.Items[listWords.SelectedIndex];
                listSynonim.Items.Clear();

                for (int i = 0; i < Supp.ListWords._words.Count; i++)
                {
                    if (Supp.ListWords._words[i]._words.Contains(currentWord))
                    {
                        for (int j = 0; j < Supp.ListWords._words[i]._synonim.Count; j++)
                        {
                            listSynonim.Items.Add(Supp.ListWords._words[i]._synonim[j]);
                        }

                        if (Supp.ListWords._words[i]._synonim.Count > 0)
                            listSynonim.SelectedIndex = 0;
                    }
                }
            }
        }


        #region words

        private void DeleteWordsClick(object sender, EventArgs e)
        {
            if (listWords.SelectedIndex != -1)
            {
                Supp.ListWords.Remove((string)listWords.Items[listWords.SelectedIndex]);
                listWords.Items.Remove(listWords.SelectedItem);
            }
        }

        private void AddWordsClick(object sender, EventArgs e)
        {
            var words = new AddWords();
            if (words.ShowDialog() == DialogResult.OK)
            {
                if (!Supp.ListWords.IsExist(words.GetWords()))
                {
                    Supp.ListWords.AddWord(words.GetWords());
                    listWords.Items.Add(words.GetWords());
                }
            }

            if (listWords.Items.Count > 0 && listWords.SelectedIndex == -1)
                listWords.SelectedIndex = 0;
        }


        private void DeleteSynonimClick(object sender, EventArgs e)
        {
            if (listSynonim.SelectedIndex != -1)
            {
                Supp.ListWords.RemoveSynonim((string)listWords.Items[listWords.SelectedIndex], (string)listSynonim.Items[listSynonim.SelectedIndex]);
                listSynonim.Items.Remove(listSynonim.SelectedItem);
            }
        }

        private void AddSynonimClick(object sender, EventArgs e)
        {
            if (listWords.Items.Count > 0 && listWords.SelectedIndex != -1)
            {
                var synonim = new AddSynonim();
                if (synonim.ShowDialog() == DialogResult.OK)
                {
                    if (!listSynonim.Items.Contains(synonim.GetSynonim()))
                    {
                        listSynonim.Items.Add(synonim.GetSynonim());
                        Supp.ListWords.AddSynonym((string)listWords.Items[listWords.SelectedIndex], synonim.GetSynonim());
                    }
                }
            }

            if (listSynonim.Items.Count > 0 && listSynonim.SelectedIndex == -1)
                listSynonim.SelectedIndex = 0;
        }

        #endregion words

    }
}
