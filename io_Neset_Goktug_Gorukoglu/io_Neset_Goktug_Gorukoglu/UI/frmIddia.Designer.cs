namespace io_Neset_Goktug_Gorukoglu.UI
{
    partial class frmIddia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtSahip = new System.Windows.Forms.TextBox();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.bnTamam = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Konu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sahip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Durum";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(68, 12);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(100, 20);
            this.txtKonu.TabIndex = 5;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(68, 41);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(100, 83);
            this.txtAciklama.TabIndex = 6;
            // 
            // txtSahip
            // 
            this.txtSahip.Location = new System.Drawing.Point(69, 156);
            this.txtSahip.Name = "txtSahip";
            this.txtSahip.Size = new System.Drawing.Size(100, 20);
            this.txtSahip.TabIndex = 8;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(69, 185);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(100, 20);
            this.txtDurum.TabIndex = 9;
            // 
            // bnTamam
            // 
            this.bnTamam.Location = new System.Drawing.Point(33, 211);
            this.bnTamam.Name = "bnTamam";
            this.bnTamam.Size = new System.Drawing.Size(75, 23);
            this.bnTamam.TabIndex = 10;
            this.bnTamam.Text = "Tamam";
            this.bnTamam.UseVisualStyleBackColor = true;
            this.bnTamam.Click += new System.EventHandler(this.bnTamam_Click);
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(127, 211);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 11;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            this.btnİptal.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(69, 130);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 12;
            // 
            // frmIddia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 282);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.bnTamam);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.txtSahip);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIddia";
            this.Text = "frmIddia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtSahip;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Button bnTamam;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.DateTimePicker dtpTarih;
    }
}