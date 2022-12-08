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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRestaurant_Click(object sender, EventArgs e)
        {
            FrmRestaurant restaurantForm = new FrmRestaurant();
            restaurantForm.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCustomer customerForm = new FrmCustomer();
            customerForm.ShowDialog();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            FrmReservation reservationForm = new FrmReservation();
            reservationForm.ShowDialog();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            FrmStats statsForm = new FrmStats();
            statsForm.ShowDialog();
        }
    }
}
