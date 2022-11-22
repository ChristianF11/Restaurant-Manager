using Business_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager
{
    public partial class FrmManageCust : Form
    {
        private string username;
        private bool edit;

        public FrmManageCust()
        {
            InitializeComponent();
        }

        public FrmManageCust(string username)
        {
            InitializeComponent();
            this.username = username;
            edit = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BsCustomer bsCustomer = new BsCustomer();
            bsCustomer.ClearFields(ref txtUsername, ref txtPassword, ref txtCity, ref txtPhoneNum, ref txtEmail, ref rtxtInfo, ref cbxIsAdmin);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BsCustomer bsCustomer = new BsCustomer();
            string message = "";
            string title = "";

            var entity = bsCustomer.CreateEntity(txtUsername.Text, txtPassword.Text, cbxIsAdmin.Checked, rtxtInfo.Text, txtPhoneNum.Text, txtEmail.Text, txtCity.Text);

            if (!bsCustomer.IsValid(entity, ref message, ref title,edit))
            {
                OperationMessage.GetCustomError(message, title);
            }

            else
            {
                if(edit)
                {
                    bsCustomer.Update(entity);
                }

                else
                {
                    bsCustomer.Create(entity);

                }
                
                OperationMessage.GetGenericMessage();
                bsCustomer.ClearFields(ref txtUsername, ref txtPassword, ref txtCity, ref txtPhoneNum, ref txtEmail, ref rtxtInfo, ref cbxIsAdmin);
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar)
                txtPassword.UseSystemPasswordChar = false;

            else
                txtPassword.UseSystemPasswordChar = true;
        }

        private void FrmManageCust_Load(object sender, EventArgs e)
        {
            if(edit)
            {
                txtUsername.ReadOnly = true;
                txtUsername.Text = username;
            }
        }
    }
}
