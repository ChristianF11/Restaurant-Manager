using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class DsCustomer
    {
        public void Create(Customer customer, DbData dbData)
        {
            string query = $"insert into Customer values('{customer.Username}','{customer.Password}','{customer.IsAdmin}','{customer.Info}','{customer.PhoneNum}','{customer.Email}','{customer.City}')";

            dbData.Create(query);

        }

        public DataTable Read(string username, string city, string email, bool isAdmin)
        {
            DbData genericOperation = new DbData();
            DataTable customerTable = new DataTable();
            string query = "select Username, Password, IsAdmin as 'Admin', Info, PhoneNumber as 'Numero di telefono', Email, City as 'Città' from Customer" +
                $" where Username like '{username}%' and City like '{city}%' and Email like '{email}%' and (IsAdmin = '{isAdmin}' or IsAdmin = 'true')";

            customerTable = genericOperation.Read(query);

            return customerTable;

        }

        public DataTable ReadUsername()
        {
            DbData genericOperation = new DbData();
            DataTable usernameTable = new DataTable();
            string query = "select Username from Customer";

            usernameTable = genericOperation.Read(query);

            return usernameTable;
           
        }

        public void Update(Customer customer, DbData dbData)
        {
            string query = $"update Customer set Username = '{customer.Username}',Password = '{customer.Password}',IsAdmin = '{customer.IsAdmin}',Info = '{customer.Info}'," +
                $"PhoneNumber = '{customer.PhoneNum}',Email = '{customer.Email}',City = '{customer.City}' where Username = '{customer.Username}'";

            dbData.Update(query);

        }

        public void Delete(string username, DbData dbData)
        {
            string query = $"delete from Customer where Username = '{username}'";
            dbData.Delete(query);
        }

        public int CheckUsername(string username)
        {
            DbData genericOperation = new DbData();
            int value = 0;

            genericOperation.Open();
            string query = $"select count(*) from Customer where Username = '{username}'";
            value = genericOperation.Execute(query);
            genericOperation.Read(query);

            return value;
        }
    }
}
