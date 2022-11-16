using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class Reservation
    {
        private int idReservation, idRestaurant, numCustomers;
        private string username;
        private DateTime requestDate, reservationDate;

        public int IdReservation
        {
            get { return idReservation; }
            set { idReservation = value; }
        }

        public int NumCustomers
        {
            get { return numCustomers; }
            set { numCustomers = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public DateTime RequestDate
        {
            get { return requestDate; }
            set { requestDate = value; }
        }

        public DateTime ReservationDate
        {
            get { return reservationDate; }
            set { reservationDate = value; }
        }

        public Reservation(int idRestaurant, int numCustomers, string username, DateTime requestDate, DateTime reservationDate)
        {
            this.idRestaurant = idRestaurant;
            NumCustomers = numCustomers;
            Username = username;
            RequestDate = requestDate;
            ReservationDate = reservationDate;
        }

        public Reservation (int idReservation, int idRestaurant, int numCustomers, string username, DateTime requestDate, DateTime reservationDate)
        {
            IdReservation = idReservation;
            this.idRestaurant = idRestaurant;
            NumCustomers = numCustomers;
            Username = username;
            RequestDate = requestDate;
            ReservationDate = reservationDate;
        }
    }
}
