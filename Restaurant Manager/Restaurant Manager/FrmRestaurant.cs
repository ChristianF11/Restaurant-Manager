using Business_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager
{
    public partial class FrmRestaurant : Form
    {
        public FrmRestaurant()
        {
            InitializeComponent();
        }

        private void FrmRestaurant_Load(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant= new BsRestaurant();
            dgvRestaurant.DataSource = bsRestaurant.Read();

            dgvRestaurant.ReadOnly = true;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmManageRest createForm = new FrmManageRest();
            createForm.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant = new BsRestaurant();

            dgvRestaurant.DataSource = bsRestaurant.Read();
            OperationMessage.GetCustomMessage("Lista aggiornata", "Aggiornamento lista");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            string message = "";
            int idSelected = (int)dgvRestaurant.CurrentRow.Cells[0].Value;

            if(DialogResult.Yes == OperationMessage.GetGenericQuestion())
            {
                bsRestaurant.Delete(idSelected, ref message);
                OperationMessage.GetCustomWarning(message, "Eliminazione Ristorante");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idSelected = (int)dgvRestaurant.CurrentRow.Cells[0].Value;
            FrmManageRest editForm = new FrmManageRest(idSelected);

            editForm.ShowDialog();
        }

    }
}
