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
            DateTime request = dateTimePicker1.Value;
            DateTime rsvDate = dateTimePicker2.Value;

            BsReservation r = new BsReservation();
            Reservation res = new Reservation(3,"christian11",21,request,rsvDate);

            if (r.IsValid(res))
                r.Create(res);

            else
                MessageBox.Show("Errore");

            dataGridView1.DataSource = r.Read();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BsReservation bs = new BsReservation();
            bs.Delete(24);
            bs.Delete(25);
            dataGridView1.DataSource = bs.Read();
        }
    }
}
