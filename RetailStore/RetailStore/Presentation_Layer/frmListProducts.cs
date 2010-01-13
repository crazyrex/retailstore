using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmListProducts : Form
    {
        DAL d = new DAL();
        public frmListProducts()
        {
            InitializeComponent();
        }

        private void txtProdId_TextChanged(object sender, EventArgs e)
        {
            dgvSearchProducts.DataSource = d.findRecordsLike("Product_Details", "Product_ID", txtProdId.Text);
        }

        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            dgvSearchProducts.DataSource = d.findRecordsLike("Product_Details", "Name", txtProdName.Text);
        }

        private void frmListProducts_Load(object sender, EventArgs e)
        {
            d.loadTableIntoGrid("Product_Details", dgvSearchProducts);
            txtProdId.TextChanged += new EventHandler(txtProdId_TextChanged);
            txtProdName.TextChanged += new EventHandler(txtProdName_TextChanged);
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
