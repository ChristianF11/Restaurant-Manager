using Business_layer;
using Entities;
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
            bsCustomer.ClearFields(ref txtPassword, ref txtCity, ref txtPhoneNum, ref txtEmail, ref rtxtInfo, ref cbxIsAdmin);
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
                    bsCustomer.ClearFields(ref txtPassword, ref txtCity, ref txtPhoneNum, ref txtEmail, ref rtxtInfo, ref cbxIsAdmin);
                }

                else
                {
                    bsCustomer.Create(entity);
                    bsCustomer.ClearFields(ref txtPassword, ref txtCity, ref txtPhoneNum, ref txtEmail, ref rtxtInfo, ref cbxIsAdmin);
                    txtUsername.Text = "";
                }
                
                OperationMessage.GetGenericMessage();
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
                txtPassword.PasswordChar = '*';

            else
                txtPassword.PasswordChar = '\0';
        }

        private void FrmManageCust_Load(object sender, EventArgs e)
        {
            if(edit) //In fase di editing l'username si potrà visualizzare ma non cambiare
            {
                txtUsername.ReadOnly = true;
                txtUsername.Text = username;
            }
        }
    }
}
