using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using PriceChecker.Common;
using PriceChecker.search;

namespace PriceChecker
{
    public partial class MainForm : Form
    {

        public ListWords LocalWords;

        public List<SupplierType> ListSupplier;

        #region forms

        public MainForm()
        {
            InitializeComponent();

            listWords.ContextMenuStrip = listWordsMenu;
            listSynonim.ContextMenuStrip = listSynonimMenu;
            supplierList.ContextMenuStrip = listSupplierMenu;

            LocalWords = new ListWords();
            ListSupplier = new List<SupplierType>();

            LoadData();
            LoadSupplier();

            if (ListSupplier.Count > 0)
            {
                LoadItems(supplierList, ListSupplier);
            }

            if (listWords.Items.Count > 0)
                listWords.SelectedIndex = 0;

        }

        private static void LoadItems(ListBox listBox, List<SupplierType> listSupplier)
        {
            listBox.Items.Clear();
            for (int i = 0; i < listSupplier.Count; i++)
            {
                listBox.Items.Add(listSupplier[i].Name);
            }
        }

        private void BtnAddSupplierClick(object sender, EventArgs e)
        {
            var supplier = new Supplier();
            supplier.vSupplierEditMode = SupplierEditMode.Add;

            if (supplier.ShowDialog() == DialogResult.OK)
            {
                ListSupplier.Add(supplier.Supp);
                supplierList.Items.Clear();
                for(int i=0; i<ListSupplier.Count; i++)
                {
                    supplierList.Items.Add(ListSupplier[i].Name);
                }

            }

            if (supplierList.Items.Count > 0 && supplierList.SelectedIndex == -1)
                supplierList.SelectedIndex = 0;

        }

        private void AddSupplierClick(object sender, EventArgs e)
        {
            var supplier = new Supplier();
            supplier.vSupplierEditMode = SupplierEditMode.Add;

            if (supplier.ShowDialog() == DialogResult.OK)
            {
                ListSupplier.Add(supplier.Supp);

                supplierList.Items.Clear();
                for (int i = 0; i < ListSupplier.Count; i++)
                {
                    supplierList.Items.Add(ListSupplier[i].Name);
                }
            }

            if (supplierList.Items.Count > 0 && supplierList.SelectedIndex == -1)
                supplierList.SelectedIndex = 0;

        }

        private void DeleteWordsClick(object sender, EventArgs e)
        {
            if (listWords.SelectedIndex != -1)
            {
                LocalWords.Remove((string)listWords.Items[listWords.SelectedIndex]);
                listWords.Items.Remove(listWords.SelectedItem);
            }
        }

        private void AddWordsClick(object sender, EventArgs e)
        {
            var words = new AddWords();
            if (words.ShowDialog() == DialogResult.OK)
            {
                if (!LocalWords.IsExist(words.GetWords()))
                {
                    LocalWords.AddWord(words.GetWords());
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
                LocalWords.RemoveSynonim((string)listWords.Items[listWords.SelectedIndex], (string)listSynonim.Items[listSynonim.SelectedIndex]);
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
                        LocalWords.AddSynonym((string)listWords.Items[listWords.SelectedIndex], synonim.GetSynonim());
                    }
                }
            }

            if (listSynonim.Items.Count > 0 && listSynonim.SelectedIndex == -1)
                listSynonim.SelectedIndex = 0;
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            Save();
            SaveSupplier();
            Application.Exit();
        }

