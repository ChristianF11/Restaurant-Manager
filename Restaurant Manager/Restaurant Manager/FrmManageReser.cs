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
        private int idSelected,idReservation, numCustomers;
        private bool edit;
        private string restaurantName, username;
        private DateTime reservDate;

        public FrmManageReser()
        {
            InitializeComponent();
            edit = false;
        }

        public FrmManageReser(int idReservation, string restaurantName, string username, DateTime reservDate, int numCustomers)
        {
            InitializeComponent();
            this.idSelected = idReservation; //ID della prenotazione selezionata
            this.restaurantName = restaurantName;
            this.username = username;
            this.reservDate = reservDate;
            this.numCustomers = numCustomers;
            edit = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BsReservation bsReservation = new BsReservation();
            bsReservation.ClearFields(ref valueCustomers, ref cmbCustomers, ref dgvRestaurants);
            txtRestaurant.Text = dgvRestaurants.SelectedRows[0].Cells[1].Value.ToString();
            txtSeats.Text = GetEmptySeats();
            txtPrice.Text = GetPrice().ToString() + "€";

        }

        private void FrmManageReser_Load(object sender, EventArgs e)
        {
            ExecuteLoadProcedures();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveElement();
            txtSeats.Text = GetEmptySeats();
        }

        private void dgvRestaurants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRestaurant.Text = dgvRestaurants.SelectedRows[0].Cells[1].Value.ToString();
            txtSeats.Text = GetEmptySeats();
            txtPrice.Text = GetPrice().ToString() + "€";
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

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsername.Text = cmbCustomers.SelectedValue.ToString();
        }

        private void valueCustomers_ValueChanged(object sender, EventArgs e)
        {
            txtPrice.Text = GetPrice().ToString() + "€";
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            dgvRestaurants.DataSource = bsRestaurant.ReadName(txtCity.Text);
        }

        private void SaveElement()
        {
            BsReservation bsReservation = new BsReservation();
            BsLogTable bsLogTable = new BsLogTable();
            DateTime requestDate = DateTime.Today;
            DateTime reservationDate = GetSelectedDate();
            string title = "";
            string message = "";
            int price = 0;
            Reservation entity;
            LogTable logEntity;

            if(dgvRestaurants.CurrentCell != null)
            {
                price = bsReservation.GetPrice((int)valueCustomers.Value, (int)dgvRestaurants.CurrentRow.Cells[0].Value);
                entity = bsReservation.CreateEntity((int)dgvRestaurants.CurrentRow.Cells[0].Value, cmbCustomers.SelectedItem.ToString(), requestDate, reservationDate, (int)valueCustomers.Value, price);
            }

            else
            {
                price = bsReservation.GetPrice((int)valueCustomers.Value, (int)dgvRestaurants.SelectedRows[0].Cells[0].Value);
                entity = bsReservation.CreateEntity((int)dgvRestaurants.SelectedRows[0].Cells[0].Value, cmbCustomers.SelectedItem.ToString(), requestDate, reservationDate, (int)valueCustomers.Value,price);
            }

            if (!bsReservation.IsValid(entity, ref message, ref title, edit, idSelected))
            {
                OperationMessage.GetCustomError(message, title);
            }

            else
            {
                if (edit)
                {
                    logEntity = bsLogTable.CreateEntity(idSelected, entity.IdRestaurant,0,entity.Username, DateTime.Now);
                    bsReservation.Update(logEntity,entity, idSelected, ref message);
                    OperationMessage.GetCustomMessage(message, "Modifica prenotazione");
                    this.Hide();
                }
                else
                {
                    logEntity = bsLogTable.CreateEntity(idSelected, entity.IdRestaurant, 1, entity.Username, DateTime.Now);
                    bsReservation.Create(logEntity,entity,ref message);
                    OperationMessage.GetCustomMessage(message,"Nuova prenotazione");
                }
              
                bsReservation.ClearFields(ref valueCustomers, ref cmbCustomers, ref dgvRestaurants);
                ExecuteLoadProcedures();

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
        private void ExecuteLoadProcedures()
        {
            BsRestaurant bsRestaurant = new BsRestaurant();

            cmbCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomers.DataSource = GetUsernames();


            dgvRestaurants.DataSource = bsRestaurant.ReadName(txtCity.Text);
            dgvRestaurants.Columns[0].Visible = false; //Viene nascosta la colonna degli ID
            
            txtRestaurant.Text = dgvRestaurants.SelectedRows[0].Cells[1].Value.ToString();
            txtSeats.Text = GetEmptySeats(); //Vengono mostrati i posti disponibili
            txtPrice.Text = GetPrice().ToString() + "€";

            //Procedura alternativa in caso di modifica (vengono mostrati i valori già registrati) 
            if(edit)
            {
                //Vengono settati i dati precedentemente inseriti dall'utente
                foreach (DataGridViewRow row in dgvRestaurants.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(restaurantName))
                    {
                        row.Selected = true;
                        txtRestaurant.Text =  row.Cells[1].Value.ToString();
                    }
                }

                cmbCustomers.SelectedItem = username;
                monthCalendar.SetDate(reservDate);
                valueCustomers.Value = numCustomers;
   
            }

        } 
        private List<string> GetUsernames()
        {
            //Raccoglie tutti gli username in una lista
            BsCustomer bsCustomer = new BsCustomer();
            List<string> username = new List<string>();
            DataTable dt = new DataTable();

            dt = bsCustomer.ReadUsername();

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                username.Add(dt.Rows[i][0].ToString());
            }

            return username;
            
        }

    }
}
