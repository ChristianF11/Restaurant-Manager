using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;

namespace Data_layer
{
    public class DsReservation
    {
        public void Create(Reservation reservation)
        {
            DbData genericOperation = new DbData();

            string query = $"insert into Reservation values({reservation.IdRestaurant},'{reservation.Username}',convert(datetime,'{reservation.RequestDate}',103)," +
                $"convert(datetime,'{reservation.ReservationDate}',103),{reservation.NumCustomers},{reservation.Price})";


            genericOperation.Create(query);

        }

        public DataTable Read()
        {
            DbData genericOperation = new DbData();
            DataTable reservationTable = new DataTable();
            string query = "select * from Reservation";
            reservationTable = genericOperation.Read(query);

            return reservationTable;

        }

        public void Update(Reservation reservation, int id)
        {
            DbData genericOperation = new DbData();
            string query = $"update Reservation set IdRestaurant = {reservation.IdRestaurant},Username = '{reservation.Username}',RequestDate = convert(datetime,'{reservation.RequestDate}',103)," +
                $"ReservationDate = convert(datetime,'{reservation.ReservationDate}',103),NumberCustomers = {reservation.NumCustomers},Price = {reservation.Price} where IdReservation = {id}";

            genericOperation.Update(query);

        }

        public void Delete(int id)
        {
            DbData genericOperation = new DbData();

            string query = $"delete from Reservation where IdReservation = {id}";
            genericOperation.Delete(query);

        }
    }
}
