using Business_layer;
using Entities;
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
    public partial class Form1 : Form
    {
        //IL RIFERIMENTO alle ENTITIES verrà RIMOSSO nel momento in cui termineranno i test nel Business layer
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Restaurant res = new Restaurant(3, 30, 50, "COTTOletta", "12345678900", "Via del mangiare", "Bologna", "3497569981");
            BsRestaurant br = new BsRestaurant();

            if(br.IsValid(res))
            {
                br.Create(res);
            }

            else
            {
                MessageBox.Show("Errore");
            }

            dataGridView1.DataSource = br.Read();
        }

    }
}
