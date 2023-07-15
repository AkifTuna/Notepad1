using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAbout__Load(object sender, EventArgs e)
        {
            ProductName.Text = string.Format("Product name: {0}", Application.ProductName);
            ProductVersion.Text = string.Format("Version: {0}", Application.ProductVersion);
            Copyright.Text = "Copyright © 2023 by Acotec Company";
        }
    }
}
