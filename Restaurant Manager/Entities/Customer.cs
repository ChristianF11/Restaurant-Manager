using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        public Customer()
        {
            Username = string.Empty;
            Password = string.Empty;
            Info = string.Empty;
            PhoneNum = string.Empty;
            Email = string.Empty;
            City = string.Empty;
            IsAdmin = false;
        }

        public Customer(string username)
        {
            Username = username;
            Password = string.Empty;
            Info = string.Empty;
            PhoneNum = string.Empty;
            Email = string.Empty;
            City = string.Empty;
            IsAdmin = false;
        }

        public Customer(string username, string password) : this(username)
        {
            Password = password;
            Info = string.Empty;
            PhoneNum = string.Empty;
            Email = string.Empty;
            City = string.Empty;
            IsAdmin = false;
        }

        public Customer(string username, string password, string info) : this(username,password)
        {
            Info = info;
            PhoneNum = string.Empty;
            Email = string.Empty;
            City = string.Empty;
            IsAdmin = false;
        }

        public Customer(string username, string password, string info, string phoneNum) : this(username,password,info)
        {
            PhoneNum = phoneNum;
            Email = string.Empty;
            City = string.Empty;
            IsAdmin = false;
        }

        public Customer(string username, string password, string info, string phoneNum, string email) : this(username,password,info,phoneNum)
        {
            Email = email;
            City = string.Empty;
            IsAdmin = false;
        }

        public Customer(string username, string password, string info, string phoneNum, string email,string city) : this(username,password,info,phoneNum,email)
        {
            City = city;
            IsAdmin = false;
        }

        public Customer(string username, string password, string info, string phoneNum, string email, string city, bool isAdmin) : this(username,password,info,phoneNum,email,city)
        {
            IsAdmin = isAdmin;
        }
    }
}
