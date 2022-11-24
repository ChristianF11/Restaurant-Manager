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
                $"convert(datetime,'{reservation.ReservationDate}',103),{reservation.NumCustomers},{reservation.Price}) ";

            genericOperation.Create(query);

        }

        public DataTable Read()
        {
            DbData genericOperation = new DbData();
            DataTable reservationTable = new DataTable();
            string query = "select IdReservation as 'ID', BusinessName as 'Ristorante',Username,RequestDate as 'Giorno prenotazione',ReservationDate as 'Giorno prenotato'," +
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
            string query = $"update Restaurant set SeatsTaken = SeatsTaken - rs.NumberCustomers " +
                $"from Restaurant r inner join Reservation rs on r.IdRestaurant = rs.IdRestaurant where rs.IdReservation = {idReservation}" +
                $"delete from Reservation where IdReservation = {idReservation}"; //Rimuovere prenotazione e rimuovere i posti liberati dalla colonna "SeatsTaken" (in "Restaurant")

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

        public int CountSeats(int idRestaurant, DateTime reservationDate)
        {
            DbData genericOperation = new DbData();
            int seatsTaken = 0;
            
            try
            {
                //Numero di posti occupati
                string query = $"select sum(NumberCustomers) from Reservation where IdRestaurant = {idRestaurant} and ReservationDate = convert(datetime,'{reservationDate}',103)";
                seatsTaken= genericOperation.Execute(query);
            }
            catch
            {
                seatsTaken = 0;
            }
            return seatsTaken;
        }

        public int GetEmptySeats(int seatsTaken, int idRestaurant)
        {
            DbData genericOperation = new DbData();
            int emptySeats = 0;

            try
            {
                //Posti liberi
                string query = $"select Seats - {seatsTaken} from Restaurant where IdRestaurant = {idRestaurant}";
                emptySeats = genericOperation.Execute(query);
            }
            catch
            {
                return emptySeats;
            }

            return emptySeats;
        }

        public decimal GetPrice(int numCustomers, int idRestaurant) //Errore di cast
        {
            DbData genericOperation = new DbData();
            string query = $"select Price * {numCustomers} from Reservation where IdRestaurant = {idRestaurant}";

            return genericOperation.ExecuteD(query);
        }
    }
}
