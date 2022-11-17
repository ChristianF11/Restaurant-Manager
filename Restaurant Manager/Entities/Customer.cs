using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Customer
    {
        private string username, password, info, phoneNum, email, city;
        private bool isAdmin;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Info
        {
            get { return info; }
            set { info = value; }
        }

        public string PhoneNum
        {
            get { return phoneNum; }
            set { phoneNum = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        public Customer(string username, string password, string info, string phoneNum, string email, string city, bool isAdmin)
        {
            Username = username;
            Password = password;
            Info = info;
            PhoneNum = phoneNum;
            Email = email;
            City = city;
            IsAdmin = isAdmin;
        }
    }
}
