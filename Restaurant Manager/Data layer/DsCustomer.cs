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
        public void Create(Customer customer)
        {
            DbData genericOperation = new DbData();

            string query = $"insert into Customer values('{customer.Username}','{customer.Password}',{customer.IsAdmin},'{customer.Info}','{customer.PhoneNum}','{customer.Email}','{customer.City}')";

            genericOperation.Create(query);

        }

        public DataTable Read()
        {
            DbData genericOperation = new DbData();
            DataTable cusstomerTable = new DataTable();
            string query = "select * from Customer";
            cusstomerTable = genericOperation.Read(query);

            return cusstomerTable;

        }

        public void Update(Customer customer)
        {
            DbData genericOperation = new DbData();
            string query = $"update Customer set Username = '{customer.Username}',Password = '{customer.Password}',IsAdmin = '{customer.IsAdmin}',Info = '{customer.Info}'," +
                $"PhoneNumber = '{customer.PhoneNum}',Email = '{customer.Email}',City = '{customer.City}' where Username = '{customer.Username}'";

            genericOperation.Update(query);

        }

        public void Delete(string username)
        {
            DbData genericOperation = new DbData();

            string query = $"delete from Customer where Username = '{username}'";
            genericOperation.Delete(query);

        }
    }
}
