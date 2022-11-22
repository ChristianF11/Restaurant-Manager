using Data_layer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_layer
{
    public class BsCustomer
    {
        public bool IsValid(Customer customer, ref string message, ref string title, bool edit)
        {
            DsCustomer customerData = new DsCustomer();
            title = "Gestione Cliente";

            if (customer.Username.Length == 0 || customer.Password.Length == 0 || customer.Info.Length == 0 || customer.Email.Length == 0 || customer.City.Length == 0)
            {
                message = "Compilare tutti i campi di input";
                return false;
            }

            //Verifica se lo username è già stato utilizzato
            if (customerData.CheckUsername(customer.Username) != 0 && !edit)
            {
                message = "Sembra che questo username sia già stato utilizzato";
                return false;
            }

            if (customer.PhoneNum.Length != 10 || !uint.TryParse(customer.PhoneNum, out uint result))
            {
                message = "Numero di telefono non valido";
                return false;
            }

            return true;
        }

        public Customer CreateEntity(string username, string password, bool isAdmin, string info, string phoneNum, string email, string city)
        {
            Customer customer = new Customer(username,password,info,phoneNum,email,city,isAdmin);

            return customer;
        }

        public void Create(Customer customer)
        {
            DsCustomer customerData = new DsCustomer();
            customerData.Create(customer);
        }

        public DataTable Read()
        {
            DataTable dtCustomer = new DataTable();
            DsCustomer customerData = new DsCustomer();
            dtCustomer = customerData.Read();

            return dtCustomer;
        }

        public void Update(Customer customer)
        {
            DsCustomer customerData = new DsCustomer();
            customerData.Update(customer);
        }

        public void Delete(string username, ref string message)
        {
            try
            {
                DsCustomer customerData = new DsCustomer();
                customerData.Delete(username);
                message = "Utente rimosso";
            }

            catch(Exception ex)
            {
                message = "Nessun utente selezionato";
            }
        }

        public void ClearFields(ref TextBox txtUsername, ref TextBox txtPassword, ref TextBox txtCity, ref TextBox txtPhoneNum, ref TextBox txtEmail, 
            ref RichTextBox rtxtInfo, ref CheckBox cmbIsAdmin)
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPhoneNum.Text = string.Empty;
            txtEmail.Text = string.Empty;
            rtxtInfo.Text = string.Empty;
            cmbIsAdmin.Checked = false;

        }
    }
}
