using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PriceChecker
{
    public partial class AddWords : Form
    {

        public String GetWords()
        {
            return word.Text;
        }

        public AddWords()
        {
            InitializeComponent();

            word.Focus();
        }
    }
}
