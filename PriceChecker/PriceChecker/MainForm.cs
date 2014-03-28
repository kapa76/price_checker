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

            if( ListSupplier.Count > 0 )
            {
                LoadItems(supplierList, ListSupplier);
            }

            if (listWords.Items.Count > 0)
                listWords.SelectedIndex = 0;

        }

        private static void LoadItems(ListBox listBox, List<SupplierType> listSupplier)
        {
            listBox.Items.Clear();
            for( int i=0; i<listSupplier.Count; i++)
            {
                listBox.Items.Add(listSupplier[i].Name);
            }
        }

        private void BtnAddSupplierClick(object sender, EventArgs e)
        {
            var supplier = new Supplier();
            if (supplier.ShowDialog() == DialogResult.OK)
            {
                ListSupplier.Add(supplier.Supp);
            }
        }

        private void AddSupplierClick(object sender, EventArgs e)
        {
            var supplier = new Supplier();
            if (supplier.ShowDialog() == DialogResult.OK)
            {

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

            DrawList( LocalWords._words );
        }

        private void DrawList(List<Words> w)
        {
            listSynonim.Items.Clear();
            listWords.Items.Clear();

            for( int i=0; i<w.Count; i++)
            {
                listWords.Items.Add(w[i]._words);
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            supplierList.Items.Clear();
            comboBoxSupplier.Items.Clear();

            for( int i=0; i< ListSupplier.Count; i++ )
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
            if(supplierList.SelectedIndex != -1)
            {
                for (int i = 0; i < ListSupplier.Count; i++)
                {
                    if (ListSupplier[i].Name.Contains((string) supplierList.Items[supplierList.SelectedIndex]))
                    {
                        ListSupplier.RemoveAt(i);
                    }
                }
                supplierList.Items.Remove(supplierList.SelectedItem);
            }
        }

        private void RemoveSupplierFromListClick(object sender, EventArgs e)
        {
            if( searchGrid.SelectedRows.Count > 0)
                searchGrid.Rows.Remove(searchGrid.SelectedRows[0]);
        }

        private void BtnChangeFileClick(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            if( openFile.ShowDialog() == DialogResult.OK)
            {
                fileNameChange.Text = openFile.FileName;
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

#endregion forms

        #region search

        private void SearchClick(object sender, EventArgs e)
        {
            var lf = new List<SupplierFiles>();
            if(searchString.Text.Length > 0 )
            {
                for( int i=0; i< searchGrid.Rows.Count; i++)
                {
                    var s = new SupplierFiles();
                    s.NameSupplier = searchGrid.Rows[i].Cells[0].Value.ToString();
                    s.NamePriceFile = searchGrid.Rows[i].Cells[1].Value.ToString();
                    lf.Add(s);
                }

                Search(searchString.Text, LocalWords._words, ListSupplier, lf);
            }
        }

        private static void Search(string searchString, List<Words> words, List<SupplierType> listSupplier, List<SupplierFiles> lf)
        {
            
            foreach(SupplierFiles supplierFiles in lf)
            {
                var nameSupplier = supplierFiles.NameSupplier;
                var priceFileName = supplierFiles.NamePriceFile;

                var supplierType = GetSupplierByName(listSupplier, nameSupplier);

                string[] listOfWords = GetListWords(words, searchString.Split(','));


                SearchByFile(listOfWords, supplierType, priceFileName);

            }




        }

        private static void SearchByFile(string[] listOfWords, SupplierType supplierType, string priceFileName)
        {
            




        }

        private static string[] GetListWords(List<Words> words, string[] searchWords)
        {
            bool finded = false;
            var wp = new List<string>();
            for (int i = 0; i < searchWords.Length; i++)
            {
                //берем слово и ищем его в списке слов, если находим забираем все синонимы
                for (int j = 0; j < words.Count; j++)
                {
                    if (words[j]._words.Contains(searchWords[i]))
                    {
                        //забираем все синонимы
                        for(int k=0; k<words[j]._synonim.Count;k++)
                        {
                            wp.Add(words[j]._synonim[k]);
                            finded = true;
                        }
                    }
                }

                if( !finded )
                    wp.Add(searchWords[i]);

            }

            return wp.ToArray();
        }

        private static SupplierType GetSupplierByName(List<SupplierType> listSupplier, string nameSupplier)
        {
            var value = new SupplierType();
            foreach(SupplierType st in listSupplier )
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
    }
}
