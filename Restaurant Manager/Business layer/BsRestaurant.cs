
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
        //La variabile "edit" viene definita a seconda dell'azione (il suo valore sarà "true" se è stato cliccato il bottone "Modifica")
        public bool IsValid(Restaurant restaurant, ref string message, ref string title, bool edit) 
        {
            DsRestaurant restaurantData = new DsRestaurant();
            title = "Gestione Ristorante";

            if (restaurant.BusinessName.Length == 0 || restaurant.Street.Length == 0 || restaurant.City.Length == 0)
            {
                message = "Compilare tutti i campi di input";
                return false;
            }

            if(restaurantData.CheckUniqueProperty(restaurant) > 1) //verifica che il nuovo ristorante non abbia gli stessi dati di uno esistente
            {
                message = "A quanto pare questo ristorante è già esistente o alcuni dati sono già stati utilizzati";
                return false;
            }

            //Verifica che la partita IVA sia composta da 11 numeri
            if (restaurant.PIva.Length != 11 || !long.TryParse(restaurant.PIva, out long pIva) && !restaurant.PIva.Contains(" "))
            {
                message = "Partita IVA non valida";
                return false;
            }

            //Verifica che il numero di telefono sia composto da 10 numeri
            if (restaurant.TelephoneNum.Length != 10 || !uint.TryParse(restaurant.TelephoneNum, out uint telephoneNum) && !restaurant.TelephoneNum.Contains(" "))
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

            if(edit && restaurant.Seats < restaurantData.GetSeats(restaurant.IdRestaurant))
            {
                message = "Sembra che tu abbia ridotto il numero di posti. Ti consiglio di ricontrollare le prenotazioni di questo ristorante per evitare di sforare con i clienti";
                return true;
            }

            return true;
        }

        public Restaurant CreateEntity(int type, int seats, double avgPrice, string name, string pIva, string street, string city, string phoneNum)
        {
            Restaurant rest = new Restaurant(type,seats,avgPrice,name,pIva,street,city,phoneNum);

            return rest;
        }

        public Restaurant CreateEntity(int idRestaurant,int type, int seats, double avgPrice, string name, string pIva, string street, string city, string phoneNum)
        {
            Restaurant rest = new Restaurant(idRestaurant,type,seats,avgPrice,name,pIva,street,city,phoneNum);

            return rest;
        }

        public void Create(Restaurant restaurant, ref string message) 
        {
            //Metodo che inserisce il ristorante nel db
            DbData dbData = new DbData();
            DsRestaurant restaurantData = new DsRestaurant();

            dbData.Open();
            try
            {
                restaurantData.Create(restaurant,dbData);
                message = "Operazione andata a buon fine";
            }
            catch(Exception ex)
            {
                message = "Ops! Qualcosa è andato storto";
            }
            dbData.Close();
        }

        public DataTable Read(string name,string city,int type, string selectedOrder)
        {
            DataTable dtRestaurant = new DataTable();
            DsRestaurant restaurantData = new DsRestaurant();
            string restType = "";

            if (type == 0)
                restType = "1-5";

            else
                restType = Convert.ToString(type);

            if (selectedOrder == "**Nessun Filtro**")
                selectedOrder = "'ID'";

            else if (selectedOrder == "Prezzo Medio")
                selectedOrder = "AveragePrice";

            else
                selectedOrder = $"'{selectedOrder}'";

            dtRestaurant = restaurantData.Read(name,city,restType,selectedOrder);

            return dtRestaurant;

        }

        public DataTable ReadName(string city)
        {
            DataTable restNameTable = new DataTable();
            DsRestaurant restaurantData = new DsRestaurant();

            restNameTable = restaurantData.ReadName(city);

            return restNameTable;
        }

        public void Update(Restaurant restaurant, int id, ref string message)
        {
            DbData dbData = new DbData();
            DsRestaurant restaurantData = new DsRestaurant();

            dbData.Open();
            try
            {
                restaurantData.Update(restaurant, id,dbData);
                message = "Operazione andata a buon fine";
            }
            catch(Exception ex)
            {
                message = "Ops! Qualcosa è andato storto";
            }
            dbData.Close();
        }

        public void Delete(int id,ref string message) 
        {
            DbData dbData = new DbData();
            DsRestaurant restaurantData = new DsRestaurant();

            dbData.Open();
            try
            {
                restaurantData.Delete(id,dbData);
                message = "Elemento rimosso";
            }
            catch(Exception ex)
            {
                message = "Nessun ristorante selezionato";
            }
            dbData.Close();

        }

        //Ripulisce i campi di input destinati alla creeazione di un ristorante
        public void ClearFields(ref ComboBox cmbType, ref TextBox txtName, ref TextBox txtIva, ref TextBox txtStreet, ref TextBox txtCity, ref TextBox txtTelephone, 
            ref NumericUpDown valueSeats, ref NumericUpDown valueAvgPrice)
        {
            cmbType.SelectedIndex = 0;
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
