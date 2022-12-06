
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
        public bool IsValid(Restaurant restaurant, ref string message, ref string title, bool edit) //La variabile "edit" viene definita a seconda dell'azione (il suo valore sarà "true" se è stato cliccato il bottone "Modifica")
        {
            DsRestaurant restaurantData = new DsRestaurant();
            title = "Gestione Ristorante";

            if (restaurant.BusinessName.Length == 0 || restaurant.Street.Length == 0 || restaurant.City.Length == 0)
            {
                message = "Compilare tutti i campi di input";
                return false;
            }

            if(restaurantData.CheckUniqueProperty(restaurant) != 0 && !edit) //verifica che il nuovo ristorante non abbia gli stessi dati di uno esistente
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
                //QUAAAAAA
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

        public DataTable ReadName()
        {
            DataTable restNameTable = new DataTable();
            DsRestaurant restaurantData = new DsRestaurant();

            restNameTable = restaurantData.ReadName();

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

        public bool CheckID(int id)
        {
            DsRestaurant restaurantData = new DsRestaurant();
            
            if(restaurantData.CheckID(id) == 1)
                return true;

            return false;
        }
    }
}
