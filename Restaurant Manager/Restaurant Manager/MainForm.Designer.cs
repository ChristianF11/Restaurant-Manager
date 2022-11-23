namespace Restaurant_Manager
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRestaurant = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestaurant
            // 
            this.btnRestaurant.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurant.Location = new System.Drawing.Point(139, 148);
            this.btnRestaurant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestaurant.Name = "btnRestaurant";
            this.btnRestaurant.Size = new System.Drawing.Size(309, 87);
            this.btnRestaurant.TabIndex = 0;
            this.btnRestaurant.Text = "Anagrafica Ristoranti";
            this.btnRestaurant.UseVisualStyleBackColor = true;
            this.btnRestaurant.Click += new System.EventHandler(this.btnRestaurant_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(544, 148);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(309, 87);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Anagrafica Clienti";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.Location = new System.Drawing.Point(139, 306);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(309, 87);
            this.btnReservation.TabIndex = 2;
            this.btnReservation.Text = "Prenotazioni";
            this.btnReservation.UseVisualStyleBackColor = true;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(343, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 46);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "RISTOManager";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(544, 306);
            this.btnStats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(309, 87);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "Statistiche";
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Restaurant_Manager.Properties.Resources.MainForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1013, 519);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReservation);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnRestaurant);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1031, 566);
            this.MinimumSize = new System.Drawing.Size(1031, 566);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RistoManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurant;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStats;
    }
}

