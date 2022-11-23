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
            this.lbxRestaurants = new System.Windows.Forms.ListBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.lblRestaurants = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSelectedRest = new System.Windows.Forms.Label();
            this.txtRestaurant = new System.Windows.Forms.TextBox();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxRestaurants
            // 
            this.lbxRestaurants.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbxRestaurants.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbxRestaurants.FormattingEnabled = true;
            this.lbxRestaurants.ItemHeight = 16;
            this.lbxRestaurants.Location = new System.Drawing.Point(28, 98);
            this.lbxRestaurants.Name = "lbxRestaurants";
            this.lbxRestaurants.Size = new System.Drawing.Size(323, 180);
            this.lbxRestaurants.TabIndex = 0;
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
            this.toolStrip.Size = new System.Drawing.Size(1022, 27);
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
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 24);
            this.btnCancel.Text = "Annulla";
            // 
            // lblRestaurants
            // 
            this.lblRestaurants.AutoSize = true;
            this.lblRestaurants.BackColor = System.Drawing.Color.Transparent;
            this.lblRestaurants.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurants.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRestaurants.Location = new System.Drawing.Point(22, 48);
            this.lblRestaurants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRestaurants.Name = "lblRestaurants";
            this.lblRestaurants.Size = new System.Drawing.Size(116, 32);
            this.lblRestaurants.TabIndex = 23;
            this.lblRestaurants.Text = "Ristoranti";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(427, 71);
            this.monthCalendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 25;
            // 
            // txtSeats
            // 
            this.txtSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeats.Location = new System.Drawing.Point(731, 248);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.ReadOnly = true;
            this.txtSeats.Size = new System.Drawing.Size(122, 30);
            this.txtSeats.TabIndex = 26;
            this.txtSeats.TabStop = false;
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.BackColor = System.Drawing.Color.Transparent;
            this.lblSeats.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSeats.Location = new System.Drawing.Point(725, 213);
            this.lblSeats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(124, 32);
            this.lblSeats.TabIndex = 27;
            this.lblSeats.Text = "Posti liberi";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(379, 334);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(122, 32);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(386, 370);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(261, 30);
            this.txtUsername.TabIndex = 28;
            // 
            // lblSelectedRest
            // 
            this.lblSelectedRest.AutoSize = true;
            this.lblSelectedRest.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectedRest.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedRest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSelectedRest.Location = new System.Drawing.Point(21, 334);
            this.lblSelectedRest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedRest.Name = "lblSelectedRest";
            this.lblSelectedRest.Size = new System.Drawing.Size(122, 32);
            this.lblSelectedRest.TabIndex = 31;
            this.lblSelectedRest.Text = "Ristorante";
            // 
            // txtRestaurant
            // 
            this.txtRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestaurant.Location = new System.Drawing.Point(28, 370);
            this.txtRestaurant.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblCustomers.Location = new System.Drawing.Point(725, 326);
            this.lblCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomers.Name = "lblCustomers";
            this.lblCustomers.Size = new System.Drawing.Size(133, 32);
            this.lblCustomers.TabIndex = 33;
            this.lblCustomers.Text = "N° Persone";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(731, 370);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.Size = new System.Drawing.Size(122, 30);
            this.txtCustomer.TabIndex = 32;
            this.txtCustomer.TabStop = false;
            // 
            // FrmManageReser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Restaurant_Manager.Properties.Resources.Prenotazione;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1022, 527);
            this.Controls.Add(this.lblCustomers);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.lblSelectedRest);
            this.Controls.Add(this.txtRestaurant);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.txtSeats);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.lblRestaurants);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.lbxRestaurants);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManageReser";
            this.Text = "Gestisci Prenotazione";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxRestaurants;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.Label lblRestaurants;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblSelectedRest;
        private System.Windows.Forms.TextBox txtRestaurant;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.TextBox txtCustomer;
    }
}