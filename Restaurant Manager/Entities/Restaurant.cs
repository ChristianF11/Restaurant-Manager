using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Restaurant
    {
        private int idRestaurant, type, seats;
        private double avgPrice;
        private string businessName, pIva, street, city, telephoneNum;

        public int IdRestaurant
        {
            get { return idRestaurant; }
            set { idRestaurant = value; }
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

        public Restaurant()
        {
            Type = 0;
            Seats = 0;
            AvgPrice = 0;
            BusinessName = string.Empty;
            PIva = string.Empty;
            Street = string.Empty;
            City = string.Empty;
            TelephoneNum = string.Empty;
        }

        public Restaurant(int type)
        {
            Type = type;
            Seats = 0;
            AvgPrice = 0;
            BusinessName = string.Empty;
            PIva = string.Empty;
            Street = string.Empty;
            City = string.Empty;
            TelephoneNum = string.Empty;
        }

        public Restaurant(int type, int seats) : this(type)
        {
            Seats = seats;
            AvgPrice = 0;
            BusinessName = string.Empty;
            PIva = string.Empty;
            Street = string.Empty;
            City = string.Empty;
            TelephoneNum = string.Empty;
        }

        public Restaurant(int type, int seats, double avgPrice) : this(type,seats)
        {
            AvgPrice = avgPrice;
            BusinessName = string.Empty;
            PIva = string.Empty;
            Street = string.Empty;
            City = string.Empty;
            TelephoneNum = string.Empty;
        }

        public Restaurant(int type, int seats, double avgPrice, string businessName) : this(type,seats,avgPrice)
        {
            BusinessName = businessName;
            PIva = string.Empty;
            Street = string.Empty;
            City = string.Empty;
            TelephoneNum = string.Empty;
        }

        public Restaurant(int type, int seats, double avgPrice, string businessName, string pIva) : this(type,seats,avgPrice,businessName)
        {
            PIva = pIva;
            Street = string.Empty;
            City = string.Empty;
            TelephoneNum = string.Empty;
        }

        public Restaurant(int type, int seats,double avgPrice, string businessName, string pIva, string street) : this(type,seats,avgPrice,businessName,pIva)
        {
            Street = street;
            City = string.Empty;
            TelephoneNum = string.Empty;
        }

        public Restaurant(int type, int seats, double avgPrice, string businessName, string pIva, string street, string city) : this(type,seats,avgPrice,businessName,pIva,street)
        {
            City = city;
            TelephoneNum = string.Empty;
        }

        public Restaurant(int type, int seats, double avgPrice, string businessName, string pIva, string street, string city, string telephoneNum) : this(type,seats,avgPrice,businessName,pIva,street,city)
        {

            TelephoneNum = telephoneNum;
        }

        public Restaurant(int idRestaurant,int type, int seats, double avgPrice, string businessName, string pIva, string street, string city, string telephoneNum) : this(type, seats, avgPrice, businessName, pIva, street, city,telephoneNum)
        {

           IdRestaurant = idRestaurant;
        }

    }
}
