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
            dgvRestaurant.Columns[0].Visible = false;

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
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (CountRows() == 0)
                OperationMessage.GetIsEmpty();

            else
                DeleteElement();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(CountRows() == 0)
                OperationMessage.GetIsEmpty();

            else
                UpdateElement();
        }

        private void DeleteElement()
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            string message = "";
            int idSelected = (int)dgvRestaurant.CurrentRow.Cells[0].Value;

            if (DialogResult.Yes == OperationMessage.GetGenericQuestion())
            {
                bsRestaurant.Delete(idSelected, ref message);
                OperationMessage.GetCustomWarning(message, "Eliminazione Ristorante");
            }
        }
        private void UpdateElement()
        {
            int idSelected = (int)dgvRestaurant.CurrentRow.Cells[0].Value;
            FrmManageRest editForm = new FrmManageRest(idSelected);

            editForm.ShowDialog();
        }
        private int CountRows()
        {
            return dgvRestaurant.Rows.Count;
        }
    }
}
