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
            dgvCustomer.DataSource = bsCustomer.Read();
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
            string userSelected = (string)dgvCustomer.CurrentRow.Cells[0].Value;
            FrmManageCust editCustomerFrm = new FrmManageCust(userSelected);
            editCustomerFrm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BsCustomer bsCustomer = new BsCustomer();
            dgvCustomer.DataSource = bsCustomer.Read();
            OperationMessage.GetCustomMessage("Lista aggiornata", "Aggiornamento lista");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BsCustomer bsCustomer = new BsCustomer();
            string message = "";
            string userSelected = "";

            if (dgvCustomer.CurrentRow.Cells[0].Value == null)
                userSelected = "";

            else 
                userSelected = (string)dgvCustomer.CurrentRow.Cells[0].Value;

            if (DialogResult.Yes == OperationMessage.GetGenericQuestion())
            {
                bsCustomer.Delete(userSelected, ref message);
                OperationMessage.GetCustomWarning(message, "Eliminazione Utente");
            }
        }
    }
}
