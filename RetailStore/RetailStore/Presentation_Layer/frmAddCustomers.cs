using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RetailStore.Presentation_Layer
{
    public partial class frmAddCustomers : Form
    {
        DAL d = new DAL();
        public frmAddCustomers()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddCustomers_Load(object sender, EventArgs e)
        {
           txtCustId.Text = d.autoGenerateID("Entity", "ID","Customer");
           d.loadTableIntoGrid("Entity", "Role", "Customer", dgvCustomers);
           txtCustId.TextChanged += new EventHandler(txtCustId_TextChanged);
           txtCustName.TextChanged += new EventHandler(txtCustName_TextChanged);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //txtCustId.Text = d.autoGenerateID("Entity", "ID", "Customer");
            d.addEntityInfo(txtCustId.Text, txtCustName.Text, txtPhone.Text, txtEmail.Text, "Customer");
            d.addEntityAddress(txtCustId.Text, txtAddress1.Text, txtAddress2.Text, txtAddress3.Text, txtCity.Text, txtPin.Text, txtState.Text, txtCountry.Text);
            clearTxt();
            MessageBox.Show("Customer Added");
        }

        void txtCustId_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = d.findRecordsLike("Entity", "Role", "Customer", "ID", txtCustId.Text);
        }


        void txtCustName_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.DataSource = d.findRecordsLike("Entity", "Role", "Customer", "Name", txtCustName.Text);
        }
        private void clearTxt()
        {
            txtCustId.Text= "";
            txtCustName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress1.Text = "";
            txtAddress2.Text = "";
            txtAddress3.Text = "";
            txtCity.Text = "";
            txtPin.Text = "";
            txtState.Text = "";
            txtCountry.Text = "";
          
        }

    }
}