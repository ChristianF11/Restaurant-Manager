using Business_layer;
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
        public void Create(/*Customer customer*/)
        {
            DbData genericOperation = new DbData();

            //string query = "insert into Customer values(@Username,@Password,@IsAdmin,@Info,@PhoneNumber,@Email,@City)";
            string query = "insert into Customer values('Piermenti','Sfracellozzi22','false','Personaggio inventato','3435769990','piermenti@mail.com','NeighborVille')";
            SqlCommand command = new SqlCommand(query);

            genericOperation.Create(query);

        }

        public DataTable Read()
        {
            DbData genericOperation = new DbData();
            DataTable restaurantTable = new DataTable();
            string query = "select * from Customer";
            restaurantTable = genericOperation.Read(query);

            return restaurantTable;

        }

        public void Update(Customer customer)
        {
            DbData genericOperation = new DbData();
            string query = $"update Customer set Username = '{customer.Username}',Password = '{customer.Password}',IsAdmin = '{customer.IsAdmin}',Info = '{customer.Info}'," +
                $"PhoneNumber = '{customer.PhoneNum}',Email = '{customer.Email}',City = '{customer.City}' where Username = '{customer.Username}'";

            SqlCommand command = new SqlCommand(query);

            //Parametri

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
