using io_Neset_Goktug_Gorukoglu.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using io_Neset_Goktug_Gorukoglu;
using System.Windows.Forms.VisualStyles;

namespace io_Neset_Goktug_Gorukoglu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        public void Iddialari_Listele()
        {
            BL.Iddialari_Listele();
            listView1.Items.Clear();
            foreach (Iddia_Bilgileri k in BL.Iddialar)
            {
                ListViewItem veri = new ListViewItem(
                    new string[] {
                    k.IBid.ToString(),
                    k.konu,
                    k.aciklama,
                    k.tarih.ToLongDateString(),
                    k.sahip,
                    k.durum});
                listView1.Items.Add(veri);
            }
        }

        private void tsbIddiaEkle_Click(object sender, EventArgs e)
        {
            frmIddia k = new frmIddia()
            {
                Text = "Kişi Ekle",
                StartPosition = FormStartPosition.CenterParent
            };
            if (k.ShowDialog() == DialogResult.OK)
            {
                BL.Iddia_Ekle(k.konu, k.aciklama, k.tarih, k.sahip, k.durum);
               Iddialari_Listele();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        public void IddiaBahisleriniListele(string IBid)
        {
            Iddia_Bilgileri k = BL.Iddialar.Find(a => a.IBid.ToString() == IBid);
            listView2.Items.Clear();
            foreach (Bahis_Bilgileri g in k.Bahis)
            {
                ListViewItem veri = new ListViewItem(
                    new string[]
                    {
                        g.BBid.ToString(),
                        k.IBid.ToString(),
                        g.bahis_yapan.ToString(),
                        g.bahis_miktari.ToString(),
                        g.bahis_tarihi.ToLongDateString(),
                        g.bahis_durumu.ToString()
                    });
                listView2.Items.Add(veri);
            }
        }

        private void tsbIddiaDuzenle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listView1.SelectedItems[0];
            string IBid = veri.SubItems[0].Text;

            frmIddia k = new frmIddia()
            {
                Text = "İddia Düzenle",
                StartPosition = FormStartPosition.CenterParent
            };
            k.konu = veri.SubItems[1].Text;
            k.aciklama = veri.SubItems[2].Text;
            k.tarih = DateTime.Parse(veri.SubItems[3].Text);
            k.sahip = veri.SubItems[4].Text;
            k.durum = veri.SubItems[5].Text;

            if (k.ShowDialog() == DialogResult.OK)
            {
                BL.Iddia_Duzenle(IBid, k.konu, k.aciklama, k.tarih, k.sahip,k.durum);
                Iddialari_Listele();
            }
        }

        private void tsbIddiaSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listView1.SelectedItems[0];
            string IBid = veri.SubItems[0].Text;
           
            
                BL.Iddia_Sil(IBid);
                Iddialari_Listele();

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedIddia = listView1.SelectedItems[0];
                string iddiaId = selectedIddia.SubItems[0].Text; 
                IddiaBahisleriniListele(iddiaId);
            }
        }

        private void tsbBahisEkle_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listView1.SelectedItems[0];
            string IBid = veri.SubItems[0].Text;
            frmBahis k = new frmBahis()
            {
                Text = "Bahis Ekle",
                StartPosition = FormStartPosition.CenterParent
            };
            if (k.ShowDialog() == DialogResult.OK)
            {
                BL.Bahis_Ekle(IBid,k.bahis_yapan, k.bahis_miktari, k.bahis_tarihi, k.bahis_durumu);
                IddiaBahisleriniListele(IBid);
            }


        }

        private void tsbBahisDuzenle_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listView2.SelectedItems[0];
            string BBid = veri.SubItems[0].Text;
            string IBid = veri.SubItems[1].Text;

            frmBahis k = new frmBahis()
            {
                Text = "Bahis Düzenle",
                StartPosition = FormStartPosition.CenterParent
            };

            k.bahis_yapan = veri.SubItems[2].Text;
            k.bahis_miktari = veri.SubItems[3].Text;
            k.bahis_tarihi = DateTime.Parse(veri.SubItems[4].Text);
            k.bahis_durumu = veri.SubItems[5].Text;

            if (k.ShowDialog() == DialogResult.OK)
            {
                BL.Bahis_Duzenle(IBid, BBid, k.bahis_yapan, k.bahis_miktari, k.bahis_tarihi, k.bahis_durumu);

                listView1_SelectedIndexChanged(null, null);
            }
        }

        private void tsbBahisSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listView2.SelectedItems[0];
            string BBid = veri.SubItems[0].Text;
            string IBid = veri.SubItems[1].Text;

            string m = veri.SubItems[2].Text + " " + veri.SubItems[3].Text;

            DialogResult sonuc = MessageBox.Show($"Seçili {m.ToUpper()} Bahis silinsin mi?", "Silmeyi Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                BL.Bahis_Sil(IBid, BBid);
                IddiaBahisleriniListele(IBid);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DL.Database_Ekle();
            DL.Tablo_Ekle();
            DL.Verileri_Ekle();
            Iddialari_Listele();
        }
    }
}