        private void ListWordsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (listWords.SelectedIndex != -1)
            {
                string dest = (string)listWords.Items[listWords.SelectedIndex];
                Words w = LocalWords.GetListSynonim(dest);
                listSynonim.Items.Clear();
                for (int i = 0; i < w._synonim.Count; i++)
                {
                    listSynonim.Items.Add(w._synonim[i]);
                }
            }
        }

        public void Save()
        {
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Words>));
            var file = new FileStream("words.xml", FileMode.Create);
            reader.Serialize(file, LocalWords._words);
            file.Close();
        }

        public void LoadData()
        {
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<Words>));
            var file = new System.IO.StreamReader("words.xml");
            LocalWords._words = (List<Words>)reader.Deserialize(file);
            file.Close();

            DrawList(LocalWords._words);
        }

        private void DrawList(List<Words> w)
        {
            listSynonim.Items.Clear();
            listWords.Items.Clear();

            for (int i = 0; i < w.Count; i++)
            {
                listWords.Items.Add(w[i]._words);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            supplierList.Items.Clear();
            comboBoxSupplier.Items.Clear();

            for (int i = 0; i < ListSupplier.Count; i++)
            {
                supplierList.Items.Add(ListSupplier[i].Name);
                comboBoxSupplier.Items.Add(ListSupplier[i].Name);
            }

            if (supplierList.Items.Count > 0)
                supplierList.SelectedIndex = 0;

            if (comboBoxSupplier.Items.Count > 0)
                comboBoxSupplier.SelectedIndex = 0;

        }

        private void DeleteSupplierClick(object sender, EventArgs e)
        {
            if (supplierList.SelectedIndex != -1)
            {
                for (int i = 0; i < ListSupplier.Count; i++)
                {
                    if (ListSupplier[i].Name.Contains((string)supplierList.Items[supplierList.SelectedIndex]))
                    {
                        ListSupplier.RemoveAt(i);
                    }
                }
                supplierList.Items.Remove(supplierList.SelectedItem);
            }
        }


        private void BtnChangeFileClick(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileNameChange.Text = openFile.FileName;
            }
        }



        #endregion forms

        #region search

        private void SearchClick(object sender, EventArgs e)
        {
            var value = new List<ResultRowCell>();
            var lf = new List<SupplierFiles>();
            if (searchString.Text.Length > 0)
            {
                for (int i = 0; i < searchGrid.Rows.Count; i++)
                {
                    var s = new SupplierFiles();
                    s.NameSupplier = searchGrid.Rows[i].Cells[0].Value.ToString();
                    s.NamePriceFile = searchGrid.Rows[i].Cells[1].Value.ToString();
                    lf.Add(s);
                }

                value = Search(searchString.Text, LocalWords._words, ListSupplier, lf);
            }
            else
            {
                MessageBox.Show(@"Необходимо указать слова для поиска.");
            }

            if (value.Count > 0)
            {
                var result = new ResultGrid {DataResult = value};
                result.Show();
            }

            

        }

        private static List<ResultRowCell> Search(string searchString, List<Words> words, List<SupplierType> listSupplier, List<SupplierFiles> lf)
        {
            var searcher = new Search();
            var p = new List<ResultRowCell>();
            foreach (SupplierFiles supplierFiles in lf)
            {
                var nameSupplier = supplierFiles.NameSupplier;
                var priceFileName = supplierFiles.NamePriceFile;

                var supplierType = GetSupplierByName(listSupplier, nameSupplier);

                string[] listOfWords = GetListWords(words, searchString.Split(','), supplierType);

                //del words when with "-"


                p = searcher.SearchByFile(listOfWords, supplierType, priceFileName);

            }

            return p;


        }



        private static string[] GetListWords(List<Words> words, string[] searchWords, SupplierType type)
        {
            bool finded = false;
            var wp = new List<string>();
            int i;
            for (i = 0; i < searchWords.Length; i++)
            {
                finded = false;
                //берем слово и ищем его в списке слов, если находим забираем все синонимы
                for (int j = 0; j < words.Count; j++)
                {
                    if (words[j]._words.Contains(searchWords[i]))
                    {
                        //забираем все синонимы
                        for (int k = 0; k < words[j]._synonim.Count; k++)
                        {
                            wp.Add(words[j]._synonim[k]);
                            finded = true;
                        }
                    }
                }

                if (!finded)
                    wp.Add(searchWords[i]);

            }

            //добавить/удалить все слова для конкретного поставщика
            //для каждого слова из поисковой строки
            for (i = 0; i < searchWords.Length; i++)
            {
                for (int j = 0; j < type.ListWords._words.Count; j++)
                {
                    //по всем словам поставщика
                    if (type.ListWords._words[j]._words.Contains(searchWords[i]))
                    {
                        //в списке слов поставщика, найдено слово из поисковой строки
                        for (int k = 0; k < type.ListWords._words[j]._synonim.Count; k++)
                        {
                            //для всех синонимов для этого слова из поставщика
                            //если синоним с - убираем его из списка, иначе добавляем
                            //добавляем все слова синонимы, если оно с минусом то убираем из общего списка.
                            var value = type.ListWords._words[j]._synonim[k];

                            if (isAdd(value) && !wp.Contains(value))
                                wp.Add(Normalize(value));

                            if (isRemove(value))
                                wp.Remove(Normalize(value));

                        }
                    }
                }
            }

            return wp.ToArray();
        }

        private static string Normalize(string value)
        {
            value = value.Replace("-", "");
            value = value.Replace("+", "");
            value = value.Replace(".", "");
            value = value.Replace(",", "");
            value = value.Replace("*", "");
            value = value.Replace(";", "");
            return value;
        }

        private static bool isRemove(string value)
        {
            return value.StartsWith("-");
        }

        private static bool isAdd(string value)
        {
            return value.StartsWith("+");
        }


        private static SupplierType GetSupplierByName(List<SupplierType> listSupplier, string nameSupplier)
        {
            var value = new SupplierType();
            foreach (SupplierType st in listSupplier)
            {
                if (st.Name.Contains(nameSupplier))
                {
                    value = st;
                    break;
                }
            }
            return value;
        }

        #endregion search

        #region supplier

        private void SupplierListDoubleClick(object sender, EventArgs e)
        {
            var supplier = new Supplier();
            
            supplier.vSupplierEditMode = SupplierEditMode.Edit;
            var supplierName = (string)supplierList.Items[supplierList.SelectedIndex];
            var vSupplier = GetSupplierByName(ListSupplier, supplierName);
            supplier.Supp = vSupplier;
            if (supplier.ShowDialog() == DialogResult.OK)
            {
                ListSupplier.Remove(vSupplier);
                ListSupplier.Add(supplier.Supp);
                
                supplierList.Items.Clear();
                for(int i=0;i<ListSupplier.Count;i++)
                {
                    supplierList.Items.Add(ListSupplier[i].Name);
                }
                if (supplierList.Items.Count > 0)
                    supplierList.SelectedIndex = 0;

            }
        }

        private void AddSupplierToSearchGrid(object sender, EventArgs e)
        {
            var val = new DataGridViewRow();

            val.CreateCells(searchGrid, "cell1", "cell2");
            val.Cells[0].Value = comboBoxSupplier.Items[comboBoxSupplier.SelectedIndex];
            val.Cells[1].Value = fileNameChange.Text; ;
            searchGrid.Rows.Add(val);
        }

        private void RemoveSupplierFromListClick(object sender, EventArgs e)
        {
            if (searchGrid.SelectedRows.Count > 0)
                searchGrid.Rows.Remove(searchGrid.SelectedRows[0]);
        }

        private void LoadSupplier()
        {
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<SupplierType>));
            var file = new FileStream("supplier.xml", FileMode.Open);
            ListSupplier = (List<SupplierType>)reader.Deserialize(file);
            file.Close();
        }

        private void SaveSupplier()
        {
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(List<SupplierType>));
            var file = new FileStream("supplier.xml", FileMode.Create);
            reader.Serialize(file, ListSupplier);
            file.Close();
        }

        #endregion supplier

    }
}
