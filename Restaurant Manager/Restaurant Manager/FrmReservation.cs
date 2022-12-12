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
    public partial class FrmReservation : Form
    {
        private int idRestSelected;
        private bool specificRestaurant;
        public FrmReservation()
        {
            InitializeComponent();
            specificRestaurant = false;
        }

        public FrmReservation(int idRestSelected)
        {
            InitializeComponent();
            this.idRestSelected = idRestSelected;
            specificRestaurant = true;
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            ExecuteLoadProcedures();
            cbxFutureReser.Checked = true;
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
                OperationMessage.ShowIsEmpty();

            else
                DeleteElement();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CountRows() == 0)
                OperationMessage.ShowIsEmpty();

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
            LogTable log = new LogTable();
            string message = "";

            idSelected = (int)dgvReservation.CurrentRow.Cells[0].Value;

            if (DialogResult.Yes == OperationMessage.GetGenericQuestion())
            {
                log = GetLogEntity();
                bsReservation.Delete(log,idSelected, ref message);
                OperationMessage.ShowCustomMessage(message, "Eliminazione Prenotazione");
                CheckFilterFields();
                dgvReservation.DataSource = bsReservation.Read(txtName.Text,txtCity.Text,cmbOrder.Text,cbxFutureReser.Checked);
            }
        }
        private void UpdateElement()
        {
            int idSelected = (int)dgvReservation.CurrentRow.Cells[0].Value;
            string restaurantName = dgvReservation.CurrentRow.Cells[1].Value.ToString();
            string username = dgvReservation.CurrentRow.Cells[2].Value.ToString();
            DateTime reservationDate = (DateTime)dgvReservation.CurrentRow.Cells[4].Value;
            int numCustomers = (int)dgvReservation.CurrentRow.Cells[5].Value;
            
            FrmManageReser frmManageReser = new FrmManageReser(idSelected,restaurantName,username,reservationDate,numCustomers);

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

            HideButtons(); //Se è stato scelto un determinato ristorante (dalla pagina "FrmRestaurant") vengono nascosti alcuni bottoni

            if (!specificRestaurant)
                dgvReservation.DataSource = bsReservation.Read("", "", "ID", false); //Caricamento della lista completa

            else
                dgvReservation.DataSource = bsReservation.Read(idRestSelected, "", "", "ID", false); //Caricamento delle prenotazioni di solo quel ristorante

            dgvReservation.Columns[0].Visible = false;

            foreach (DataGridViewColumn column in dgvReservation.Columns) //Viene negato il sort cliccando sulla header della colonna
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvReservation.Columns["Prezzo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvReservation.Columns["Posti Prenotati"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            cmbOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrder.SelectedIndex = 0;
        }
        private void ShowList()
        {
            BsReservation bsReservation = new BsReservation();
            CheckFilterFields();
            if (!specificRestaurant)
                dgvReservation.DataSource = bsReservation.Read(txtName.Text, txtCity.Text, cmbOrder.Text, cbxFutureReser.Checked);

            else
                dgvReservation.DataSource = bsReservation.Read(idRestSelected, txtName.Text, txtCity.Text, cmbOrder.Text, cbxFutureReser.Checked);
        }
        private void HideButtons()
        {
            if(specificRestaurant)
            {
                btnNew.Visible = false;
                btnDelete.Visible = false;
                btnEdit.Visible = false;
                btnUpdate.Visible = false;

                lblFilter.Visible = false;
                lblName.Visible = false;
                lblCity.Visible = false;

                txtName.Visible = false;
                txtCity.Visible = false;
            }
        }
        private LogTable GetLogEntity()
        {
            BsLogTable bsLog = new BsLogTable();
            BsReservation bsReservation = new BsReservation();

            int idReservation = (int)dgvReservation.CurrentRow.Cells[0].Value;
            int idRestaurant = bsReservation.GetRestaurantId(idReservation);
            string username = dgvReservation.CurrentRow.Cells[2].Value.ToString();

            return bsLog.CreateEntity(idReservation,idRestaurant,2,username,DateTime.Now);
             
        }

    }
}
