namespace Help_Desk
{
    partial class FrmPodnesiZahtjev
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
            this.btnNatrag = new System.Windows.Forms.Button();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblPrioritet = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.cmbPrioritet = new System.Windows.Forms.ComboBox();
            this.btnPohrani = new System.Windows.Forms.Button();
            this.btnResetiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNatrag.Location = new System.Drawing.Point(12, 12);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(128, 32);
            this.btnNatrag.TabIndex = 0;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNaslov.Location = new System.Drawing.Point(197, 63);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(474, 37);
            this.lblNaslov.TabIndex = 1;
            this.lblNaslov.Text = "Podnesi zahtjev za prijavu kvara";
            // 
            // lblPrioritet
            // 
            this.lblPrioritet.AutoSize = true;
            this.lblPrioritet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrioritet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPrioritet.Location = new System.Drawing.Point(184, 108);
            this.lblPrioritet.Name = "lblPrioritet";
            this.lblPrioritet.Size = new System.Drawing.Size(67, 20);
            this.lblPrioritet.TabIndex = 5;
            this.lblPrioritet.Text = "Prioritet:";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOpis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOpis.Location = new System.Drawing.Point(206, 134);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(45, 20);
            this.lblOpis.TabIndex = 6;
            this.lblOpis.Text = "Opis:";
            // 
            // lblLokacija
            // 
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLokacija.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLokacija.Location = new System.Drawing.Point(180, 201);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(71, 20);
            this.lblLokacija.TabIndex = 7;
            this.lblLokacija.Text = "Lokacija:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(257, 134);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(414, 61);
            this.txtOpis.TabIndex = 11;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(257, 201);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(414, 20);
            this.txtLokacija.TabIndex = 12;
            // 
            // cmbPrioritet
            // 
            this.cmbPrioritet.FormattingEnabled = true;
            this.cmbPrioritet.Items.AddRange(new object[] {
            "Visok",
            "Srednji",
            "Nizak"});
            this.cmbPrioritet.Location = new System.Drawing.Point(257, 107);
            this.cmbPrioritet.Name = "cmbPrioritet";
            this.cmbPrioritet.Size = new System.Drawing.Size(414, 21);
            this.cmbPrioritet.TabIndex = 14;
            // 
            // btnPohrani
            // 
            this.btnPohrani.Location = new System.Drawing.Point(257, 227);
            this.btnPohrani.Name = "btnPohrani";
            this.btnPohrani.Size = new System.Drawing.Size(203, 23);
            this.btnPohrani.TabIndex = 15;
            this.btnPohrani.Text = "Pohrani";
            this.btnPohrani.UseVisualStyleBackColor = true;
            this.btnPohrani.Click += new System.EventHandler(this.btnPohrani_Click);
            // 
            // btnResetiraj
            // 
            this.btnResetiraj.Location = new System.Drawing.Point(468, 227);
            this.btnResetiraj.Name = "btnResetiraj";
            this.btnResetiraj.Size = new System.Drawing.Size(203, 23);
            this.btnResetiraj.TabIndex = 16;
            this.btnResetiraj.Text = "Resetiraj";
            this.btnResetiraj.UseVisualStyleBackColor = true;
            this.btnResetiraj.Click += new System.EventHandler(this.btnResetiraj_Click);
            // 
            // FrmPodnesiZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(844, 441);
            this.Controls.Add(this.btnResetiraj);
            this.Controls.Add(this.btnPohrani);
            this.Controls.Add(this.cmbPrioritet);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblPrioritet);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.btnNatrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPodnesiZahtjev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Podnesi Zahtjev";
            this.Load += new System.EventHandler(this.FrmPodnesiZahtjev_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblPrioritet;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.ComboBox cmbPrioritet;
        private System.Windows.Forms.Button btnPohrani;
        private System.Windows.Forms.Button btnResetiraj;
    }
}