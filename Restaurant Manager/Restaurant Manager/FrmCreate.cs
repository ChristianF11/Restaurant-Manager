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
    public partial class FrmCreate : Form
    {
        public FrmCreate()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            bsRestaurant.ClearFields(ref cmbType, ref txtName, ref txtIva, ref txtStreet, ref txtCity, ref txtTelephone, ref valueSeats, ref valueAvgPrice);
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BsRestaurant bsRestaurant = new BsRestaurant();
            OperationMessage resultMessage = new OperationMessage();
            string message = "";
            string title = "";

            var entity = bsRestaurant.CreateEntity(cmbType.SelectedIndex + 1, (int)valueSeats.Value, (double)valueAvgPrice.Value, txtName.Text, txtIva.Text, txtStreet.Text, txtCity.Text, txtTelephone.Text);
            if(!bsRestaurant.IsValid(entity, ref message, ref title))
            {
                resultMessage.GetCustomError(message, title);
            }
            else
            {
                bsRestaurant.Create(entity);
                resultMessage.GetGenericMessage();
            }

        }

    }
}
