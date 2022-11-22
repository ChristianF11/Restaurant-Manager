using Entities;
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
            $"{restaurant.Seats},0,{restaurant.AvgPrice})";

            genericOperation.Create(query);

        }

        public DataTable Read()
        {
            DbData genericOperation = new DbData();
            DataTable restaurantTable = new DataTable();
            string query = "select IdRestaurant as 'ID', BusinessName as 'Ristorante', pIva as 'IVA',Street as 'Via/Piazza',City as 'Città', PhoneNumber as 'Telefono', t.Descrizione as 'Tipo cucina', " +
                "Seats as 'Posti totali', SeatsTaken as 'Posti occupati', AveragePrice as 'Prezzo medio'\r\nfrom Restaurant r inner join RestaurantType t on t.Type = r.Type " +
                "where t.Type = r.Type";

            restaurantTable = genericOperation.Read(query);

            return restaurantTable;

        }

        public void Update(Restaurant restaurant, int id)
        {
            DbData genericOperation = new DbData();
            string query = $"update Restaurant set BusinessName = '{restaurant.BusinessName}',pIVA = '{restaurant.PIva}',Street = '{restaurant.Street}',City = '{restaurant.City}'," +
            $"PhoneNumber = '{restaurant.TelephoneNum}',Type = {restaurant.Type},Seats = {restaurant.Seats}, AveragePrice = {restaurant.AvgPrice} where IdRestaurant = {id}";

            genericOperation.Update(query);

        }

        public void Delete(int id)
        {
            DbData genericOperation = new DbData();

            string query = $"delete from Restaurant where IdRestaurant = {id}";
            genericOperation.Delete(query);
        }

        //Metodo che controlla l'unicità delle seguenti proprietà
        public int CheckUniqueProperty(Restaurant restaurant)
        {

            DbData genericOperation = new DbData();
            string query = $"select count(*) from Restaurant where BusinessName = '{restaurant.BusinessName}' and City = '{restaurant.City}' and Street = '{restaurant.Street}'" +
                $"or pIva = '{restaurant.PIva}' or PhoneNumber = '{restaurant.TelephoneNum}'";

            return genericOperation.Execute(query);

        }

        public int CheckID(int id)
        {
            DbData genericOperation = new DbData();
            string query = $"select count(*) from Restaurant where IdRestaurant = {id}";

            return genericOperation.Execute(query);
        }
    }
}
