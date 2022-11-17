using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Stats
    {
        private double income;
        private int seatsBooked, reservations;

        public double Income
        {
            get { return income; } 
            set { income = value; }
        
        }

        public int SeatsBooked
        {
            get { return seatsBooked; }
            set { seatsBooked = value; }
        }

        public int Reservations
        {
            get { return reservations; }
            set { reservations = value; }
        }

        public Stats()
        {
            Income = 0;
            SeatsBooked = 0;
            reservations = 0;
        }

        public Stats(double income)
        {
            Income = income;
            SeatsBooked = 0;
            Reservations = 0;
        }

        public Stats(double income, int seatsBooked) : this(income)
        {
            SeatsBooked= seatsBooked;
            Reservations = 0;
        }

        public Stats(double income, int seatsBooked, int reservations) : this(income, seatsBooked)
        {
            Reservations = reservations;
        }
    }
}
