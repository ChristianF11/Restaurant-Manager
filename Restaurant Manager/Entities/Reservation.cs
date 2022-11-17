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

        public Reservation(int idRestaurant, int numCustomers, string username, DateTime requestDate, DateTime reservationDate, double price)
        {
            this.idRestaurant = idRestaurant;
            NumCustomers = numCustomers;
            Username = username;
            RequestDate = requestDate;
            ReservationDate = reservationDate;
            Price = price;
        }

        public Reservation(int idReservation, int idRestaurant, int numCustomers, string username, DateTime requestDate, DateTime reservationDate, double price)
        {
            IdReservation = idReservation;
            this.idRestaurant = idRestaurant;
            NumCustomers = numCustomers;
            Username = username;
            RequestDate = requestDate;
            ReservationDate = reservationDate;
            Price = price;
        }
    }
}
