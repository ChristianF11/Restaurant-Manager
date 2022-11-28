using Data_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class BsStats
    {
        public DataTable RestaurantsIncome(int month) //Metodo che restituisce l'incasso (in ordine) di tutti i ristoranti
        {
            DsStats statsData = new DsStats();
            DataTable dt = new DataTable();

            dt = statsData.RestaurantsIncome(month);

            return dt;

        }

        public DataTable RestaurantsCustomers(int month)
        {
            DsStats statsData = new DsStats();
            DataTable dt = new DataTable();

            dt = statsData.RestaurantsCustomers(month);
            
            return dt;
        }

    }
}
