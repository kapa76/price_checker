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

        public Supplier()
        {
            InitializeComponent();
            localFields = new Fields();
        }

        private static Fields LoadFields()
        {
            var readedFields = new Fields();
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(Fields));
            var file = new FileStream("fieldtype.xml", FileMode.Open);
            reader.Serialize(file, readedFields);
            file.Close();
            return readedFields;        
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            SaveFields();
        }

        private void SaveFields()
        {
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(Fields));
            var file = new FileStream("fieldtype.xml", FileMode.Create);
            reader.Serialize(file, localFields);
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

            if(typeFieldList.Items.Contains(newTypeField.Text))
            {
                MessageBox.Show(@"Такое наименование поля уже есть.");
                newTypeField.Text = "";
            }
        }

        private void Supplier_Shown(object sender, EventArgs e)
        {
            localFields = LoadFields();
            typeFieldList.Items.Clear();
            for(int i=0;i<localFields.Types.Count; i++)
            {
                typeFieldList.Items.Add(localFields.Types[i]);
            }
        }
    }
}
