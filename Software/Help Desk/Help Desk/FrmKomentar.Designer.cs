namespace Help_Desk
{
    partial class FrmKomentar
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
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.btnKomentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(12, 12);
            this.txtKomentar.Multiline = true;
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(333, 58);
            this.txtKomentar.TabIndex = 0;
            // 
            // btnKomentar
            // 
            this.btnKomentar.Location = new System.Drawing.Point(270, 76);
            this.btnKomentar.Name = "btnKomentar";
            this.btnKomentar.Size = new System.Drawing.Size(75, 23);
            this.btnKomentar.TabIndex = 1;
            this.btnKomentar.Text = "Komentiraj";
            this.btnKomentar.UseVisualStyleBackColor = true;
            this.btnKomentar.Click += new System.EventHandler(this.btnKomentar_Click);
            // 
            // FrmKomentar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(357, 111);
            this.Controls.Add(this.btnKomentar);
            this.Controls.Add(this.txtKomentar);
            this.MaximizeBox = false;
            this.Name = "FrmKomentar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj komentar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.Button btnKomentar;
    }
}