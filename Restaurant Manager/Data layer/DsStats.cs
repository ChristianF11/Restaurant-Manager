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
        public DataTable RestaurantsIncome(int month)
        {
            DbData genericOperation = new DbData();
            DataTable dt = new DataTable();
            string query = $"select BusinessName,Sum(Price) as 'Incasso' from ViewReservations  where Month(ReservationDate) = {month} group by BusinessName order by 'Incasso' desc";

            dt = genericOperation.Read(query);

            return dt;
        }

        public DataTable RestaurantsCustomers(int month)
        {
            DbData genericOperation = new DbData();
            DataTable dt = new DataTable();
            string query = $"select BusinessName,Sum(NumberCustomers) as 'Clienti' from ViewReservations  where Month(ReservationDate) = {month} group by BusinessName order by 'Clienti' desc";
        
            dt = genericOperation.Read(query);
            
            return dt;
        }

    }
}
