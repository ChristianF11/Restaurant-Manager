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
    public partial class FrmReservation : Form
    {
        public FrmReservation()
        {
            InitializeComponent();
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            BsReservation bsReservation = new BsReservation();
            dgvReservation.DataSource = bsReservation.Read();
            dgvReservation.Columns[0].Visible= false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BsReservation bsReservation = new BsReservation();
            dgvReservation.DataSource = bsReservation.Read();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmManageReser frmManageReser = new FrmManageReser();
            frmManageReser.ShowDialog();
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
            if (CountRows() == 0)
                OperationMessage.GetIsEmpty();

            else
                UpdateElement();
        }

        private void DeleteElement()
        {
            int idSelected = 0;
            BsReservation bsReservation = new BsReservation();
            string message = "";

            idSelected = (int)dgvReservation.CurrentRow.Cells[0].Value;

            if (DialogResult.Yes == OperationMessage.GetGenericQuestion())
            {
                bsReservation.Delete(idSelected, ref message);
                OperationMessage.GetCustomMessage(message, "Eliminazione Prenotazione");
            }
        }
        private void UpdateElement()
        {
            int idSelected = (int)dgvReservation.CurrentRow.Cells[0].Value;
            FrmManageReser frmManageReser = new FrmManageReser(idSelected);

            frmManageReser.ShowDialog();
        }
        private int CountRows()
        {
            return dgvReservation.Rows.Count;
        }
    }
}
