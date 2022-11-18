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
        public int GetIncome(int idRestaurant)
        {
            DbData genericOperation = new DbData();
            string query = $"select sum(Price) from Reservation where IdRestaurant = {idRestaurant}";

            return genericOperation.Execute(query);
        }
        public DataTable GetPrenotationRank()
        {
            DbData genericOperation = new DbData();
            string query = "select BusinessName,City,SeatsTaken from Restaurant order by SeatsTaken desc";

            return genericOperation.Read(query);
        }

    }
}
