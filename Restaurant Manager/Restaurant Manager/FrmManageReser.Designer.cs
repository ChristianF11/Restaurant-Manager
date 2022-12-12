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
            this.separator = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCity = new System.Windows.Forms.ToolStripLabel();
            this.txtCity = new System.Windows.Forms.ToolStripTextBox();
            this.lblRestaurants = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.valueCustomers = new System.Windows.Forms.NumericUpDown();
            this.dgvRestaurants = new System.Windows.Forms.DataGridView();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.lbCustomers = new System.Windows.Forms.Label();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblSelectedRest = new System.Windows.Forms.Label();
            this.txtRestaurant = new System.Windows.Forms.TextBox();
            this.lblSeats = new System.Windows.Forms.Label();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.picBoxTicket = new System.Windows.Forms.PictureBox();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.separator,
            this.btnSave,
            this.btnCancel,
            this.separator2,
            this.lblCity,
            this.txtCity});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(865, 27);
            this.toolStrip.TabIndex = 22;
            this.toolStrip.Text = "Registra Cliente";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Image = global::Restaurant_Manager.Properties.Resources.back;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 24);
            this.btnBack.Text = "Indietro";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // separator
            // 
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(6, 27);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Image = global::Restaurant_Manager.Properties.Resources.save;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(58, 24);
            this.btnSave.Text = "Salva";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Image = global::Restaurant_Manager.Properties.Resources.cancel;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 24);
            this.btnCancel.Text = "Annulla";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // separator2
            // 
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(6, 27);
            // 
            // lblCity
            // 
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(147, 24);
            this.lblCity.Text = "Ricerca Ristorante per città";
            // 
            // txtCity
            // 
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 27);
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // lblRestaurants
            // 
            this.lblRestaurants.AutoSize = true;
            this.lblRestaurants.BackColor = System.Drawing.Color.Transparent;
            this.lblRestaurants.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurants.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRestaurants.Location = new System.Drawing.Point(586, 33);
            this.lblRestaurants.Name = "lblRestaurants";
            this.lblRestaurants.Size = new System.Drawing.Size(92, 26);
            this.lblRestaurants.TabIndex = 23;
            this.lblRestaurants.Text = "Ristoranti";
            // 
            // lblCustomers
            // 
            this.lblCustomers.AutoSize = true;
            this.lblCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomers.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCustomers.Location = new System.Drawing.Point(416, 182);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(106, 26);
            this.lblCustomers.TabIndex = 33;
            this.lblCustomers.Text = "N° Persone";
            // 
            // valueCustomers
            // 
            this.valueCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueCustomers.Location = new System.Drawing.Point(420, 208);
            this.valueCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.valueCustomers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueCustomers.Name = "valueCustomers";
            this.valueCustomers.Size = new System.Drawing.Size(134, 26);
            this.valueCustomers.TabIndex = 36;
            this.valueCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.dgvRestaurants.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.dgvRestaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurants.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvRestaurants.Location = new System.Drawing.Point(590, 58);
            this.dgvRestaurants.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRestaurants.MultiSelect = false;
            this.dgvRestaurants.Name = "dgvRestaurants";
            this.dgvRestaurants.ReadOnly = true;
            this.dgvRestaurants.RowHeadersWidth = 51;
            this.dgvRestaurants.RowTemplate.Height = 24;
            this.dgvRestaurants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRestaurants.Size = new System.Drawing.Size(264, 172);
            this.dgvRestaurants.TabIndex = 37;
            this.dgvRestaurants.TabStop = false;
            this.dgvRestaurants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRestaurants_CellClick);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(420, 273);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 38;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.dtpReservation_DateChanged);
            // 
            // lbCustomers
            // 
            this.lbCustomers.AutoSize = true;
            this.lbCustomers.BackColor = System.Drawing.Color.Transparent;
            this.lbCustomers.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbCustomers.Location = new System.Drawing.Point(416, 42);
            this.lbCustomers.Name = "lbCustomers";
            this.lbCustomers.Size = new System.Drawing.Size(65, 26);
            this.lbCustomers.TabIndex = 42;
            this.lbCustomers.Text = "Clienti";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(420, 68);
            this.cmbCustomers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(132, 30);
            this.cmbCustomers.TabIndex = 43;
            this.cmbCustomers.SelectedIndexChanged += new System.EventHandler(this.cmbCustomers_SelectedIndexChanged);
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.lblTicket.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTicket.Location = new System.Drawing.Point(142, 58);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(117, 52);
            this.lblTicket.TabIndex = 75;
            this.lblTicket.Text = "RIEPILOGO\r\nORDINE";
            this.lblTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.lblCustomer.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCustomer.Location = new System.Drawing.Point(96, 134);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(69, 26);
            this.lblCustomer.TabIndex = 74;
            this.lblCustomer.Text = "Cliente";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Location = new System.Drawing.Point(100, 173);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(171, 26);
            this.txtUsername.TabIndex = 73;
            this.txtUsername.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.lblPrice.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(96, 364);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(127, 26);
            this.lblPrice.TabIndex = 72;
            this.lblPrice.Text = "Prezzo medio";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Location = new System.Drawing.Point(97, 390);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(92, 26);
            this.txtPrice.TabIndex = 71;
            this.txtPrice.TabStop = false;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSelectedRest
            // 
            this.lblSelectedRest.AutoSize = true;
            this.lblSelectedRest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.lblSelectedRest.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedRest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSelectedRest.Location = new System.Drawing.Point(109, 216);
            this.lblSelectedRest.Name = "lblSelectedRest";
            this.lblSelectedRest.Size = new System.Drawing.Size(96, 26);
            this.lblSelectedRest.TabIndex = 70;
            this.lblSelectedRest.Text = "Ristorante";
            // 
            // txtRestaurant
            // 
            this.txtRestaurant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.txtRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestaurant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRestaurant.Location = new System.Drawing.Point(113, 243);
            this.txtRestaurant.Name = "txtRestaurant";
            this.txtRestaurant.ReadOnly = true;
            this.txtRestaurant.Size = new System.Drawing.Size(171, 26);
            this.txtRestaurant.TabIndex = 69;
            this.txtRestaurant.TabStop = false;
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.lblSeats.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSeats.Location = new System.Drawing.Point(109, 291);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(100, 26);
            this.lblSeats.TabIndex = 68;
            this.lblSeats.Text = "Posti liberi";
            // 
            // txtSeats
            // 
            this.txtSeats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(239)))), ((int)(((byte)(233)))));
            this.txtSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeats.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSeats.Location = new System.Drawing.Point(113, 317);
            this.txtSeats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.ReadOnly = true;
            this.txtSeats.Size = new System.Drawing.Size(92, 26);
            this.txtSeats.TabIndex = 67;
            this.txtSeats.TabStop = false;
            this.txtSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // picBoxTicket
            // 
            this.picBoxTicket.BackColor = System.Drawing.Color.Transparent;
            this.picBoxTicket.BackgroundImage = global::Restaurant_Manager.Properties.Resources.Scontrino;
            this.picBoxTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxTicket.Location = new System.Drawing.Point(19, 33);
            this.picBoxTicket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBoxTicket.Name = "picBoxTicket";
            this.picBoxTicket.Size = new System.Drawing.Size(344, 403);
            this.picBoxTicket.TabIndex = 66;
            this.picBoxTicket.TabStop = false;
            // 
            // FrmManageReser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Restaurant_Manager.Properties.Resources.PrenotazioneNew;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 449);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblSelectedRest);
            this.Controls.Add(this.txtRestaurant);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.picBoxTicket);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.lbCustomers);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.dgvRestaurants);
            this.Controls.Add(this.valueCustomers);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.lblRestaurants);
            this.Controls.Add(this.toolStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(881, 488);
            this.MinimumSize = new System.Drawing.Size(881, 488);
            this.Name = "FrmManageReser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestisci Prenotazione";
            this.Load += new System.EventHandler(this.FrmManageReser_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Label lblRestaurants;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.NumericUpDown valueCustomers;
        private System.Windows.Forms.DataGridView dgvRestaurants;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label lbCustomers;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblSelectedRest;
        private System.Windows.Forms.TextBox txtRestaurant;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.PictureBox picBoxTicket;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripSeparator separator;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator separator2;
        private System.Windows.Forms.ToolStripLabel lblCity;
        private System.Windows.Forms.ToolStripTextBox txtCity;
    }
}