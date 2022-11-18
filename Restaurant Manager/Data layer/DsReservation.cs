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
            //Al momento della creazione viene aggiornata anche la colonna dei posti occupati nella tabella "Restaurant"
            DbData genericOperation = new DbData();

            string query = $"insert into Reservation values({reservation.IdRestaurant},'{reservation.Username}',convert(datetime,'{reservation.RequestDate}',103)," +
                $"convert(datetime,'{reservation.ReservationDate}',103),{reservation.NumCustomers},{reservation.Price}) " +
                $"update Restaurant set SeatsTaken = {reservation.NumCustomers} where IdRestaurant = {reservation.IdRestaurant}";


            genericOperation.Create(query);

        }

        public DataTable Read()
        {
            DbData genericOperation = new DbData();
            DataTable reservationTable = new DataTable();
            string query = "select BusinessName as 'Ristorante',Username,RequestDate as 'Giorno prenotazione',ReservationDate as 'Giorno prenotato'," +
                "NumberCustomers as 'Posti prenotati',Price from Restaurant r inner join Reservation rv on r.IdRestaurant = rv.IdRestaurant";
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

        public void Delete(int idReservation)
        {
            DbData genericOperation = new DbData(); 
            string query = $""; //Rimuovere prenotazione e rimuovere i posti liberati dalla colonna "SeatsTaken" (in "Restaurant")

            genericOperation.Delete(query);
        }

        public int CheckUsername(string username)
        {
            DbData genericOperation = new DbData();
            string query = $"select count(*) from Customer where Username = '{username}'";
            return genericOperation.Execute(query);
        }

        public int CheckRestaurant(int id)
        {
            DbData genericOperation = new DbData();
            string query = $"select count(*) from Restaurant where IdRestaurant = '{id}'";
            return genericOperation.Execute(query);
        }

        public int CountSeats(int numCustomers, int idRestaurant)
        {
            DbData genericOperation = new DbData();
            string query = $"update Restaurant set SeatsTaken = SeatsTaken + {numCustomers} where IdRestaurant = {idRestaurant}" +
                $"select Seats - SeatsTaken from Restaurant where IdRestaurant = {idRestaurant}";

            return genericOperation.Execute(query);
        }

    }
}
