using Business_layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Manager
{
    public partial class FrmManageRest : Form
    {
        private int idSelected;
        private bool edit;
        public FrmManageRest()
        {
            InitializeComponent();
            edit = false;
        }

        public FrmManageRest(int idSelected)
        {
            InitializeComponent();
            this.idSelected = idSelected;
            edit = true;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

 
        private void btnSave_Click(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            string message = "";
            string title = "";

            var entity = bsRestaurant.CreateEntity(cmbType.SelectedIndex + 1, (int)valueSeats.Value, (double)valueAvgPrice.Value, txtName.Text, txtIva.Text, txtStreet.Text, txtCity.Text, txtTelephone.Text);
            if (!bsRestaurant.IsValid(entity, ref message, ref title,edit))
            {
                OperationMessage.GetCustomError(message, title);
            }
            else
            {
                if(edit)
                {
                    bsRestaurant.Update(entity, idSelected);
                }

                else
                {
                    bsRestaurant.Create(entity);
                }

                OperationMessage.GetGenericMessage();
                bsRestaurant.ClearFields(ref cmbType, ref txtName, ref txtIva, ref txtStreet, ref txtCity, ref txtTelephone, ref valueSeats, ref valueAvgPrice);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            bsRestaurant.ClearFields(ref cmbType, ref txtName, ref txtIva, ref txtStreet, ref txtCity, ref txtTelephone, ref valueSeats, ref valueAvgPrice);

        }

        private void FrmManageRest_Load(object sender, EventArgs e)
        {
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.SelectedIndex = 0;
        }
    }
}
