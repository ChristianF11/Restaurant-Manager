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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BsReservation bsReservation = new BsReservation();
            dgvReservation.DataSource = bsReservation.Read();
            OperationMessage.GetCustomMessage("Lista aggiornata", "Aggiornamento lista");
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
    }
}
