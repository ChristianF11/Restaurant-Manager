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
            ExecuteLoadProcedures();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckFilterFields();

            BsReservation bsReservation = new BsReservation();
            dgvReservation.DataSource = bsReservation.Read(txtName.Text, txtCity.Text,cmbOrder.Text,cbxFutureReser.Checked);
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

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowList();
        }

        private void cbxFutureReser_CheckedChanged(object sender, EventArgs e)
        {
            ShowList();
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
                CheckFilterFields();
                dgvReservation.DataSource = bsReservation.Read(txtName.Text,txtCity.Text,cmbOrder.Text,cbxFutureReser.Checked);
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
        private void CheckFilterFields()
        {
            if (txtName.Text == null)
                txtName.Text = "";

            if (txtCity.Text == null)
                txtCity.Text = "";
        }
        private void ExecuteLoadProcedures()
        {
            BsReservation bsReservation = new BsReservation();
            dgvReservation.DataSource = bsReservation.Read("", "", "ID", false);
            dgvReservation.Columns[0].Visible = false;
            cmbOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrder.SelectedIndex = 0;
        }
        private void ShowList()
        {
            BsReservation bsReservation = new BsReservation();
            CheckFilterFields();
            dgvReservation.DataSource = bsReservation.Read(txtName.Text, txtCity.Text, cmbOrder.Text, cbxFutureReser.Checked);
        }

    }
}
