namespace Restaurant_Manager
{
    partial class FrmCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreate));
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.lblType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.valueSeats = new System.Windows.Forms.NumericUpDown();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblAvgPrice = new System.Windows.Forms.Label();
            this.valueAvgPrice = new System.Windows.Forms.NumericUpDown();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueAvgPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbType.Items.AddRange(new object[] {
            "Pizzeria",
            "Pesce",
            "Carne",
            "Vegetariano",
            "Locale"});
            this.cmbType.Location = new System.Drawing.Point(17, 72);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(139, 28);
            this.cmbType.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(817, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "Crea Ristorante";
            // 
            // btnBack
            // 
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 22);
            this.btnBack.Text = "Indietro";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblType.Location = new System.Drawing.Point(12, 43);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(161, 26);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Tipo di Ristorante";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(223, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblName.Location = new System.Drawing.Point(218, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(160, 26);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nome dell\'attività";
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.BackColor = System.Drawing.Color.Transparent;
            this.lblIVA.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIVA.Location = new System.Drawing.Point(14, 131);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(104, 26);
            this.lblIVA.TabIndex = 6;
            this.lblIVA.Text = "Partita IVA";
            // 
            // txtIva
            // 
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(19, 160);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(154, 26);
            this.txtIva.TabIndex = 2;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblStreet.Location = new System.Drawing.Point(218, 131);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(40, 26);
            this.lblStreet.TabIndex = 8;
            this.lblStreet.Text = "Via";
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(223, 160);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(154, 26);
            this.txtStreet.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCity.Location = new System.Drawing.Point(14, 222);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 26);
            this.lblCity.TabIndex = 10;
            this.lblCity.Text = "Città";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(19, 251);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(154, 26);
            this.txtCity.TabIndex = 4;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelephone.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelephone.Location = new System.Drawing.Point(218, 222);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(84, 26);
            this.lblTelephone.TabIndex = 12;
            this.lblTelephone.Text = "Telefono";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(223, 251);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(154, 26);
            this.txtTelephone.TabIndex = 5;
            // 
            // valueSeats
            // 
            this.valueSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueSeats.Location = new System.Drawing.Point(19, 343);
            this.valueSeats.Name = "valueSeats";
            this.valueSeats.Size = new System.Drawing.Size(139, 26);
            this.valueSeats.TabIndex = 6;
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.BackColor = System.Drawing.Color.Transparent;
            this.lblSeats.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeats.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSeats.Location = new System.Drawing.Point(14, 314);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(53, 26);
            this.lblSeats.TabIndex = 14;
            this.lblSeats.Text = "Posti";
            // 
            // lblAvgPrice
            // 
            this.lblAvgPrice.AutoSize = true;
            this.lblAvgPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblAvgPrice.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAvgPrice.Location = new System.Drawing.Point(218, 314);
            this.lblAvgPrice.Name = "lblAvgPrice";
            this.lblAvgPrice.Size = new System.Drawing.Size(128, 26);
            this.lblAvgPrice.TabIndex = 16;
            this.lblAvgPrice.Text = "Prezzo Medio";
            // 
            // valueAvgPrice
            // 
            this.valueAvgPrice.DecimalPlaces = 2;
            this.valueAvgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueAvgPrice.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.valueAvgPrice.Location = new System.Drawing.Point(223, 343);
            this.valueAvgPrice.Name = "valueAvgPrice";
            this.valueAvgPrice.Size = new System.Drawing.Size(139, 26);
            this.valueAvgPrice.TabIndex = 7;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNote.Location = new System.Drawing.Point(16, 437);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(210, 18);
            this.lblNote.TabIndex = 17;
            this.lblNote.Text = "Si prega di compilare tutti i campi";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(496, 160);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(135, 56);
            this.btnCreate.TabIndex = 18;
            this.btnCreate.Text = "Crea Ristorante";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(496, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 56);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Annulla";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = global::Restaurant_Manager.Properties.Resources.Prenotazione;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(817, 464);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblAvgPrice);
            this.Controls.Add(this.valueAvgPrice);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.valueSeats);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.cmbType);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuovo Ristorante";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueAvgPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.NumericUpDown valueSeats;
        private System.Windows.Forms.Label lblSeats;
        private System.Windows.Forms.Label lblAvgPrice;
        private System.Windows.Forms.NumericUpDown valueAvgPrice;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbType;
    }
}