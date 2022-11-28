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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Schema;

namespace Restaurant_Manager
{
    public partial class FrmStats : Form
    {
        bool clear = false;
        public FrmStats()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmStats_Load(object sender, EventArgs e)
        {
            //Pagina 1
            PrepareComboBox(cmbMonth);
            AssignTitle(chartRestIncome,chartRestCustomers);
            FillRestaurantCharts();

            //Pagina 2
            PrepareComboBox(cmbMonth2);
            AssignTitle(chartTypeIncome,chartTypeCustomers);
            //Metodo Fill()

            //Pagina 3
            PrepareComboBox(cmbMonth3);
            AssignTitle(chartCityIncome,chartCityCustomers);
            //Metodo Fill()

        }

        private void FillSingleChart(ref bool clear, DataTable dt, Chart chartRestaurant)
        {
            List<string> names = new List<string>();
            List<int> values = new List<int>();
            Series seriesRestaurant = new Series();

            if(clear)
            {
                names.Clear();
                values.Clear();
                chartRestIncome.Series.Clear();
                chartRestCustomers.Series.Clear();
            }
            
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                names.Add(dt.Rows[i][0].ToString());
                values.Add(Convert.ToInt32(dt.Rows[i][1]));
            }

            for(int i = 0; i < dt.Rows.Count; i++) 
            {
                string businessName = names[i];
                int yAxisValue = values[i];
                seriesRestaurant = new Series(businessName, yAxisValue);
                
                chartRestaurant.Series.Add(seriesRestaurant);
                chartRestaurant.Series[businessName].Points.AddXY("Ristoranti",yAxisValue);
            }

            clear = false;
        }

        private void FillRestaurantCharts()
        {
            BsStats bsStats = new BsStats();
            DataTable dt = new DataTable();

            dt = bsStats.RestaurantsIncome(cmbMonth.SelectedIndex + 1);
            FillSingleChart(ref clear, dt, chartRestIncome);

            dt = bsStats.RestaurantsCustomers(cmbMonth.SelectedIndex + 1);
            FillSingleChart(ref clear, dt, chartRestCustomers);
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear = true; //In questo modo si evita un "accavallamento" delle serie
            FillRestaurantCharts();
        }

        private void AssignTitle(Chart chartIncome, Chart chartCustomers) //Inserisce i titoli all'interno dei grafici
        {
            chartIncome.Titles.Add("Incasso (€)");
            chartCustomers.Titles.Add("Numero clienti");
        }

        private void PrepareComboBox(ComboBox comboBox) //Impedisce la scrittura all'interno e setta di default il primo valore
        {
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;
        }

    }
}
