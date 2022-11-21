using Data_layer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class BsReservation
    {
        public bool IsValid(Reservation reservation, ref string message, ref string title)
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
                

            if (reservationData.CountSeats(reservation.NumCustomers, reservation.IdRestaurant) < 0) //Verifica che ci sia ancora posto
            {
                message = "Spiacenti, ma siamo al completo. Prova a prenotare per un altro giorno";
                return false;
            }
                
            return true;
        }

        /*public Reservation CreateEntity(parametri inseriti in UI)
        {
            //Metodo che restituirà un oggetto di tipo Reservation
        }*/

        public void Create(Reservation reservation)
        {
            DsReservation reservationData = new DsReservation();
            reservationData.Create(reservation);
        }

        public DataTable Read()
        {
            DataTable dtReservation = new DataTable();
            DsReservation reservationData = new DsReservation();
            dtReservation = reservationData.Read();

            return dtReservation;
        }

        public void Update(Reservation reservation, int id)
        {
            DsReservation reservationData = new DsReservation();
            reservationData.Update(reservation, id);
        }

        public void Delete(int idReservation)
        {
            DsReservation reservationData = new DsReservation();
            reservationData.Delete(idReservation);
        }

    }
}
