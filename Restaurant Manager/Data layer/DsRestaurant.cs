using Business_layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_layer
{
    public class DsRestaurant
    {

        public void Create(Restaurant restaurant)
        {
            DbData genericOperation = new DbData();
            string query = $"insert into Restaurant values('{restaurant.BusinessName}','{restaurant.PIva}','{restaurant.Street}','{restaurant.City}','{restaurant.TelephoneNum}',{restaurant.Type}," +
            $"{restaurant.Seats},{restaurant.AvgPrice})";

            genericOperation.Create(query);

        }

        public DataTable Read()
        {
            DbData genericOperation = new DbData();
            DataTable restaurantTable = new DataTable();
            string query = "select * from Restaurant";
            restaurantTable = genericOperation.Read(query);

            return restaurantTable;

        }

        public void Update(Restaurant restaurant, int id)
        {
            DbData genericOperation = new DbData();
            string query = $"update from Restaurant set BusinessName = '{restaurant.BusinessName}',pIVA = '{restaurant.PIva}',Street = '{restaurant.Street}',City = '{restaurant.City}'," +
            $"'PhoneNumber = {restaurant.TelephoneNum}',Type = {restaurant.Type},Seats = {restaurant.Seats}, AveragePrice = {restaurant.AvgPrice} where RestaurantId = {id}";

            genericOperation.Update(query);

        }

        public void Delete(int id)
        {
            DbData genericOperation = new DbData();

            string query = $"delete from Restaurant where RestaurantId = {id}";
            genericOperation.Delete(query);
        }
    }
}
