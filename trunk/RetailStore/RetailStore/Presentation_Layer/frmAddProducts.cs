using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmAddProducts : Form
    {
        private DAL d = new DAL();
        REVAL r = new REVAL();
        Boolean b;
        public frmAddProducts()
        {
             
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            validateInput();
            if (b)
            {
                MessageBox.Show("Please enter all fields with proper values");
            }
            else
            {
                d.addProductDetails(txtProdId.Text, txtProdName.Text, txtDesc.Text, txtProdAttribute.Text);
                d.addProductPricelist(txtProdId.Text, txtPurcPrice.Text, txtSellPrice.Text, dtpUpdated.Value);
                d.addProductStock(txtProdId.Text, cmbWarehouseId.Text, txtProdQty.Text, txtReorderLevel.Text, txtReorderQty.Text, txtStatus.Text);
                ClearTxt();
                MessageBox.Show("Product added");
            }
        }

        private void frmAddProducts_Load(object sender, EventArgs e)
        {
            txtProdId.Text = d.autoGenerateID("Product_Details", "Product_ID", "Product");
            d.loadTablesJoinIntoGrid("Product_Details", "Product_Pricelist", "Product_ID", "Product_ID", dgvProduct);
            dgvProduct.Columns["Product_Pricelist.Product_ID"].Visible = false;
            cmbWarehouseId.DataSource = d.executeSelectStmt("select WH_ID from WH_Details");
            cmbWarehouseId.DisplayMember = "WH_ID";
        }

        private void txtProdName_TextChanged(object sender, EventArgs e)
        {
            dgvProduct.DataSource = d.findRecordsLike("Product_Details", "Name", txtProdName.Text);
        }
        public void ClearTxt()
        {
            txtProdId.Text = "";
            txtProdName.Text = "";
            txtProdQty.Text = "";
            txtPurcPrice.Text = "";
            txtReorderLevel.Text = "";
            txtReorderQty.Text = "";
            txtSellPrice.Text = "";
            txtStatus.Text = "";
            txtDesc.Text = "";
            txtProdAttribute.Text = "";
            cmbWarehouseId.Text = "";
            dtpUpdated.Text = "";
        }
        public Boolean validateInput()
        {
            b = false;
            if (r.emptyCheck(txtProdId.Text) && r.emptyCheck(txtProdName.Text) && r.emptyCheck(txtProdAttribute.Text) && r.emptyCheck(txtDesc.Text)&&r.emptyCheck(cmbWarehouseId.Text) && r.emptyCheck(txtProdQty.Text)&& r.emptyCheck(txtReorderLevel.Text)&& r.emptyCheck(txtReorderQty.Text)&&r.emptyCheck(txtStatus.Text)&&r.emptyCheck(txtPurcPrice.Text)&&r.emptyCheck(txtSellPrice.Text)&& r.emptyCheck(dtpUpdated.Text))
            {
                b = true;
            }
            if (r.numCheck(txtProdId.Text)&& r.numCheck(txtProdQty.Text)&&r.numCheck(txtReorderLevel.Text)&&r.numCheck(txtReorderQty.Text)&&r.numCheck(txtPurcPrice.Text)&&r.numCheck(txtSellPrice.Text)&&r.numCheck(cmbWarehouseId.Text))
            {
                b = true;
            }
            if (r.charCheck(txtProdName.Text)&&r.charCheck(txtDesc.Text)&&r.charCheck(txtProdAttribute.Text)&&r.charCheck(txtStatus.Text))
            {
                b = true;
            }
            return b;
        }
    }
}