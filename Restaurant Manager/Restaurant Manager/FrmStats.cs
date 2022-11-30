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

        private void FillSinglePieChart(ref bool clear, DataTable dt, Chart chartName, string title)
        {
            List<string> names = new List<string>();
            List<int> values = new List<int>();
            Series series = new Series();

            if (clear)
            {
                names.Clear();
                values.Clear();
                chartName.Series.Clear();
            }

            series = new Series(title);
            chartName.Series.Add(series);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                names.Add(dt.Rows[i][0].ToString());
                values.Add(Convert.ToInt32(dt.Rows[i][1]));

            }

            if (threeDEnabled)
                chartName.ChartAreas[0].Area3DStyle.Enable3D = true;

            else
                chartName.ChartAreas[0].Area3DStyle.Enable3D = false;

            chartName.Series[0].ChartType = SeriesChartType.Pie;
            chartName.Series[0].IsValueShownAsLabel= true;
            chartName.Series[0].Points.DataBindXY(names, values);
            chartName.Legends[0].Enabled = true;
            
        }

        private void FillSingleBarChart(ref bool clear, DataTable dt, Chart chartName, string title)
        {
            List<string> names = new List<string>();
            List<int> values = new List<int>();
            Series series = new Series();

            if (clear)
            {
                names.Clear();
                values.Clear();
                chartName.Series.Clear();
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                names.Add(dt.Rows[i][0].ToString());
                values.Add(Convert.ToInt32(dt.Rows[i][1]));
            }

            chartName.ChartAreas[0].AxisY.Interval = 10;

            for (int i = 0; i < dt.Rows.Count; i++)
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
            }

            clear = false;
        }

        private void FillRestaurantCharts()
        {
            BsStats bsStats = new BsStats();
            DataTable dt = new DataTable();

            clear = true;

            dt = bsStats.GetRestaurantsIncome(cmbMonth.SelectedIndex + 1);
            FillSingleBarChart(ref clear, dt, chartRestIncome, "Ristoranti");

            clear = true;

            dt = bsStats.GetRestaurantsCustomers(cmbMonth.SelectedIndex + 1);
            FillSingleBarChart(ref clear, dt, chartRestCustomers, "Ristoranti");
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
            FillSingleBarChart(ref clear, dt, chartCityIncome, "Città");
            
            clear = true;
            
            dt = bsStats.GetCitiesCustomers(cmbMonth3.SelectedIndex + 1);
            FillSingleBarChart(ref clear, dt, chartCityCustomers, "Città");
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

        private void cmbMonth3_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear = true;
            FillCitiesCharts();
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

        private void btn2D3D_Click(object sender, EventArgs e)
        {
            EnableDisable3D();
        }

        private void cmbMonth2_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear = true;
            FillTypesCharts();
        }
    }
}
