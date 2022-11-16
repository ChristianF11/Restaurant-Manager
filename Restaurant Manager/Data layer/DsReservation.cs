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
    public class DsReservation
    {
        public void Create(Reservation reservation)
        {
            DbData genericOperation = new DbData();

            string query = "insert into Reservation values(@IdRestaurant, @Username, @RequestDate, @ReservationDate, @NumberCustomers, @Price)";
            SqlCommand command = new SqlCommand(query);

            //Parametri

            //genericOperation.Create(query);

        }

        public DataTable Read()
        {
            DbData genericOperation = new DbData();
            DataTable restaurantTable = new DataTable();
            string query = "select * from Reservation";
            restaurantTable = genericOperation.Read(query);

            return restaurantTable;

        }

        public void Update(Reservation reservation)
        {
            DbData genericOperation = new DbData();
            string query = "update from Reservation set IdRestaurant = @IdRestaurant,Username = @Username,RequestDate = @RequestDate," +
                "ReservationDate = @ReservationDate,NumberCustomers = @NumberCustomers,Price = @Price";

            SqlCommand command = new SqlCommand(query);

            //Parametri

            genericOperation.Update(query);

        }

        public void Delete(int id)
        {
            DbData genericOperation = new DbData();

            string query = "delete from Customer where IdReservation = " + id.ToString();
            genericOperation.Delete(query);

        }
    }
}
