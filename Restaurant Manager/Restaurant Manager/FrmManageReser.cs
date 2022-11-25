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
            bsReservation.ClearFields(ref txtUsername, ref valueCustomers);

        }

        private void FrmManageReser_Load(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant = new BsRestaurant();

            dgvRestaurants.DataSource = bsRestaurant.ReadName();
            dgvRestaurants.Columns[0].Visible = false; //Viene nascosta la colonna degli ID
            txtRestaurant.Text = dgvRestaurants.SelectedRows[0].Cells[1].Value.ToString(); //L'etichetta con il nome del ristorante selezioanto partirà di default con il primo elemento
            txtSeats.Text = GetEmptySeats(); //Vengono mostrati i posti disponibili
            txtPrice.Text = GetPrice().ToString() + "€";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveElement();
        }

        private void dgvRestaurants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRestaurant.Text = dgvRestaurants.SelectedRows[0].Cells[1].Value.ToString();
            txtSeats.Text = GetEmptySeats();
            txtPrice.Text = GetPrice().ToString() + "€";
        }


        private void SaveElement()
        {
            BsReservation bsReservation = new BsReservation();
            DateTime requestDate = DateTime.Now;
            DateTime reservationDate = GetSelectedDate();
            string title = "";
            string message = "";
            int price = 0;
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

            if (!bsReservation.IsValid(entity, ref message, ref title, edit, idSelected))
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
                bsReservation.ClearFields(ref txtUsername, ref valueCustomers);

            }
        }

        private int CountRows()
        {
            return dgvRestaurants.Rows.Count;
        }

        private string GetEmptySeats()
        {

            BsReservation bsReservation = new BsReservation();
            int restaurantSelected = 0;
            DateTime date = GetSelectedDate();

            //Caso in cui esiste una lista di ristoranti
            if(dgvRestaurants.CurrentCell!= null)
            {
                restaurantSelected = (int)dgvRestaurants.CurrentRow.Cells[0].Value;
            }
            //Caso in cui viene selezionata prima la data (rispetto al ristorante), di default verrà inserito il primo ristorante
            else
            {
                restaurantSelected = (int)dgvRestaurants.SelectedRows[0].Cells[0].Value;
            }

            if(!edit) //In caso di modifica verranno apparentemente "ripristinati" a prima di quella ordinazione
                return bsReservation.GetEmptySeats(restaurantSelected, date).ToString();

            return bsReservation.GetRestoredSeats(restaurantSelected, date, idSelected).ToString();
        }

        private DateTime GetSelectedDate() //Restituisce la data selezionata sul calendario
        {
            string selectedDate = monthCalendar.SelectionStart.ToShortDateString();
            DateTime date = Convert.ToDateTime(selectedDate);

            return date;
        }

        private int GetPrice()
        {
            BsReservation bsReservation = new BsReservation();
            int avgPrice = 0, idSelected = (int)dgvRestaurants.SelectedRows[0].Cells[0].Value;

            if(dgvRestaurants.CurrentCell!= null) 
                idSelected = (int)dgvRestaurants.CurrentRow.Cells[0].Value;
            
            avgPrice = bsReservation.GetPrice((int)valueCustomers.Value, idSelected);
            
            return avgPrice;
        }

        private void dtpReservation_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Metodo che conta i posti liberi in un determinato ristorante in un determinato giorno
            if (CountRows() == 0)
                OperationMessage.GetCustomError("Nessun ristorante presente in lista", "Operazione non riuscita");
            else
            {
                txtSeats.Text = GetEmptySeats();
                txtPrice.Text = GetPrice().ToString() + "€";
            }
        }

        private void valueCustomers_ValueChanged(object sender, EventArgs e)
        {
            txtPrice.Text = GetPrice().ToString() + "€";
        }
    }
}
