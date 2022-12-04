﻿namespace Restaurant_Manager
{
    partial class FrmStats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStats));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.restaurantDBDataSet1 = new Restaurant_Manager.restaurantDBDataSet();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btn2D3D = new System.Windows.Forms.ToolStripButton();
            this.tabCity = new System.Windows.Forms.TabPage();
            this.cmbMonth3 = new System.Windows.Forms.ComboBox();
            this.chartCityCustomers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCityIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabType = new System.Windows.Forms.TabPage();
            this.chartTypeCustomers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbMonth2 = new System.Windows.Forms.ComboBox();
            this.chartTypeIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabRestaurant = new System.Windows.Forms.TabPage();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.chartRestIncome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartRestCustomers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabStats = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDBDataSet1)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.tabCity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCityCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCityIncome)).BeginInit();
            this.tabType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTypeCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTypeIncome)).BeginInit();
            this.tabRestaurant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRestIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRestCustomers)).BeginInit();
            this.tabStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // restaurantDBDataSet1
            // 
            this.restaurantDBDataSet1.DataSetName = "restaurantDBDataSet";
            this.restaurantDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btn2D3D});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(1145, 27);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "Azioni";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 24);
            this.btnBack.Text = "Indietro";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn2D3D
            // 
            this.btn2D3D.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2D3D.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2D3D.Image = global::Restaurant_Manager.Properties.Resources.icons8_3d_object_96;
            this.btn2D3D.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn2D3D.Name = "btn2D3D";
            this.btn2D3D.Size = new System.Drawing.Size(64, 24);
            this.btn2D3D.Text = "2D/3D";
            this.btn2D3D.Click += new System.EventHandler(this.btn2D3D_Click);
            // 
            // tabCity
            // 
            this.tabCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.tabCity.Controls.Add(this.cmbMonth3);
            this.tabCity.Controls.Add(this.chartCityCustomers);
            this.tabCity.Controls.Add(this.chartCityIncome);
            this.tabCity.Location = new System.Drawing.Point(4, 22);
            this.tabCity.Name = "tabCity";
            this.tabCity.Padding = new System.Windows.Forms.Padding(3);
            this.tabCity.Size = new System.Drawing.Size(1115, 552);
            this.tabCity.TabIndex = 2;
            this.tabCity.Text = "Per Città";
            // 
            // cmbMonth3
            // 
            this.cmbMonth3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbMonth3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth3.FormattingEnabled = true;
            this.cmbMonth3.Items.AddRange(new object[] {
            "Gennaio",
            "Febbraio",
            "Marzo",
            "Aprile",
            "Maggio",
            "Giugno",
            "Luglio",
            "Agosto",
            "Settembre",
            "Ottobre",
            "Novembre",
            "Dicembre"});
            this.cmbMonth3.Location = new System.Drawing.Point(6, 15);
            this.cmbMonth3.MaximumSize = new System.Drawing.Size(211, 0);
            this.cmbMonth3.MinimumSize = new System.Drawing.Size(211, 0);
            this.cmbMonth3.Name = "cmbMonth3";
            this.cmbMonth3.Size = new System.Drawing.Size(211, 34);
            this.cmbMonth3.TabIndex = 2;
            this.cmbMonth3.SelectedIndexChanged += new System.EventHandler(this.cmbMonth3_SelectedIndexChanged);
            // 
            // chartCityCustomers
            // 
            this.chartCityCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartCityCustomers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCityCustomers.Legends.Add(legend1);
            this.chartCityCustomers.Location = new System.Drawing.Point(581, 56);
            this.chartCityCustomers.Name = "chartCityCustomers";
            this.chartCityCustomers.Size = new System.Drawing.Size(516, 492);
            this.chartCityCustomers.TabIndex = 1;
            this.chartCityCustomers.Text = "chart2";
            // 
            // chartCityIncome
            // 
            this.chartCityIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartCityIncome.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartCityIncome.Legends.Add(legend2);
            this.chartCityIncome.Location = new System.Drawing.Point(6, 56);
            this.chartCityIncome.Name = "chartCityIncome";
            this.chartCityIncome.Size = new System.Drawing.Size(516, 492);
            this.chartCityIncome.TabIndex = 0;
            this.chartCityIncome.Text = "chart1";
            // 
            // tabType
            // 
            this.tabType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.tabType.Controls.Add(this.chartTypeCustomers);
            this.tabType.Controls.Add(this.cmbMonth2);
            this.tabType.Controls.Add(this.chartTypeIncome);
            this.tabType.Location = new System.Drawing.Point(4, 22);
            this.tabType.Name = "tabType";
            this.tabType.Padding = new System.Windows.Forms.Padding(3);
            this.tabType.Size = new System.Drawing.Size(1115, 552);
            this.tabType.TabIndex = 1;
            this.tabType.Text = "Per Tipologia";
            // 
            // chartTypeCustomers
            // 
            this.chartTypeCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartTypeCustomers.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTypeCustomers.Legends.Add(legend3);
            this.chartTypeCustomers.Location = new System.Drawing.Point(581, 56);
            this.chartTypeCustomers.MaximumSize = new System.Drawing.Size(800, 0);
            this.chartTypeCustomers.MinimumSize = new System.Drawing.Size(516, 492);
            this.chartTypeCustomers.Name = "chartTypeCustomers";
            this.chartTypeCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chartTypeCustomers.Size = new System.Drawing.Size(516, 492);
            this.chartTypeCustomers.TabIndex = 5;
            this.chartTypeCustomers.Text = "chart1";
            title1.Name = "Incasso mensile";
            this.chartTypeCustomers.Titles.Add(title1);
            // 
            // cmbMonth2
            // 
            this.cmbMonth2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbMonth2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth2.FormattingEnabled = true;
            this.cmbMonth2.Items.AddRange(new object[] {
            "Gennaio",
            "Febbraio",
            "Marzo",
            "Aprile",
            "Maggio",
            "Giugno",
            "Luglio",
            "Agosto",
            "Settembre",
            "Ottobre",
            "Novembre",
            "Dicembre"});
            this.cmbMonth2.Location = new System.Drawing.Point(6, 15);
            this.cmbMonth2.MaximumSize = new System.Drawing.Size(211, 0);
            this.cmbMonth2.MinimumSize = new System.Drawing.Size(211, 0);
            this.cmbMonth2.Name = "cmbMonth2";
            this.cmbMonth2.Size = new System.Drawing.Size(211, 34);
            this.cmbMonth2.TabIndex = 1;
            this.cmbMonth2.SelectedIndexChanged += new System.EventHandler(this.cmbMonth2_SelectedIndexChanged);
            // 
            // chartTypeIncome
            // 
            this.chartTypeIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartTypeIncome.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTypeIncome.Legends.Add(legend4);
            this.chartTypeIncome.Location = new System.Drawing.Point(6, 56);
            this.chartTypeIncome.MaximumSize = new System.Drawing.Size(800, 0);
            this.chartTypeIncome.MinimumSize = new System.Drawing.Size(516, 492);
            this.chartTypeIncome.Name = "chartTypeIncome";
            this.chartTypeIncome.Size = new System.Drawing.Size(516, 492);
            this.chartTypeIncome.TabIndex = 0;
            this.chartTypeIncome.Text = "chart1";
            // 
            // tabRestaurant
            // 
            this.tabRestaurant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.tabRestaurant.Controls.Add(this.cmbMonth);
            this.tabRestaurant.Controls.Add(this.chartRestIncome);
            this.tabRestaurant.Controls.Add(this.chartRestCustomers);
            this.tabRestaurant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabRestaurant.Location = new System.Drawing.Point(4, 22);
            this.tabRestaurant.Name = "tabRestaurant";
            this.tabRestaurant.Padding = new System.Windows.Forms.Padding(3);
            this.tabRestaurant.Size = new System.Drawing.Size(1115, 552);
            this.tabRestaurant.TabIndex = 0;
            this.tabRestaurant.Text = "Per Ristorante";
            // 
            // cmbMonth
            // 
            this.cmbMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbMonth.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Gennaio",
            "Febbraio",
            "Marzo",
            "Aprile",
            "Maggio",
            "Giugno",
            "Luglio",
            "Agosto",
            "Settembre",
            "Ottobre",
            "Novembre",
            "Dicembre"});
            this.cmbMonth.Location = new System.Drawing.Point(6, 16);
            this.cmbMonth.MaximumSize = new System.Drawing.Size(211, 0);
            this.cmbMonth.MinimumSize = new System.Drawing.Size(211, 0);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(211, 34);
            this.cmbMonth.TabIndex = 0;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // chartRestIncome
            // 
            this.chartRestIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chartRestIncome.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartRestIncome.Legends.Add(legend5);
            this.chartRestIncome.Location = new System.Drawing.Point(6, 56);
            this.chartRestIncome.MinimumSize = new System.Drawing.Size(516, 492);
            this.chartRestIncome.Name = "chartRestIncome";
            this.chartRestIncome.Size = new System.Drawing.Size(516, 492);
            this.chartRestIncome.TabIndex = 5;
            this.chartRestIncome.Text = "chart1";
            title2.Name = "Incasso mensile";
            this.chartRestIncome.Titles.Add(title2);
            // 
            // chartRestCustomers
            // 
            this.chartRestCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.chartRestCustomers.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartRestCustomers.Legends.Add(legend6);
            this.chartRestCustomers.Location = new System.Drawing.Point(581, 56);
            this.chartRestCustomers.MinimumSize = new System.Drawing.Size(516, 492);
            this.chartRestCustomers.Name = "chartRestCustomers";
            this.chartRestCustomers.Size = new System.Drawing.Size(516, 492);
            this.chartRestCustomers.TabIndex = 4;
            this.chartRestCustomers.Text = "chart2";
            // 
            // tabStats
            // 
            this.tabStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabStats.Controls.Add(this.tabRestaurant);
            this.tabStats.Controls.Add(this.tabType);
            this.tabStats.Controls.Add(this.tabCity);
            this.tabStats.Location = new System.Drawing.Point(12, 30);
            this.tabStats.Name = "tabStats";
            this.tabStats.SelectedIndex = 0;
            this.tabStats.Size = new System.Drawing.Size(1123, 578);
            this.tabStats.TabIndex = 0;
            // 
            // FrmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Restaurant_Manager.Properties.Resources.StatisticheNew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 618);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.tabStats);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1154, 657);
            this.Name = "FrmStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiche";
            this.Load += new System.EventHandler(this.FrmStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDBDataSet1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.tabCity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCityCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCityIncome)).EndInit();
            this.tabType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTypeCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTypeIncome)).EndInit();
            this.tabRestaurant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRestIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRestCustomers)).EndInit();
            this.tabStats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private restaurantDBDataSet restaurantDBDataSet1;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btn2D3D;
        private System.Windows.Forms.TabPage tabCity;
        private System.Windows.Forms.ComboBox cmbMonth3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCityCustomers;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCityIncome;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTypeCustomers;
        private System.Windows.Forms.ComboBox cmbMonth2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTypeIncome;
        private System.Windows.Forms.TabPage tabRestaurant;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRestIncome;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRestCustomers;
        private System.Windows.Forms.TabControl tabStats;
    }
}