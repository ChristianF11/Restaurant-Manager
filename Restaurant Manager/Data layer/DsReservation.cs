﻿using Entities;
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
        public void Create(Reservation reservation,DbData dbData) //Metodo con transazione
        {
            //Al momento della creazione viene aggiornata anche la colonna dei posti occupati nella tabella "Restaurant"

            string query = $"insert into Reservation values({reservation.IdRestaurant},'{reservation.Username}',convert(datetime2,'{reservation.RequestDate}',103)," +
                $"convert(datetime2,'{reservation.ReservationDate}',103),{reservation.NumCustomers},{reservation.Price}) ";

            dbData.Create(query);

        }

        /// <summary>
        /// Metodo di lettura generale. Restituisce la lista di tutti i ristoranti
        /// </summary>
        public DataTable Read(string customerName, string city, string order, bool futureReservations)
        {
            DbData genericOperation = new DbData();
            DataTable reservationTable = new DataTable();
            string query = "select IdReservation as 'ID', BusinessName as 'Ristorante',Username,RequestDate as 'Data prenotazione',ReservationDate as 'Giorno Prenotato'," +
                "NumberCustomers as 'Posti Prenotati',concat(cast(Price as decimal(10,2)),'€') as 'Prezzo' from Restaurant r inner join Reservation rv on r.IdRestaurant = rv.IdRestaurant " +
                $"where Username like '{customerName}%' and r.City like '{city}%' ";

            if (futureReservations)
                query += $"and ReservationDate > CAST(GETDATE() as datetime2) order by {order}";

            else
                query += $"order by {order}";

            reservationTable = genericOperation.Read(query);

            return reservationTable;

        }

        /// <summary>
        /// Metodo di lettura specifico. Restituisce tutte le prenotazioni del ristorante selezionato
        /// </summary>
        public DataTable Read(int idRestaurant,string customerName, string city, string order, bool futureReservations)
        {
            DbData genericOperation = new DbData();
            DataTable reservationTable = new DataTable();
            string query = "select IdReservation as 'ID', BusinessName as 'Ristorante',Username,RequestDate as 'Data prenotazione',ReservationDate as 'Giorno Prenotato'," +
                "NumberCustomers as 'Posti Prenotati',concat(cast(Price as decimal(10,2)),'€') as 'Prezzo' from Restaurant r inner join Reservation rv on r.IdRestaurant = rv.IdRestaurant " +
                $"where rv.IdRestaurant = {idRestaurant} and Username like '{customerName}%' and r.City like '{city}%' ";

            if (futureReservations)
                query += $"and ReservationDate > CAST(GETDATE() as datetime2) order by {order}";

            else
                query += $"order by {order}";

            reservationTable = genericOperation.Read(query);

            return reservationTable;

        }

        public void Update(Reservation reservation, int id, DbData dbData) //Metodo con transazione
        {
            string query = $"update Reservation set IdRestaurant = {reservation.IdRestaurant},Username = '{reservation.Username}',RequestDate = convert(datetime2,'{reservation.RequestDate}',103)," +
                $"ReservationDate = convert(datetime2,'{reservation.ReservationDate}',103),NumberCustomers = {reservation.NumCustomers},Price = {reservation.Price} where IdReservation = {id}";

            dbData.Update(query);

        }

        public void Delete(int idReservation, DbData dbData) //Metodo con transazione
        { 
            string query = $"delete from Reservation where IdReservation = {idReservation}";

            dbData.Delete(query);
        }

        /// <summary>
        /// Verifica che l’username inserito esista
        /// </summary>
        public int CheckUsername(string username)
        {
            DbData genericOperation = new DbData();
            int value = 0;

            genericOperation.Open();
            string query = $"select count(*) from Customer where Username = '{username}'";
            value = genericOperation.Execute(query);
            genericOperation.Close();

            return value;
        }

        /// <summary>
        /// Verifica che il ristorante selezionato esista
        /// </summary>
        public int CheckRestaurant(int id)
        {
            DbData genericOperation = new DbData();
            int value = 0;

            genericOperation.Open();
            string query = $"select count(*) from Restaurant where IdRestaurant = '{id}'";
            value = genericOperation.Execute(query);
            genericOperation.Close();

            return value;
        }

        /// <summary>
        /// Restituisce il valore di quanti posti rimarrebbero contando anche i clienti che stanno prenotando
        /// </summary>
        public int CountActualSeats(int idRestaurant, DateTime reservationDate, int newCustomers)
        {
            DbData genericOperation = new DbData();
            int seatsTaken = 0;
            
            genericOperation.Open();
            try
            {
                //Numero di posti occupati (se la query non ritorna nessun valore verrà ritornato il valore totale di posti liberi siccome non c'è nessuna prenotazione)
                string query = $"IF NOT EXISTS(select Seats - sum(NumberCustomers) from Reservation rs left join Restaurant r on rs.IdRestaurant = r.IdRestaurant" +
                    $" where r.IdRestaurant = {idRestaurant} and ReservationDate = convert(datetime2, '{reservationDate}', 103) group by Seats)" +
                    " BEGIN select Seats from Restaurant where IdRestaurant = 7 END" +
                    $" ELSE BEGIN select Seats - sum(NumberCustomers) from Reservation rs left join Restaurant r on rs.IdRestaurant = r.IdRestaurant " +
                    $"where r.IdRestaurant = {idRestaurant} and ReservationDate = convert(datetime2, '{reservationDate}', 103) group by Seats END";

                //Numero di posti occupati - clienti che stanno prenotando
                seatsTaken = genericOperation.Execute(query) - newCustomers;
            }
            catch
            {
                seatsTaken = 0;
            }
            genericOperation.Close();

            return seatsTaken;
        }

        /// <summary>
        /// Restituisce il valore dei posti occupati senza contare il numero di clienti che stanno prenotando
        /// </summary>
        public int CountSeats(int idRestaurant, DateTime reservationDate)
        {
            DbData genericOperation = new DbData();
            int seatsTaken = 0;

            genericOperation.Open();
            try
            {
                //Numero di posti occupati
                string query = $"select sum(NumberCustomers) from Reservation where IdRestaurant = {idRestaurant} and ReservationDate = convert(datetime2,'{reservationDate}',103)";

                seatsTaken = genericOperation.Execute(query);
            }
            catch
            {
                seatsTaken = 0;
            }
            genericOperation.Close();

            return seatsTaken;
        }

        /// <summary>
        /// Metodo che ritorna il valore di quanti posti rimarrebbero senza contare i clienti che stanno prenotando. 
        /// Questo metodo funge da "ripristino posti" infatti viene utilizzato durante la modifica di un’ordinazione 
        /// (per capire quanti posti sarebbero rimasti senza quella prenotazione che si sta editando)
        /// </summary>
        public int GetEmptySeats(int seatsTaken, int idRestaurant) //Restituisce quanti posti rimarrebbero SENZA contare i clienti che stanno prenotando
        {
            DbData genericOperation = new DbData();
            int emptySeats = 0;

            genericOperation.Open();
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
            genericOperation.Close();

            return emptySeats;
        }

        /// <summary>
        /// Restituisce il valore del prezzo della prenotazione attuale
        /// </summary>
        public int GetPrice(int numCustomers, int idRestaurant)
        {
            DbData genericOperation = new DbData();
            int price = 0;

            genericOperation.Open();
            string query = $"select r.AveragePrice * {numCustomers} from Restaurant r left join Reservation rs on r.IdRestaurant = rs.IdReservation where r.IdRestaurant = {idRestaurant}";
            price = genericOperation.Execute(query);
            genericOperation.Close();

            return price;
        }

        /// <summary>
        /// Restituisce il numero di clienti di una specifica prenotazione
        /// </summary>
        public int GetNumCustomers(int idReservation) //Ritorna il numero di clienti presenti in una prenotazione (utile per la funzione "Modifica")
        {
            DbData genericOperation = new DbData();
            int numCustomers = 0;

            genericOperation.Open();
            string query = $"select NumberCustomers from Reservation where IdReservation = {idReservation}";
            numCustomers= genericOperation.Execute(query);
            genericOperation.Close();

            return numCustomers;
        }

        public int GetRestaurantId(int idReservation)
        {
            DbData genericOperation = new DbData();
            int idRestaurant = 0;

            genericOperation.Open();
            string query = $"select IdRestaurant from Reservation where IdReservation = {idReservation}";

            idRestaurant = genericOperation.Execute(query);
            genericOperation.Close();

            return idRestaurant;
        }
    }
}
