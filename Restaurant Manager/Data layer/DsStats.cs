using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class DsStats
    {
        public DataTable GetRestaurantsIncome(int month)
        {
            DbData genericOperation = new DbData();
            DataTable dt = new DataTable();
            string query = $"select BusinessName,Sum(Price) as 'Incasso' from ViewReservations  where Month(ReservationDate) = {month} group by BusinessName order by 'Incasso' desc";

            dt = genericOperation.Read(query);

            return dt;
        }

        public DataTable GetRestaurantsCustomers(int month)
        {
            DbData genericOperation = new DbData();
            DataTable dt = new DataTable();
            string query = $"select BusinessName,Sum(NumberCustomers) as 'Clienti' from ViewReservations  where Month(ReservationDate) = {month} group by BusinessName order by 'Clienti' desc";
        
            dt = genericOperation.Read(query);
            
            return dt;
        }

        public DataTable GetTypesIncome(int month)
        {
            DbData genericOperation = new DbData();
            DataTable dt = new DataTable();
            string query = "select Descrizione as 'Tipo Cucina', Sum(Price) as 'Incasso' from ViewTypeStats " +
                $"where Month(ReservationDate) = {month} group by Descrizione order by 'Incasso' desc";

            dt = genericOperation.Read(query);

            return dt;
        }

        public DataTable GetTypesCustomers(int month)
        {
            DbData genericOperation = new DbData();
            DataTable dt = new DataTable();
            string query = "select Descrizione as 'Tipo Cucina', Sum(NumberCustomers) as 'Clienti' from ViewTypeStats " +
                $"where Month(ReservationDate) = {month} group by Descrizione order by 'Clienti' desc";

            dt = genericOperation.Read(query);

            return dt;
        }

        public DataTable GetCitiesIncome(int month)
        {
            DbData genericOperation = new DbData();
            DataTable dt = new DataTable();
            string query = "select City,sum(Price) as 'Incasso' from Restaurant r inner join Reservation rs on r.IdRestaurant = rs.IdRestaurant " +
                $" where City like '%' and Month(ReservationDate) = {month} group by City order by 'Incasso' desc";

            dt = genericOperation.Read(query);

            return dt;
        }

        public DataTable GetCitiesCustomers(int month)
        {
            DbData genericOperation = new DbData();
            DataTable dt = new DataTable();
            string query = "select City,sum(NumberCustomers) as 'Clienti' from Restaurant r inner join Reservation rs on r.IdRestaurant = rs.IdRestaurant" +
                $" where City like '%' and Month(ReservationDate) = {month} group by City order by 'Clienti' desc";

            dt = genericOperation.Read(query);

            return dt;
        }
    }
}
