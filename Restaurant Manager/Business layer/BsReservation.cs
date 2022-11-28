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
                

            if (reservation.RequestDate > DateTime.Now) //Verifica che la richiesta non avvenga nel futuro
            {
                message = "La richiesta non può avvenire nel futuro";
                return false;
            }
                

            if (reservation.ReservationDate < DateTime.Now) //Verifica che la prenotazione non venga effettuata nel passato
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

        public void Create(Reservation reservation)
        {
            DsReservation reservationData = new DsReservation();
            reservationData.Create(reservation);
        }

        public DataTable Read(string customerName, string city)
        {
            DataTable dtReservation = new DataTable();
            DsReservation reservationData = new DsReservation();
            dtReservation = reservationData.Read(customerName,city);

            return dtReservation;
        }

        public void Update(Reservation reservation, int id)
        {
            DsReservation reservationData = new DsReservation();
            reservationData.Update(reservation, id);
        }

        public void Delete(int idReservation, ref string message)
        {
                DsReservation reservationData = new DsReservation();
                reservationData.Delete(idReservation);
                message = "Prenotazione cancellata";
        }

        public void ClearFields(ref TextBox txtUsername, ref NumericUpDown valueCustomers)
        {
            txtUsername.Text = string.Empty;
            valueCustomers.Text = "0";
        }

        public int GetEmptySeats(int idRestaurant, DateTime reservationDate) //Restituisce il valore dei posti rimanenti
        {
            DsReservation reservationData = new DsReservation();
            int seatsTaken = 0;
            int emptySeats = 0;

            seatsTaken = reservationData.CountSeats(idRestaurant, reservationDate);
            emptySeats = reservationData.GetEmptySeats(seatsTaken, idRestaurant);

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

        public int GetRestoredSeats(int idRestaurant, DateTime reservationDate, int idReservation) //Numero di posti senza una determinata prenotazione (in quanto sta per essere modificata)
        {
            int restoredSeats = GetEmptySeats(idRestaurant, reservationDate) + GetNumCustomers(idReservation);

            return restoredSeats;
        }

    }
}
