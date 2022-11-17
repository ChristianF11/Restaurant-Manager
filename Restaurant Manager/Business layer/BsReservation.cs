using Data_layer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            if(reservationData.CheckUsername(reservation.Username) == 0)
                return false;

            if(reservationData.CheckRestaurant(reservation.IdRestaurant) == 0)
                return false;

            if (reservation.RequestDate > reservation.ReservationDate)
                return false;

            if (reservation.NumCustomers < 0)
                return false;

            /*Controllo dei posti disponibili*/
            //[CREARE METODO]

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

        public void Delete(int id)
        {
            DsReservation reservationData = new DsReservation();
            reservationData.Delete(id);
        }
    }
}
