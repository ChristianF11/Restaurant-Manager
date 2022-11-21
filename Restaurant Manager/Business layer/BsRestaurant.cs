using Data_layer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_layer
{
    public class BsRestaurant
    {
        public bool IsValid(Restaurant restaurant, ref string message, ref string title)
        {
            DsRestaurant restaurantData = new DsRestaurant();
            title = "Gestione Ristorante";

            if (restaurant.BusinessName.Length == 0 || restaurant.Street.Length == 0 || restaurant.City.Length == 0)
            {
                message = "Compilare tutti i campi di input";
                return false;
            }

            if(restaurantData.CheckUniqueProperty(restaurant) != 0) //verifica che il nuovo ristorante non abbia gli stessi dati di uno esistente
            {
                message = "A quanto pare questo ristorante è già esistente o alcuni dati sono già stati utilizzati";
                return false;
            }

            if (restaurant.PIva.Length != 11 || !long.TryParse(restaurant.PIva, out long pIva))
            {
                message = "Partita IVA non valida";
                return false;
            }

            if (restaurant.TelephoneNum.Length != 10 || !uint.TryParse(restaurant.TelephoneNum, out uint telephoneNum))
            {
                message = "Numero di telefono non valido";
                return false;
            }

            if (restaurant.Type < 1 || restaurant.Type > 5)
            {
                message = "Tipo di ristorante non valido";
                return false;
            }

            if (restaurant.Seats < 0)
            {
                message = "Inserire un numero di posti valido";
                return false;
            }

            if (restaurant.AvgPrice < 0)
            {
                message = "Inserire un prezzo medio valido";
                return false;
            }

            return true;
        }

        public Restaurant CreateEntity(int type, int seats, double avgPrice, string name, string pIva, string street, string city, string phoneNum)
        {
            Restaurant rest = new Restaurant(type,seats,avgPrice,name,pIva,street,city,phoneNum);

            return rest;
        }

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

        //Ripulisce i campi di input destinati alla creeazione di un ristorante
        public void ClearFields(ref ComboBox cmbType, ref TextBox txtName, ref TextBox txtIva, ref TextBox txtStreet, ref TextBox txtCity, ref TextBox txtTelephone, 
            ref NumericUpDown valueSeats, ref NumericUpDown valueAvgPrice)
        {
            cmbType.Text = string.Empty;
            txtName.Text = string.Empty;
            txtIva.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            valueSeats.Text = "0";
            valueAvgPrice.Text = "0";
        }

    }
}
