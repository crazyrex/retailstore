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
           // string prodID = dgvPOItems[dgvPOItems.SelectedCells[0].ColumnIndex, dgvPOItems.SelectedCells[0].RowIndex].Value.ToString();
            //string description = d.executeSelectStmt("SELECT Product_Description FROM Product_Details Where Product_ID='" + prodID + "'").Rows[0][0].ToString();
            //description = dt.Rows[0][0].ToString();
            //dgvPOItems[dgvPOItems.SelectedCells[0].ColumnIndex+1, dgvPOItems.SelectedCells[0].RowIndex].Value = "Hello";

        }

        private void frmNewPur_Order_Load(object sender, EventArgs e)
        {
            txtPurchaseId.Text = d.autoGenerateID("POrders_Details", "PO_ID", "PO");
            cmbVenName.DataSource = d.populateCombo("Entity", "Name", "Role", "Vendor");
            cmbVenName.DisplayMember = "Name";
            ProductID.DataSource = d.populateCombo("Product_Details", "Product_ID");
            ProductID.DisplayMember = "Product_ID";
            dgvPOItems.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(dgvPOItems_EditingControlShowing);

        }

       
    }
}
