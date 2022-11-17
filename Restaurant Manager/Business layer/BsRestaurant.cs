using Data_layer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business_layer
{
    public class BsRestaurant
    {
        public bool IsValid(Restaurant restaurant)
        {
            DsRestaurant restaurantData = new DsRestaurant();

            if (restaurant.BusinessName.Length == 0 || restaurant.Street.Length == 0 || restaurant.City.Length == 0)
                return false;

            if(restaurantData.CheckUniqueProperty(restaurant) != 0) //verifica che il nuovo ristorante non abbia gli stessi dati di uno esistente
                return false;

            if (restaurant.PIva.Length != 11 || !long.TryParse(restaurant.PIva, out long pIva))
                return false;

            if (restaurant.TelephoneNum.Length != 10 || !uint.TryParse(restaurant.TelephoneNum, out uint telephoneNum))
                return false;

            if (restaurant.Type < 1 || restaurant.Type > 5)
                return false;

            if (restaurant.Seats < 0)
                return false;

            if (restaurant.AvgPrice < 0)
                return false;

            return true;
        }

        /*public Restaurant Create(parametri inseriti in UI)
        {
            //Metodo che crea un oggetto di tipo "Restaurant"
        }*/
        public void Create(Restaurant restaurant) 
        {
            //Metodo che inserisce il ristorante nel db
            DsRestaurant restaurantData = new DsRestaurant();
            restaurantData.Create(restaurant);

        }

        public DataTable Read()
        {
            DataTable dtRestaurant = new DataTable();
            DsRestaurant restaurantData = new DsRestaurant();
            dtRestaurant = restaurantData.Read();

            return dtRestaurant;

        }

        public void Update(Restaurant restaurant, int id)
        {
            DsRestaurant restaurantData = new DsRestaurant();
            restaurantData.Update(restaurant, id);
        }

        public void Delete(int id) 
        {
            DsRestaurant restaurantData = new DsRestaurant();
            restaurantData.Delete(id);
        }
    }
}
