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
using System.Windows.Markup;
using System.Xml.Schema;

namespace Restaurant_Manager
{
    public partial class FrmStats : Form
    {
        bool clear = false; //Variabile che ripulisce le serie dei grafici e le liste di dati prima di disegnare il nuovo grafico
        bool threeDEnabled = false;
        const int INCOMESCALE = 100, CUSTOMERSCALE = 5;
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
            FillTypesCharts();

            //Pagina 3
            PrepareComboBox(cmbMonth3);
            AssignTitle(chartCityIncome,chartCityCustomers);
            FillCitiesCharts();

        }

        private void cmbMonth3_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear = true;
            FillCitiesCharts();
        }

        private void btn2D3D_Click(object sender, EventArgs e)
        {
            EnableDisable3D();
        }

        private void cmbMonth2_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear = true;
            FillTypesCharts();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear = true; //In questo modo si evita un "accavallamento" delle serie
            FillRestaurantCharts();
        }

        private void FillSinglePieChart(ref bool clear, DataTable dt, Chart chartName, string title)
        {
            List<string> names = new List<string>();
            List<int> values = new List<int>();
            Series series = new Series();

            if (clear) //Se erano presenti altri dati, prima viene pulito il grafico
            {
                names.Clear();
                values.Clear();
                chartName.Series.Clear();
            }

            series = new Series(title);
            chartName.Series.Add(series);

            for (int i = 0; i < dt.Rows.Count; i++) //Inserimento dei dati all'interno delle liste
            {
                names.Add(dt.Rows[i][0].ToString());
                values.Add(Convert.ToInt32(dt.Rows[i][1]));

            }

            if (threeDEnabled)
                chartName.ChartAreas[0].Area3DStyle.Enable3D = true;

            else
                chartName.ChartAreas[0].Area3DStyle.Enable3D = false;

            //Design del grafico
            chartName.Series[0].ChartType = SeriesChartType.Pie;
            chartName.Series[0].IsValueShownAsLabel= true;
            chartName.Series[0].Font = new System.Drawing.Font("Rockwell", 18);
            chartName.Series[0].Points.DataBindXY(names, values);
            chartName.Legends[0].Enabled = true;
            
        }

        private void FillSingleBarChart(ref bool clear, DataTable dt, Chart chartName, string title, int scale)
        {
            List<string> names = new List<string>();
            List<int> values = new List<int>();
            Series series = new Series();

            if (clear) //Se erano presenti altri dati, prima viene pulito il grafico
            {
                names.Clear();
                values.Clear();
                chartName.Series.Clear();
            }

            for (int i = 0; i < dt.Rows.Count; i++) //Inserimento dei nomi e dei valori all'interno delle liste 
            {
                names.Add(dt.Rows[i][0].ToString());
                values.Add(Convert.ToInt32(dt.Rows[i][1]));
            }

            
            chartName.ChartAreas[0].AxisY.Interval = scale;
            chartName.ChartAreas[0].AxisY.Minimum = 0;

            //Controllo che verifica il valore massimo da mostrare sull'asse Y
            if(values.Count > 0)
                chartName.ChartAreas[0].AxisY.Maximum = values.Max() + 10;

            else
                chartName.ChartAreas[0].AxisY.Maximum = 0;

            for (int i = 0; i < dt.Rows.Count; i++) //Creazione e inserimento della serie nel grafico
            {
                string xAxisValue = names[i];
                int yAxisValue = values[i];
                series = new Series(xAxisValue, yAxisValue);

                if (threeDEnabled)
                    chartName.ChartAreas[0].Area3DStyle.Enable3D = true;

                else
                    chartName.ChartAreas[0].Area3DStyle.Enable3D = false;

                chartName.Series.Add(series);
                chartName.Series[xAxisValue].Points.AddXY(title, yAxisValue);
                chartName.Series[xAxisValue].Label = yAxisValue.ToString();
                chartName.Series[xAxisValue].Font = new System.Drawing.Font("Rockwell", 16);
            }

            clear = false;
        }

        private void FillRestaurantCharts()
        {
            BsStats bsStats = new BsStats();
            DataTable dt = new DataTable();

            clear = true;

            dt = bsStats.GetRestaurantsIncome(cmbMonth.SelectedIndex + 1);
            FillSingleBarChart(ref clear, dt, chartRestIncome, "Ristoranti", INCOMESCALE);

            clear = true;

            dt = bsStats.GetRestaurantsCustomers(cmbMonth.SelectedIndex + 1);
            FillSingleBarChart(ref clear, dt, chartRestCustomers, "Ristoranti", CUSTOMERSCALE);
        }

        private void FillTypesCharts()
        {
            BsStats bsStats = new BsStats();
            DataTable dt = new DataTable();

            clear = true;

            dt = bsStats.GetTypesIncome(cmbMonth2.SelectedIndex + 1);
            FillSinglePieChart(ref clear, dt, chartTypeIncome, "Tipo Ristorante");

            clear = true;

            dt = bsStats.GetTypesCustomers(cmbMonth2.SelectedIndex + 1);
            FillSinglePieChart(ref clear, dt, chartTypeCustomers, "Tipo Ristorante");
        }

        private void FillCitiesCharts()
        {
            BsStats bsStats = new BsStats();
            DataTable dt = new DataTable();

            clear = true;

            dt = bsStats.GetCitiesIncome(cmbMonth3.SelectedIndex + 1);
            FillSingleBarChart(ref clear, dt, chartCityIncome, "Città", INCOMESCALE);
            
            clear = true;
            
            dt = bsStats.GetCitiesCustomers(cmbMonth3.SelectedIndex + 1);
            FillSingleBarChart(ref clear, dt, chartCityCustomers, "Città", CUSTOMERSCALE);
        }

        private void AssignTitle(Chart chartIncome, Chart chartCustomers) //Inserisce i titoli all'interno dei grafici
        {

            chartIncome.Titles.Add(EditTitle("Incasso (€)"));
            chartCustomers.Titles.Add(EditTitle("Numero Clienti"));
        }

        private Title EditTitle(string title)
        {
            //Design del titolo
            Title chartTitle = new Title();
            chartTitle.Font = new Font("Rockwell", 18, FontStyle.Underline);
            chartTitle.Text = title;

            return chartTitle;
        }

        private void PrepareComboBox(ComboBox comboBox) //Impedisce la scrittura all'interno e setta di default il primo valore
        {
            //Setta la ComboBox sul mese corrente
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void EnableDisable3D()
        {
            if (threeDEnabled)
                threeDEnabled = false;

            else
                threeDEnabled = true;

            FillRestaurantCharts();
            FillTypesCharts();
            FillCitiesCharts();
        }


    }
}
