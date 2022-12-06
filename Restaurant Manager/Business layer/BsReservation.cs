using Data_layer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_layer
{
    public class BsReservation
    {
        public bool IsValid(Reservation reservation, ref string message, ref string title, bool edit, int idSelected)
        {
            DsReservation reservationData = new DsReservation();
            title = "Gestione prenotazione";

            if (reservation.Username.Length == 0)
            {
                message = "Inserisci il nome dell'utente";
                return false;

            }

            if (reservationData.CheckUsername(reservation.Username) == 0) //Verifica l'esistenza del cliente
            {
                message = "L'utente non esiste";
                return false;
            } 
                

            if(reservationData.CheckRestaurant(reservation.IdRestaurant) == 0) //Verifica l'esistenza del ristorante 
            {
                message = "Il ristorante non esiste";
                return false;
            }
                

            if (reservation.RequestDate > reservation.ReservationDate) //Verifica che la data di richiesta non sia dopo quella di prenotazione
            {
                message = "Spiacenti ma la macchina del tempo non esiste ancora. Scegli un giorno da oggi in avanti";
                return false;
            }
                

            if (reservation.RequestDate > DateTime.Today) //Verifica che la richiesta non avvenga nel futuro
            {
                message = "La richiesta non può avvenire nel futuro";
                return false;
            }
                

            if (reservation.ReservationDate < DateTime.Today) //Verifica che la prenotazione non venga effettuata nel passato
            {
                message = "Spiacenti ma la macchina del tempo non esiste ancora. Scegli un giorno da oggi in avanti";
                return false;
            }
                
            if (reservation.NumCustomers < 0)
            {
                message = "Inserire un numero valido di posti da prenotare";
                return false;
            }
                

            if (reservationData.CountActualSeats(reservation.IdRestaurant, reservation.ReservationDate, reservation.NumCustomers) < 0 && !edit) //Verifica che ci sia ancora posto
            {
                message = "Spiacenti, ma siamo al completo. Prova a prenotare per un altro giorno";
                return false;
            }
            //In questo caso la prenotazione viene modificat e quindi il numero di clienti da verificare è il nuovo valore che sostituirà quello vecchio
            else if(edit && GetRestoredSeats(reservation.IdRestaurant,reservation.ReservationDate,idSelected) - reservation.NumCustomers < 0)
            {
                message = "Spiacenti, ma siamo al completo. Prova a prenotare per un altro giorno";
                return false;
            }

            return true;
        }

        public Reservation CreateEntity(int idRestaurant, string username, DateTime requestDate, DateTime reservationDate, int numCustomers, int price)
        {
            Reservation reservation = new Reservation(idRestaurant,username,numCustomers,requestDate,reservationDate,price);

            return reservation;
        }

        public Reservation CreateEntity(int idReservation,int idRestaurant, string username, DateTime requestDate, DateTime reservationDate, int numCustomers, int price)
        {
            Reservation reservation = new Reservation(idReservation,idRestaurant, username, numCustomers, requestDate, reservationDate, price);

            return reservation;
        }

        public void Create(LogTable log,Reservation reservation,ref string message)
        {
            DbData dbData = new DbData();
            DsReservation reservationData = new DsReservation();
            DsLogTable logTable = new DsLogTable();

            dbData.Open();
            dbData.BeginTrans();
            try
            {
                reservationData.Create(reservation,dbData);
                logTable.Create(log,dbData);

                dbData.CommitTrans();
                message = "Operazione andata a buon fine";
            }
            catch(Exception ex)
            {
                message = "Ops! Qualcosa è andato storto";
            }
            dbData.Close();
        }

        public DataTable Read(string customerName, string city, string selectedOrder, bool futureReservations) //Metodo Read generale di tutti i ristoranti
        {
            DataTable dtReservation = new DataTable();
            DsReservation reservationData = new DsReservation();

            if (selectedOrder == "**Nessun Filtro**")
                selectedOrder = "'ID'";

            else if (selectedOrder == "Prezzo")
                selectedOrder = "Price";

            else
                selectedOrder = $"'{selectedOrder}'";

            dtReservation = reservationData.Read(customerName,city,selectedOrder,futureReservations);

            return dtReservation;
        }

        public DataTable Read(int idRestaurant, string customerName, string city, string selectedOrder, bool futureReservations) //Overload del metodo Read, specifico per un ristorante
        {
            DataTable dtReservation = new DataTable();
            DsReservation reservationData = new DsReservation();

            if (selectedOrder == "**Nessun Filtro**")
                selectedOrder = "'ID'";

            else if (selectedOrder == "Prezzo")
                selectedOrder = "Price";

            else
                selectedOrder = $"'{selectedOrder}'";

            dtReservation = reservationData.Read(idRestaurant,customerName, city, selectedOrder, futureReservations);

            return dtReservation;
        }

        public void Update(LogTable log, Reservation reservation, int id, ref string message)
        {
            DbData dbData = new DbData();
            DsReservation reservationData = new DsReservation();
            DsLogTable logTable = new DsLogTable();

            dbData.Open();
            dbData.BeginTrans();
            try
            {
                reservationData.Update(reservation,id,dbData);
                logTable.Update(log, dbData);
                
                dbData.CommitTrans();
                message = "Operazione andata a buon fine";
            }
            catch(Exception ex)
            {
                dbData.RollbackTrans();
                message = "Ops! Qualcosa è andato storto";
            }
            dbData.Close();
        }

        public void Delete(LogTable log, int idReservation, ref string message)
        {
            DbData dbData = new DbData();
            DsReservation reservationData = new DsReservation();
            DsLogTable logTable = new DsLogTable();

            dbData.Open();
            dbData.BeginTrans();
            try
            {
                reservationData.Delete(idReservation,dbData);
                logTable.Delete(log,dbData);
                message = "Prenotazione cancellata";

                dbData.CommitTrans();
            }
            catch(Exception ex)
            {
                dbData.RollbackTrans();
                message = "Ops! Qualcosa è andato storto";
            }
        }

        public void ClearFields(ref NumericUpDown valueCustomers, ref ComboBox cmbCustomers, ref DataGridView dgvRestaurants)
        {
            valueCustomers.Text = "0";
            cmbCustomers.SelectedIndex = 0;
            dgvRestaurants.Rows[0].Cells[1].Selected = true;
        }

        public int GetEmptySeats(int idRestaurant, DateTime reservationDate) //Restituisce il valore dei posti rimanenti
        {
            DsReservation reservationData = new DsReservation();
            int takenSeats = 0;
            int emptySeats = 0;

            takenSeats = reservationData.CountTakenSeats(idRestaurant, reservationDate);
            emptySeats = reservationData.GetEmptySeats(takenSeats, idRestaurant);

            return emptySeats;
        }

        public int GetPrice(int numCustomers, int idRestaurant) 
        {
            DsReservation reservationData = new DsReservation();
            int avgPrice = 0;

            avgPrice = reservationData.GetPrice(numCustomers,idRestaurant);

            return avgPrice;
        }

        public int GetNumCustomers(int idReservation)
        {
            DsReservation reservationData = new DsReservation();
            int numCustomers = 0;
            numCustomers = reservationData.GetNumCustomers(idReservation);

            return numCustomers;
        }

        /// <summary>
        /// Ripristina i posti a prima della prenotazione che si sta modificando
        /// </summary>
        public int GetRestoredSeats(int idRestaurant, DateTime reservationDate, int idReservation) 
        {
            int restoredSeats = GetEmptySeats(idRestaurant, reservationDate) + GetNumCustomers(idReservation);

            return restoredSeats;
        }

        public int GetRestaurantId(int idReservation)
        {
            DsReservation reservationData = new DsReservation();
            int idRestaurant = 0;

            idRestaurant = reservationData.GetRestaurantId(idReservation); 

            return idRestaurant;
        }
    }
}
