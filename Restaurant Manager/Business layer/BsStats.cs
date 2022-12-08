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
        public DataTable GetRestaurantsIncome(int month)
        {
            DsStats statsData = new DsStats();
            DataTable dt = new DataTable();

            dt = statsData.GetRestaurantsIncome(month);

            return dt;

        }

        public DataTable GetRestaurantsCustomers(int month)
        {
            DsStats statsData = new DsStats();
            DataTable dt = new DataTable();

            dt = statsData.GetRestaurantsCustomers(month);
            
            return dt;
        }

        public DataTable GetTypesIncome(int month)
        {
            DsStats statsData = new DsStats();
            DataTable dt = new DataTable();

            dt = statsData.GetTypesIncome(month);

            return dt;
        }

        public DataTable GetTypesCustomers(int month)
        {
            DsStats statsData = new DsStats();
            DataTable dt = new DataTable();

            dt = statsData.GetTypesCustomers(month);

            return dt;
        }

        public DataTable GetCitiesIncome(int month)
        {
            DsStats statsData = new DsStats();
            DataTable dt = new DataTable();

            dt = statsData.GetCitiesIncome(month);

            return dt;
        }

        public DataTable GetCitiesCustomers(int month)
        {
            DsStats statsData = new DsStats();
            DataTable dt = new DataTable();

            dt = statsData.GetCitiesCustomers(month);

            return dt;
        }

    }
}
