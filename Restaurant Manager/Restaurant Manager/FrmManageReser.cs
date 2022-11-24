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
    public partial class FrmManageReser : Form
    {
        private int idSelected;
        private bool edit;
        public FrmManageReser()
        {
            InitializeComponent();
        }

        public FrmManageReser(int idSelected)
        {
            InitializeComponent();
            this.idSelected = idSelected;
            edit = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BsReservation bsReservation = new BsReservation();
            bsReservation.ClearFields(ref txtUsername, ref valueCustomers, ref dtpReservation);
        }

        private void FrmManageReser_Load(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant = new BsRestaurant();

            dgvRestaurants.DataSource = bsRestaurant.ReadName();
            dgvRestaurants.Columns[0].Visible = false; //Viene nascosta la colonna degli ID
            txtRestaurant.Text = dgvRestaurants.SelectedRows[0].Cells[1].Value.ToString(); //L'etichetta con il nome del ristorante selezioanto partirà di default con il primo elemento

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveElement();
        }

        private void dgvRestaurants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRestaurant.Text = dgvRestaurants.SelectedRows[0].Cells[1].Value.ToString();
            ShowEmptySeats();
        }


        private void SaveElement()
        {
            BsReservation bsReservation = new BsReservation();
            DateTime requestDate = DateTime.Now;
            DateTime reservationDate = dtpReservation.Value;
            string title = "";
            string message = "";
            decimal price = 0;
            Reservation entity;

            if(dgvRestaurants.CurrentCell != null)
            {
                price = bsReservation.GetPrice((int)valueCustomers.Value, (int)dgvRestaurants.CurrentRow.Cells[0].Value);
                entity = bsReservation.CreateEntity((int)dgvRestaurants.CurrentRow.Cells[0].Value, txtUsername.Text, requestDate, reservationDate, (int)valueCustomers.Value, price);
            }

            else
            {
                price = bsReservation.GetPrice((int)valueCustomers.Value, (int)dgvRestaurants.SelectedRows[0].Cells[0].Value);
                entity = bsReservation.CreateEntity((int)dgvRestaurants.SelectedRows[0].Cells[0].Value, txtUsername.Text, requestDate, reservationDate, (int)valueCustomers.Value,price);
            }

            if (!bsReservation.IsValid(entity, ref message, ref title))
            {
                OperationMessage.GetCustomError(message, title);
            }

            else
            {
                if (edit)
                {
                    bsReservation.Update(entity, idSelected);
                }
                else
                {
                    bsReservation.Create(entity);
                }

                OperationMessage.GetGenericMessage();
                bsReservation.ClearFields(ref txtUsername, ref valueCustomers, ref dtpReservation);

            }
        }

        private void dtpReservation_ValueChanged(object sender, EventArgs e)
        {
            //Metodo che conta i posti liberi in un determinato ristorante in un determinato giorno
            if (CountRows() == 0)
                OperationMessage.GetCustomError("Nessun ristorante presente in lista", "Operazione non riuscita");
            else
            {
                ShowEmptySeats();
            }
        }

        private int CountRows()
        {
            return dgvRestaurants.Rows.Count;
        }

        private void ShowEmptySeats()
        {
            DateTime date = dtpReservation.Value;
            BsReservation bsReservation = new BsReservation();
            int idSelected = 0;

            //Caso in cui esiste una lista di ristoranti
            if(dgvRestaurants.CurrentCell!= null)
            {
                idSelected = (int)dgvRestaurants.CurrentRow.Cells[0].Value;
            }
            //Caso in cui viene selezionata prima la data (rispetto al ristorante), di default verrà inserito il primo ristorante
            else
            {
                idSelected = (int)dgvRestaurants.SelectedRows[0].Cells[0].Value;
            }

            txtSeats.Text = bsReservation.GetEmptySeats(idSelected, date).ToString();
        }

        private void lblReservDate_Click(object sender, EventArgs e)
        {

        }
    }
}
