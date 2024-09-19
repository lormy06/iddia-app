namespace io_Neset_Goktug_Gorukoglu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbIddiaEkle = new System.Windows.Forms.ToolStripButton();
            this.tsbIddiaDuzenle = new System.Windows.Forms.ToolStripButton();
            this.tsbIddiaSil = new System.Windows.Forms.ToolStripButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbBahisEkle = new System.Windows.Forms.ToolStripButton();
            this.tsbBahisDuzenle = new System.Windows.Forms.ToolStripButton();
            this.tsbBahisSil = new System.Windows.Forms.ToolStripButton();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(946, 584);
            this.splitContainer1.SplitterDistance = 457;
            this.splitContainer1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(451, 553);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "konu";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "aciklama";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "tarih";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "sahip";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "durum";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIddiaEkle,
            this.tsbIddiaDuzenle,
            this.tsbIddiaSil,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(457, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbIddiaEkle
            // 
            this.tsbIddiaEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbIddiaEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsbIddiaEkle.Image")));
            this.tsbIddiaEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIddiaEkle.Name = "tsbIddiaEkle";
            this.tsbIddiaEkle.Size = new System.Drawing.Size(61, 22);
            this.tsbIddiaEkle.Text = "İddia Ekle";
            this.tsbIddiaEkle.Click += new System.EventHandler(this.tsbIddiaEkle_Click);
            // 
            // tsbIddiaDuzenle
            // 
            this.tsbIddiaDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbIddiaDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("tsbIddiaDuzenle.Image")));
            this.tsbIddiaDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIddiaDuzenle.Name = "tsbIddiaDuzenle";
            this.tsbIddiaDuzenle.Size = new System.Drawing.Size(82, 22);
            this.tsbIddiaDuzenle.Text = "İddia Düzenle";
            this.tsbIddiaDuzenle.Click += new System.EventHandler(this.tsbIddiaDuzenle_Click);
            // 
            // tsbIddiaSil
            // 
            this.tsbIddiaSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbIddiaSil.Image = ((System.Drawing.Image)(resources.GetObject("tsbIddiaSil.Image")));
            this.tsbIddiaSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIddiaSil.Name = "tsbIddiaSil";
            this.tsbIddiaSil.Size = new System.Drawing.Size(52, 22);
            this.tsbIddiaSil.Text = "İddia Sil";
            this.tsbIddiaSil.Click += new System.EventHandler(this.tsbIddiaSil_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 31);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(474, 553);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "id";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "iddia_id";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "bahis_yapan";
            this.columnHeader9.Width = 75;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "bahis_miktari";
            this.columnHeader10.Width = 74;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "bahis_tarihi";
            this.columnHeader11.Width = 94;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "bahis_durumu";
            this.columnHeader12.Width = 93;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBahisEkle,
            this.tsbBahisDuzenle,
            this.tsbBahisSil});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(485, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbBahisEkle
            // 
            this.tsbBahisEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBahisEkle.Image = ((System.Drawing.Image)(resources.GetObject("tsbBahisEkle.Image")));
            this.tsbBahisEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBahisEkle.Name = "tsbBahisEkle";
            this.tsbBahisEkle.Size = new System.Drawing.Size(63, 22);
            this.tsbBahisEkle.Text = "Bahis Ekle";
            this.tsbBahisEkle.Click += new System.EventHandler(this.tsbBahisEkle_Click);
            // 
            // tsbBahisDuzenle
            // 
            this.tsbBahisDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBahisDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("tsbBahisDuzenle.Image")));
            this.tsbBahisDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBahisDuzenle.Name = "tsbBahisDuzenle";
            this.tsbBahisDuzenle.Size = new System.Drawing.Size(84, 22);
            this.tsbBahisDuzenle.Text = "Bahis Düzenle";
            this.tsbBahisDuzenle.Click += new System.EventHandler(this.tsbBahisDuzenle_Click);
            // 
            // tsbBahisSil
            // 
            this.tsbBahisSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBahisSil.Image = ((System.Drawing.Image)(resources.GetObject("tsbBahisSil.Image")));
            this.tsbBahisSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBahisSil.Name = "tsbBahisSil";
            this.tsbBahisSil.Size = new System.Drawing.Size(54, 22);
            this.tsbBahisSil.Text = "Bahis Sil";
            this.tsbBahisSil.Click += new System.EventHandler(this.tsbBahisSil_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(139, 22);
            this.toolStripButton1.Text = "VERİTABANINI OLUŞTUR";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 584);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbIddiaDuzenle;
        private System.Windows.Forms.ToolStripButton tsbIddiaSil;
        private System.Windows.Forms.ToolStripButton tsbBahisEkle;
        private System.Windows.Forms.ToolStripButton tsbBahisDuzenle;
        private System.Windows.Forms.ToolStripButton tsbBahisSil;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripButton tsbIddiaEkle;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}