using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Reservation
    {
        private int idReservation, idRestaurant, numCustomers;
        private double price;
        private string username;
        private DateTime requestDate, reservationDate;

        public int IdReservation
        {
            get { return idReservation; }
            set { idReservation = value; }
        }

        public int IdRestaurant
        {
            get { return idRestaurant; }
            set { idRestaurant = value; }
        }

        public int NumCustomers
        {
            get { return numCustomers; }
            set { numCustomers = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
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

        public Reservation()
        {
            IdRestaurant = 0;
            Username = string.Empty;
            NumCustomers = 0;
            RequestDate = DateTime.Now;
            ReservationDate = DateTime.Now;
        }

        public Reservation(int idRestaurant)
        {
            IdRestaurant = idRestaurant;
            Username = string.Empty;
            NumCustomers = 0;
            RequestDate = DateTime.Now;
            ReservationDate = DateTime.Now;
        }

        public Reservation(int idRestaurant,string username) : this(idRestaurant)
        {
            Username = username;
            NumCustomers = 0;
            RequestDate = DateTime.Now;
            ReservationDate = DateTime.Now;
        }

        public Reservation(int idRestaurant,string username,int numCustomers) : this(idRestaurant,username)
        {
            NumCustomers = numCustomers;
            RequestDate = DateTime.Now;
            ReservationDate = DateTime.Now;
        }

        public Reservation(int idRestaurant, string username, int numCustomers, DateTime requestDate) : this(idRestaurant, username,numCustomers)
        {
            RequestDate = requestDate;
            ReservationDate = DateTime.Now;
        }

        public Reservation(int idRestaurant, string username, int numCustomers, DateTime requestDate, DateTime reservationDate) : this(idRestaurant, username, numCustomers,requestDate)
        {
            ReservationDate = reservationDate;
        }

    }
}
