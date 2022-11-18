using Data_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class BsStats
    {
        public int GetIncome(int idRestaurant)
        {
            DsStats statsData = new DsStats();
            int totalIncome = 0;

            totalIncome = statsData.GetIncome(idRestaurant);
            
            return totalIncome;
        }

        public DataTable GetPrenotationRank()
        {
            DataTable dtRestaurant = new DataTable();
            DsStats statsData = new DsStats();

            dtRestaurant = statsData.GetPrenotationRank();

            return dtRestaurant;
        }
    }
}
