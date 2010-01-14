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
        REVAL i = new REVAL();
        Boolean b;

        public frmAddCustomers()
        {
            InitializeComponent();
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
            validateInput();
            if (b)
            {
                MessageBox.Show("Please enter all fields with proper values");
            }
            else
            {
                d.addEntityInfo(txtCustId.Text, txtCustName.Text, txtPhone.Text, txtEmail.Text, "Customer");
                d.addEntityAddress(txtCustId.Text, txtAddress1.Text, txtAddress2.Text, txtAddress3.Text, txtCity.Text, txtPin.Text, txtState.Text, txtCountry.Text);
                clearTxt();
                MessageBox.Show("Customer Added");
            }
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

        public Boolean validateInput()
        {
            b=false;
            if (i.emptyCheck(txtCustId.Text))
            {
               b = true;
            }
            if (i.emptyCheck(txtCustName.Text))
            {
                b = true;
            }
            if(i.emptyCheck(txtAddress1.Text))
            {
                b = true;
            }
            if (i.emptyCheck(txtAddress2.Text))
            {
                b = true;
            }
            if (i.emptyCheck(txtAddress3.Text))
            {
                b = true;
            }
            if (i.emptyCheck(txtCity.Text))
            {
                b = true;
            }
            if (i.emptyCheck(txtCountry.Text))
            {                b = true;
            }
            if (i.emptyCheck(txtPin.Text))
            {
                b = true;
            }
            if (i.emptyCheck(txtState.Text))
            {
                b = true;
            }
            if (i.emptyCheck(txtPhone.Text))
            {
                b = true;
            }
            if (i.emptyCheck(txtEmail.Text))
            {
                b = true;
            }
            if (i.numCheck(txtPhone.Text))
            {
                b = true;
            }
            if (i.numCheck(txtPin.Text))
            {
                b = true;
            }
            if (i.charCheck(txtCustName.Text))
            {
                b = true;
            }
            if (i.charCheck(txtCity.Text))
            {
                b = true;
            }
            if (i.charCheck(txtState.Text))
            {
                b = true;
            }
            if (i.charCheck(txtCountry.Text))
            {
                b = true;
            }
            return b;
        }
   }
}