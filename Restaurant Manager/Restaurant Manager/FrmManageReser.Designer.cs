namespace Restaurant_Manager
{
    partial class FrmManageReser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManageReser));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.lblRestaurants = new System.Windows.Forms.Label();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblSelectedRest = new System.Windows.Forms.Label();
            this.txtRestaurant = new System.Windows.Forms.TextBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.valueCustomers = new System.Windows.Forms.NumericUpDown();
            this.dgvRestaurants = new System.Windows.Forms.DataGridView();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbxCustomer = new System.Windows.Forms.ListBox();
            this.lbCustomers = new System.Windows.Forms.Label();
            this.lbxRestaurants = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurants)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.separator1,
            this.btnSave,
            this.btnCancel});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1151, 27);
            this.toolStrip.TabIndex = 22;
            this.toolStrip.Text = "Registra Cliente";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 24);
            this.btnBack.Text = "Indietro";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 24);
            this.btnSave.Text = "Salva";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 24);
            this.btnCancel.Text = "Annulla";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblRestaurants
            // 
            this.lblRestaurants.AutoSize = true;
            this.lblRestaurants.BackColor = System.Drawing.Color.Transparent;
            this.lblRestaurants.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurants.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRestaurants.Location = new System.Drawing.Point(23, 41);
            this.lblRestaurants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestaurants.Name = "lblRestaurants";
            this.lblRestaurants.Size = new System.Drawing.Size(116, 32);
            this.lblRestaurants.TabIndex = 23;
            this.lblRestaurants.Text = "Ristoranti";
            // 
            // txtSeats
            // 
            this.txtSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeats.Location = new System.Drawing.Point(29, 466);
            this.txtSeats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.ReadOnly = true;
            this.txtSeats.Size = new System.Drawing.Size(121, 30);
            this.txtSeats.TabIndex = 26;
            this.txtSeats.TabStop = false;
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.BackColor = System.Drawing.Color.Transparent;
            this.lblSeats.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSeats.Location = new System.Drawing.Point(24, 432);
            this.lblSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(124, 32);
            this.lblSeats.TabIndex = 27;
            this.lblSeats.Text = "Posti liberi";
            // 
            // lblSelectedRest
            // 
            this.lblSelectedRest.AutoSize = true;
            this.lblSelectedRest.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedRest.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedRest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSelectedRest.Location = new System.Drawing.Point(23, 343);
            this.lblSelectedRest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedRest.Name = "lblSelectedRest";
            this.lblSelectedRest.Size = new System.Drawing.Size(122, 32);
            this.lblSelectedRest.TabIndex = 31;
            this.lblSelectedRest.Text = "Ristorante";
            // 
            // txtRestaurant
            // 
            this.txtRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestaurant.Location = new System.Drawing.Point(29, 380);
            this.txtRestaurant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRestaurant.Name = "txtRestaurant";
            this.txtRestaurant.ReadOnly = true;
            this.txtRestaurant.Size = new System.Drawing.Size(261, 30);
            this.txtRestaurant.TabIndex = 30;
            this.txtRestaurant.TabStop = false;
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomers.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCustomers.Location = new System.Drawing.Point(819, 224);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(133, 32);
            this.lblCustomers.TabIndex = 33;
            this.lblCustomers.Text = "N° Persone";
            // 
            // valueCustomers
            // 
            this.valueCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueCustomers.Location = new System.Drawing.Point(825, 272);
            this.valueCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.valueCustomers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueCustomers.Name = "valueCustomers";
            this.valueCustomers.Size = new System.Drawing.Size(179, 30);
            this.valueCustomers.TabIndex = 36;
            this.valueCustomers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueCustomers.ValueChanged += new System.EventHandler(this.valueCustomers_ValueChanged);
            // 
            // dgvRestaurants
            // 
            this.dgvRestaurants.AllowUserToAddRows = false;
            this.dgvRestaurants.AllowUserToDeleteRows = false;
            this.dgvRestaurants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRestaurants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRestaurants.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.dgvRestaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurants.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvRestaurants.Location = new System.Drawing.Point(28, 75);
            this.dgvRestaurants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRestaurants.MultiSelect = false;
            this.dgvRestaurants.Name = "dgvRestaurants";
            this.dgvRestaurants.ReadOnly = true;
            this.dgvRestaurants.RowHeadersWidth = 51;
            this.dgvRestaurants.RowTemplate.Height = 24;
            this.dgvRestaurants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRestaurants.Size = new System.Drawing.Size(352, 229);
            this.dgvRestaurants.TabIndex = 37;
            this.dgvRestaurants.TabStop = false;
            this.dgvRestaurants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRestaurants_CellClick);
            // 
            // monthCalendar
            // 
            this.monthCalendar.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar.Location = new System.Drawing.Point(393, 380);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 38;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dtpReservation_DateChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrice.Location = new System.Drawing.Point(24, 524);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(158, 32);
            this.lblPrice.TabIndex = 40;
            this.lblPrice.Text = "Prezzo medio";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(29, 559);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(121, 30);
            this.txtPrice.TabIndex = 39;
            this.txtPrice.TabStop = false;
            // 
            // lbxCustomer
            // 
            this.lbxCustomer.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbxCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbxCustomer.FormattingEnabled = true;
            this.lbxCustomer.ItemHeight = 16;
            this.lbxCustomer.Location = new System.Drawing.Point(433, 75);
            this.lbxCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxCustomer.Name = "lbxCustomer";
            this.lbxCustomer.Size = new System.Drawing.Size(340, 228);
            this.lbxCustomer.TabIndex = 41;
            // 
            // lbCustomers
            // 
            this.lbCustomers.AutoSize = true;
            this.lbCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lbCustomers.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCustomers.Location = new System.Drawing.Point(427, 39);
            this.lbCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(83, 32);
            this.lbCustomers.TabIndex = 42;
            this.lbCustomers.Text = "Clienti";
            // 
            // lbxRestaurants
            // 
            this.lbxRestaurants.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbxRestaurants.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbxRestaurants.FormattingEnabled = true;
            this.lbxRestaurants.ItemHeight = 16;
            this.lbxRestaurants.Location = new System.Drawing.Point(340, 235);
            this.lbxRestaurants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxRestaurants.Name = "lbxRestaurants";
            this.lbxRestaurants.Size = new System.Drawing.Size(340, 228);
            this.lbxRestaurants.TabIndex = 43;
            this.lbxRestaurants.SelectedIndexChanged += new System.EventHandler(this.lbxRestaurants_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(843, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "label2";
            // 
            // FrmManageReser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Restaurant_Manager.Properties.Resources.Prenotazione;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1151, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxRestaurants);
            this.Controls.Add(this.lbCustomers);
            this.Controls.Add(this.lbxCustomer);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.dgvRestaurants);
            this.Controls.Add(this.valueCustomers);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lblSelectedRest);
            this.Controls.Add(this.txtRestaurant);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.lblRestaurants);
            this.Controls.Add(this.toolStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1169, 639);
            this.MinimumSize = new System.Drawing.Size(1169, 639);
            this.Name = "FrmManageReser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestisci Prenotazione";
            this.Load += new System.EventHandler(this.FrmManageReser_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.Label lblRestaurants;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblSelectedRest;
        private System.Windows.Forms.TextBox txtRestaurant;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.NumericUpDown valueCustomers;
        private System.Windows.Forms.DataGridView dgvRestaurants;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox lbxCustomer;
        private System.Windows.Forms.Label lbCustomers;
        private System.Windows.Forms.ListBox lbxRestaurants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}