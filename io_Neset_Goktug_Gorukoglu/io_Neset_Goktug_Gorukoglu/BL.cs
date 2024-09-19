using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using io_Neset_Goktug_Gorukoglu;

namespace io_Neset_Goktug_Gorukoglu
{
    static class BL
    {
        public static List<Iddia_Bilgileri> Iddialar = new List<Iddia_Bilgileri>();
        public static void Iddia_Ekle(string konu, string aciklama, DateTime tarih, string sahip,string durum)
        {
            Iddia_Bilgileri k = new Iddia_Bilgileri()
            {
                IBid = Guid.NewGuid(),
                konu = konu,
                aciklama = aciklama,
                tarih = tarih,
                sahip = sahip,
                durum = durum
            };

            int sonuc = DL.Iddia_Ekle(k.IBid.ToString(), konu, aciklama,tarih,sahip,durum);
            if (sonuc != -1)
                Iddialar.Add(k);
        }

        public static void Iddia_Sil(string IBid)
        {
            int sonuc = DL.Iddia_Sil(IBid);
            if (sonuc != -1)
            {
                Iddia_Bilgileri k = Iddialar.Find(o => o.IBid.ToString() == IBid);
                Iddialar.Remove(k);
            }
        }
        public static void Iddia_Duzenle(string IBid, string konu, string aciklama, DateTime tarih, string sahip,string durum)
        {
            Iddia_Bilgileri k = Iddialar.Find(o => o.IBid.ToString() == IBid);
            int sonuc = DL.Iddia_Duzenle(IBid, konu, aciklama, tarih, sahip, durum);
            if (sonuc != -1)
            {
                k.konu = konu;
                k.aciklama = aciklama;
                k.tarih = tarih;
                k.sahip = sahip;
                k.durum = durum;
            }
        }

        public static void Bahis_Ekle(string IBid, string bahis_yapan, string bahis_miktari, DateTime bahis_tarihi,string bahis_durumu)
        {
            Iddia_Bilgileri k = Iddialar.Find(o => o.IBid.ToString() == IBid);
            Bahis_Bilgileri g = new Bahis_Bilgileri()
            {
                BBid = Guid.NewGuid(),
                bahis_yapan = bahis_yapan,
                bahis_miktari = bahis_miktari,
                bahis_tarihi = bahis_tarihi,
                bahis_durumu=bahis_durumu

            };
            int sonuc = DL.Bahis_Ekle(IBid, g.BBid.ToString(), bahis_yapan, bahis_miktari, bahis_tarihi, bahis_durumu);
            if (sonuc != -1)
                k.Bahis.Add(g);
        }
        public static void Bahis_Duzenle(string IBid, string BBid, string bahis_yapan, string bahis_miktari, DateTime bahis_tarihi, string bahis_durumu)
        {
            if (string.IsNullOrEmpty(IBid))
            {
                MessageBox.Show("IBid parametresi null veya boş.");
                return;
            }

            if (Iddialar == null || Iddialar.Count == 0)
            {
                MessageBox.Show("Iddialar koleksiyonu boş veya null.");
                return;
            }

            Console.WriteLine($"IBid: {IBid}");

            foreach (var item in Iddialar)
            {
                Console.WriteLine($"Koleksiyondaki IBid: {item.IBid}");
            }
            Iddia_Bilgileri k = Iddialar.Find(o => o.IBid.ToString() == IBid);

            if (k == null)
            {
                MessageBox.Show("Eşleşen Iddia_Bilgileri bulunamadı.");
                return;
            }

            int sonuc = DL.Bahis_Duzenle(BBid, bahis_yapan, bahis_miktari, bahis_tarihi, bahis_durumu);

            if (sonuc != -1)
            {
                Bahis_Bilgileri g = k.Bahis.Find(o => o.BBid.ToString() == BBid);
                if (g != null)
                {
                    g.bahis_yapan = bahis_yapan;
                    g.bahis_miktari = bahis_miktari;
                    g.bahis_tarihi = bahis_tarihi;
                    g.bahis_durumu = bahis_durumu;
                }
            }
        }
        public static void Bahis_Sil(string IBid, string BBid)
        {
            Iddia_Bilgileri k = Iddialar.Find(o => o.IBid.ToString() == IBid);
            int sonuc = DL.Bahis_Sil(BBid);
            if (sonuc != -1)
            {
                Bahis_Bilgileri g = k.Bahis.Find(o => o.BBid.ToString() == BBid);
                k.Bahis.Remove(g);
            }
        }
        public static void Iddialari_Listele()
        {

            try
            {
                Iddialar = DL.Iddialari_Listele();
                foreach (var k in Iddialar)
                {
                    k.Bahis = DL.Bahisleri_Listele(k.IBid.ToString());
                }
            }
            catch (Exception ex)
            { MessageBox.Show($"Listeleme hatası: {ex.Message}"); }
        }
    }
}
