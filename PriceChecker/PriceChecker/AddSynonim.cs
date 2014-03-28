using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PriceChecker
{
    public partial class AddSynonim : Form
    {
        public AddSynonim()
        {
            InitializeComponent();
            synonim.Focus();
        }

        public String GetSynonim()
        {
            return synonim.Text;
        }
    }
}
