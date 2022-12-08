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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            ExecuteLoadProcedures();
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
                UpdateElement();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CountRows() == 0)
                OperationMessage.GetIsEmpty();

            else
                DeleteElement();
        }

        private void cbxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
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
        private void UpdateList()
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
        private void ExecuteLoadProcedures()
        {
            BsCustomer bsCustomer = new BsCustomer();
            dgvCustomer.DataSource = bsCustomer.Read("", "", "", false); //Caricamento della lista completa

            foreach (DataGridViewColumn column in dgvCustomer.Columns) //Viene negato il sort cliccando sulla header della colonna
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void UpdateElement()
        {
            BsCustomer bsCustomer = new BsCustomer();

            //Raccolta dei valori della riga
            string userSelected = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            string password = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            bool isAdmin = (bool)dgvCustomer.CurrentRow.Cells[2].Value;
            string info = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            string phoneNum = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            string email = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            string city = dgvCustomer.CurrentRow.Cells[6].Value.ToString();

            Customer existingCustomer = bsCustomer.CreateEntity(userSelected,password,isAdmin,info,phoneNum,email,city);
            FrmManageCust editCustomerFrm = new FrmManageCust(userSelected,existingCustomer);
            editCustomerFrm.ShowDialog();
        }
    }
}
