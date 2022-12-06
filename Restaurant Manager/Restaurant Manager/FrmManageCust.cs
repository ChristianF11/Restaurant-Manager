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
        private Customer entity;
        private string username;
        private bool edit;

        public FrmManageCust()
        {
            InitializeComponent();
            edit = false;
        }

        public FrmManageCust(string username, Customer entity)
        {
            InitializeComponent();
            this.username = username;
            this.entity = entity;
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
            SaveElement();
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
            ExecuteLoadProcedures();
        }

        private void SaveElement()
        {
            BsCustomer bsCustomer = new BsCustomer();
            string message = "";
            string title = "";

            var entity = bsCustomer.CreateEntity(txtUsername.Text, txtPassword.Text, cbxIsAdmin.Checked, rtxtInfo.Text, txtPhoneNum.Text, txtEmail.Text, txtCity.Text);

            if (!bsCustomer.IsValid(entity, ref message, ref title, edit))
            {
                OperationMessage.GetCustomError(message, title);
            }

            else
            {
                if (edit)
                {
                    bsCustomer.Update(entity, ref message);
                    OperationMessage.GetCustomMessage(message, "Modifica cliente");
                }

                else
                {
                    bsCustomer.Create(entity, ref message);
                    bsCustomer.ClearFields(ref txtPassword, ref txtCity, ref txtPhoneNum, ref txtEmail, ref rtxtInfo, ref cbxIsAdmin);
                    txtUsername.Text = "";
                    OperationMessage.GetCustomMessage(message, "Nuovo cliente");
                }
            }
        }
        private void ExecuteLoadProcedures()
        {
            if (edit) //In fase di editing l'username si potrà visualizzare ma non cambiare
            {
                txtUsername.ReadOnly = true;
                txtUsername.Text = username;
                txtPassword.Text = entity.Password;
                txtPhoneNum.Text = entity.PhoneNum;
                txtEmail.Text = entity.Email;
                txtCity.Text = entity.City;
                rtxtInfo.Text = entity.Info;
                cbxIsAdmin.Checked = entity.IsAdmin;
            }
        }
    }
}
