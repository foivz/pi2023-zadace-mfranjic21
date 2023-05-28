namespace Help_Desk
{
    partial class FrmPocetna
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblCIP = new System.Windows.Forms.Label();
            this.btnPopisKvarova = new System.Windows.Forms.Button();
            this.btnPopisZahtjeva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNaslov.Location = new System.Drawing.Point(109, 77);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(340, 74);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Help Desk";
            // 
            // lblCIP
            // 
            this.lblCIP.AutoSize = true;
            this.lblCIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCIP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCIP.Location = new System.Drawing.Point(446, 116);
            this.lblCIP.Name = "lblCIP";
            this.lblCIP.Size = new System.Drawing.Size(288, 26);
            this.lblCIP.TabIndex = 1;
            this.lblCIP.Text = "Centar Informatičke Podrške";
            // 
            // btnPopisKvarova
            // 
            this.btnPopisKvarova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPopisKvarova.Location = new System.Drawing.Point(302, 167);
            this.btnPopisKvarova.Name = "btnPopisKvarova";
            this.btnPopisKvarova.Size = new System.Drawing.Size(256, 64);
            this.btnPopisKvarova.TabIndex = 2;
            this.btnPopisKvarova.Text = "Prikaži popis kvarova";
            this.btnPopisKvarova.UseVisualStyleBackColor = true;
            this.btnPopisKvarova.Click += new System.EventHandler(this.btnPopisKvarova_Click);
            // 
            // btnPopisZahtjeva
            // 
            this.btnPopisZahtjeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPopisZahtjeva.Location = new System.Drawing.Point(302, 250);
            this.btnPopisZahtjeva.Name = "btnPopisZahtjeva";
            this.btnPopisZahtjeva.Size = new System.Drawing.Size(256, 64);
            this.btnPopisZahtjeva.TabIndex = 3;
            this.btnPopisZahtjeva.Text = "Podnesi zahtjev za prijavu kvara";
            this.btnPopisZahtjeva.UseVisualStyleBackColor = true;
            this.btnPopisZahtjeva.Click += new System.EventHandler(this.btnPopisZahtjeva_Click);
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(844, 441);
            this.Controls.Add(this.btnPopisZahtjeva);
            this.Controls.Add(this.btnPopisKvarova);
            this.Controls.Add(this.lblCIP);
            this.Controls.Add(this.lblNaslov);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Početna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblCIP;
        private System.Windows.Forms.Button btnPopisKvarova;
        private System.Windows.Forms.Button btnPopisZahtjeva;
    }
}