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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            BsCustomer bsCustomer = new BsCustomer();
            dgvCustomer.DataSource = bsCustomer.Read("","","",false);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmManageCust newCustomerFrm = new FrmManageCust();
            newCustomerFrm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CountRows() == 0)
                OperationMessage.GetIsEmpty();

            else
            {
                string userSelected = (string)dgvCustomer.CurrentRow.Cells[0].Value;
                FrmManageCust editCustomerFrm = new FrmManageCust(userSelected);
                editCustomerFrm.ShowDialog();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateElement();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CountRows() == 0)
                OperationMessage.GetIsEmpty();

            else
                DeleteElement();
        }

        private void DeleteElement()
        {
            BsCustomer bsCustomer = new BsCustomer();
            string message = "";
            string userSelected = "";

            userSelected = (string)dgvCustomer.CurrentRow.Cells[0].Value;

            if (DialogResult.Yes == OperationMessage.GetGenericQuestion())
            {
                bsCustomer.Delete(userSelected, ref message);
                OperationMessage.GetCustomWarning(message, "Eliminazione Utente");
                CheckFilterFields();
                dgvCustomer.DataSource = bsCustomer.Read(txtName.Text, txtCity.Text, txtMail.Text, cbxAdmin.Checked);

            }
        }
        private void UpdateElement()
        {
            CheckFilterFields();

            BsCustomer bsCustomer = new BsCustomer();
            dgvCustomer.DataSource = bsCustomer.Read(txtName.Text,txtCity.Text,txtMail.Text,cbxAdmin.Checked);
        }
        private int CountRows()
        {
            return dgvCustomer.Rows.Count;
        }
        private void CheckFilterFields()
        {
            if (txtName.Text == null)
                txtName.Text = "";

            if (txtCity.Text == null)
                txtCity.Text = "";

            if (txtMail.Text == null)
                txtMail.Text = "";
        }
    }
}
