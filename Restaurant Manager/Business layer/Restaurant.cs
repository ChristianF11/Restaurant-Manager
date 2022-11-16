using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class Restaurant
    {
        private int idRestaurant, type, seats;
        private double avgPrice;
        private string businessName, pIva, street, city, telephoneNum;

        public int IdRestaurant
        {
            get { return idRestaurant;}
            set { idRestaurant = value;}
        }

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Seats
        {
            get { return seats; }
            set { seats = value; }
        }

        public double AvgPrice
        {
            get { return avgPrice; }
            set { avgPrice = value; }
        }

        public string BusinessName
        {
            get { return businessName; }
            set { businessName = value; }

        }

        public string PIva
        {
            get { return pIva; }
            set { pIva = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string TelephoneNum
        {
            get { return telephoneNum; }
            set { telephoneNum = value; }
        }

        public Restaurant(int type, int seats, double avgPrice, string businessName, string pIva, string street, string city, string telephoneNum)
        {
            Type = type;
            Seats = seats;
            AvgPrice = avgPrice;
            BusinessName = businessName;
            PIva = pIva;
            Street = street;
            City = city;
            TelephoneNum = telephoneNum;
        }

        public Restaurant(int idRestaurant, int type, int seats, double avgPrice, string businessName, string pIva, string street, string city, string telephoneNum)
        {
            IdRestaurant = idRestaurant;
            Type = type;
            Seats = seats;
            AvgPrice = avgPrice;
            BusinessName = businessName;
            PIva = pIva;
            Street = street;
            City = city;
            TelephoneNum = telephoneNum;
        }
    }   
}
