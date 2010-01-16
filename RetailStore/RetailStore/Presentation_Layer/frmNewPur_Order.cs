using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmNewPur_Order : Form
    {
        private DAL d = new DAL();
        int total;
        public frmNewPur_Order()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void dgvPOItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvPOItems.CurrentCell.ColumnIndex == 0)
            {
                ComboBox cb = e.Control as ComboBox;
                if (cb != null)
                {
                    cb.SelectedIndexChanged -= new EventHandler(cb_SelectedIndexChanged);
                    cb.SelectedIndexChanged += new EventHandler(cb_SelectedIndexChanged);
                }
            }
            if (dgvPOItems.CurrentCell.ColumnIndex == 2)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.TextChanged -= new EventHandler(tb_TextChanged);
                    tb.TextChanged += new EventHandler(tb_TextChanged);
                }

            }

        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            txtPurchaseId.Text = d.autoGenerateID( "POrders_Details", "PO_ID","PO");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmVendorSupplylist fvs = new frmVendorSupplylist(cmbVenName.Text);
            fvs.Show();
        }
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cbo = (ComboBox)sender;
                DataTable dt = new DataTable();
                dt = d.findRecords("Product_Details", "Description", "Product_ID", cbo.Text);
                string description = dt.Rows[0][0].ToString();
                dt = d.findRecords("Product_Pricelist", "Purchase_Price", "Product_ID", cbo.Text);
                string price = dt.Rows[0][0].ToString();
                dgvPOItems[dgvPOItems.SelectedCells[0].ColumnIndex + 1, dgvPOItems.SelectedCells[0].RowIndex].Value = description;
                dgvPOItems[dgvPOItems.SelectedCells[0].ColumnIndex + 3, dgvPOItems.SelectedCells[0].RowIndex].Value = price;
                dgvPOItems[dgvPOItems.SelectedCells[0].ColumnIndex + 4, dgvPOItems.SelectedCells[0].RowIndex].Value = price;
                txtTotal.Text = total.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void tb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                int qty = int.Parse(tb.Text);
                string prodPrice= (string)dgvPOItems[dgvPOItems.SelectedCells[0].ColumnIndex + 1, dgvPOItems.SelectedCells[0].RowIndex].Value;
                int price = int.Parse(prodPrice);
                dgvPOItems[dgvPOItems.SelectedCells[0].ColumnIndex + 2, dgvPOItems.SelectedCells[0].RowIndex].Value = qty * price;
                total = total + (qty * price);
                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmNewPur_Order_Load(object sender, EventArgs e)
        {
            txtPurchaseId.Text = d.autoGenerateID("POrders_Details", "PO_ID", "PO");
            cmbVenName.DataSource = d.findRecords("Entity", "Name", "Role", "Vendor");
            cmbVenName.DisplayMember = "Name";
            ProductID.DataSource = d.populateCombo("Product_Details", "Product_ID");
            ProductID.DisplayMember = "Product_ID";
            dgvPOItems.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvPOItems_EditingControlShowing);
        
        }

       
    }
}
