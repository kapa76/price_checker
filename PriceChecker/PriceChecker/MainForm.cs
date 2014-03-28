using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PriceChecker.Common;

namespace PriceChecker
{
    public partial class MainForm : Form
    {

        public ListWords LocalWords; 

        public MainForm()
        {
            InitializeComponent();

            listWords.ContextMenuStrip = listWordsMenu;
            listSynonim.ContextMenuStrip = listSynonimMenu;
            supplierList.ContextMenuStrip = listSupplierMenu;

            LocalWords = new ListWords();
            //LocalWords.Load("words.xml");

            if (listWords.Items.Count > 0)
                listWords.SelectedIndex = 0;



        }
        
        private void BtnAddSupplierClick(object sender, EventArgs e)
        {
            var supplier = new Supplier();
            if( supplier.ShowDialog() == DialogResult.OK )
            {
                
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
            if (listWords.Items.Count > 0 && listWords.SelectedIndex != -1 )
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
            LocalWords.Save();
            Application.Exit();
        }

        private void ListWordsSelectedIndexChanged(object sender, EventArgs e)
        {
            if (listWords.SelectedIndex != -1)
            {
                var dest = (string) listWords.Items[listWords.SelectedIndex];
                Words w = LocalWords.GetListSynonim(dest);
                listSynonim.Items.Clear();
                for (int i = 0; i < w.GetSynonim().Count; i++)
                {
                    listSynonim.Items.Add(w.GetSynonimById(i));
                }
            }
        }

    }
}
