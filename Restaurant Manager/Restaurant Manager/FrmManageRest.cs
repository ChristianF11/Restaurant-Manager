using Business_layer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager
{
    public partial class FrmManageRest : Form
    {
        private Restaurant entity;
        private int idSelected;
        private bool edit;
        public FrmManageRest()
        {
            InitializeComponent();
            edit = false;
        }

        public FrmManageRest(int idSelected, Restaurant entity)
        {
            InitializeComponent();
            this.idSelected = idSelected;
            this.entity = entity;
            edit = true;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();   
        }

 
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveElement();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            if (!edit)
                bsRestaurant.ClearFields(ref cmbType, ref txtName, ref txtIva, ref txtStreet, ref txtCity, ref txtTelephone, ref valueSeats, ref valueAvgPrice);

            else
                ExecuteLoadProcedures();

        }

        private void FrmManageRest_Load(object sender, EventArgs e)
        {
            ExecuteLoadProcedures();
        }

        private void SaveElement()
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            string message = "";
            string title = "";

            Restaurant entityRestaurant = bsRestaurant.CreateEntity(cmbType.SelectedIndex + 1, (int)valueSeats.Value, (int)valueAvgPrice.Value, txtName.Text, txtIva.Text, txtStreet.Text, txtCity.Text, txtTelephone.Text);
            if (edit)
                entityRestaurant.IdRestaurant = entity.IdRestaurant;

            if (!bsRestaurant.IsValid(entityRestaurant, ref message, ref title, edit))
            {
                OperationMessage.GetCustomError(message, title);
            }
            else
            {
                if (message.Length > 0)
                    OperationMessage.GetCustomWarning(message, "Modifica posti");

                try
                {
                    if (edit)
                    {
                        bsRestaurant.Update(entityRestaurant, idSelected, ref message);
                        OperationMessage.GetCustomMessage(message, "Modifica ristorante");
                    }

                    else
                    {
                        bsRestaurant.Create(entityRestaurant, ref message);
                        OperationMessage.GetCustomMessage(message, "Nuovo ristorante");
                    }

                    if(!edit)
                        bsRestaurant.ClearFields(ref cmbType, ref txtName, ref txtIva, ref txtStreet, ref txtCity, ref txtTelephone, ref valueSeats, ref valueAvgPrice);

                }

                catch (Exception ex)
                {
                    OperationMessage.GetGenericError();
                }
            }
        }
        private void ExecuteLoadProcedures()
        {
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;

            //Il form viene precompilato con i dati già inseriti (se in modalità modifica)
            if(edit)
            {
                cmbType.SelectedIndex = entity.Type - 1;
                txtName.Text = entity.BusinessName;
                txtIva.Text = entity.PIva;
                txtStreet.Text = entity.Street;
                txtCity.Text = entity.City;
                txtTelephone.Text = entity.TelephoneNum;
                valueAvgPrice.Value = (decimal)entity.AvgPrice;
                valueSeats.Value = entity.Seats;
            }

            else
                cmbType.SelectedIndex = 0;
        }


    }
}
