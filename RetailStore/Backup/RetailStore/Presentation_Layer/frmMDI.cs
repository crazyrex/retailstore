using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void vendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaddvendors av = new frmaddvendors();
            av.MdiParent = this;
            av.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaddproducts ap = new frmaddproducts();
            ap.MdiParent = this;
            ap.Show();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaddcustomers ac = new frmaddcustomers();
            ac.MdiParent = this;
            ac.Show();
        }
    }
}