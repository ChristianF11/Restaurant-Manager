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
        public bool IsValid(Reservation reservation)
        {
            DsReservation reservationData = new DsReservation();

            if (reservation.Username.Length == 0)
                return false;
                
            if(reservationData.CheckUsername(reservation.Username) == 0) //Verifica l'esistenza del cliente
                return false;

            if(reservationData.CheckRestaurant(reservation.IdRestaurant) == 0) //Verifica l'esistenza del ristorante
                return false;

            if (reservation.RequestDate > reservation.ReservationDate) //Verifica che la data di richiesta non sia dopo quella di prenotazione
                return false;

            if (reservation.RequestDate > DateTime.Now) //Verifica che la richiesta non avvenga nel futuro
                return false;

            if (reservation.ReservationDate < DateTime.Now) //Verifica che la prenotazione non venga effettuata nel passato
                return false;

            if (reservation.NumCustomers < 0)
                return false;

            if (reservationData.CountSeats(reservation.NumCustomers, reservation.IdRestaurant) < 0) //Verifica che ci sia ancora posto
                return false;

            return true;
        }

        /*public Reservation Create(parametri inseriti in UI)
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
