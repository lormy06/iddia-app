using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using io_Neset_Goktug_Gorukoglu;
using System.Security.Cryptography;

namespace io_Neset_Goktug_Gorukoglu
{
    internal class DL
    {
        static MySqlConnection baglanti = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1",
                Database = databaseName,
                UserID = "tester",
                Password = "Tester_74"
            }.ConnectionString
            );

        public static int Iddia_Ekle(string IBid, string konu, string aciklama, DateTime tarih, string sahip, string durum)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                string ekle = "insert into iddia_bilgileri values(@id,@konu,@aciklama,@tarih,@sahip,@durum)";
                MySqlCommand komut = new MySqlCommand(ekle, baglanti);

                komut.Parameters.AddWithValue("@id", IBid);
                komut.Parameters.AddWithValue("@konu", konu);
                komut.Parameters.AddWithValue("@aciklama", aciklama);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@sahip", sahip);
                komut.Parameters.AddWithValue("@durum", durum);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }
        public static int Iddia_Sil(string IBid)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                string sil = "delete from iddia_bilgileri where id=@id";
                MySqlCommand komut = new MySqlCommand(sil, baglanti);

                komut.Parameters.AddWithValue("@id", IBid);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }
        public static int Iddia_Duzenle(string IBid, string konu, string aciklama, DateTime tarih, string sahip, string durum)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                string duzenle = "update iddia_bilgileri set konu=@konu,aciklama=@aciklama,tarih=@tarih,sahip=@sahip,durum=@durum where id=@id";
                MySqlCommand komut = new MySqlCommand(duzenle, baglanti);

                komut.Parameters.AddWithValue("@id", IBid);
                komut.Parameters.AddWithValue("@konu", konu);
                komut.Parameters.AddWithValue("@aciklama", aciklama);
                komut.Parameters.AddWithValue("@tarih", tarih);
                komut.Parameters.AddWithValue("@sahip", sahip);
                komut.Parameters.AddWithValue("@durum", durum);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }
        public static int Bahis_Ekle(string IBid, string BBid, string bahis_yapan, string bahis_miktari, DateTime bahis_tarihi, string bahis_durumu)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                string ekle = "insert into bahis_bilgileri values(@id,@iddia_id,@bahis_yapan,@bahis_miktari,@bahis_tarihi,@bahis_durumu)";
                MySqlCommand komut = new MySqlCommand(ekle, baglanti);

                komut.Parameters.AddWithValue("@id", BBid);
                komut.Parameters.AddWithValue("@iddia_id", IBid);
                komut.Parameters.AddWithValue("@bahis_yapan", bahis_yapan);
                komut.Parameters.AddWithValue("@bahis_miktari", bahis_miktari);
                komut.Parameters.AddWithValue("@bahis_tarihi", bahis_tarihi);
                komut.Parameters.AddWithValue("@bahis_durumu", bahis_durumu);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }
        public static int Bahis_Sil(string BBid)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                string sil = "delete from bahis_bilgileri where id=@id";
                MySqlCommand komut = new MySqlCommand(sil, baglanti);

                komut.Parameters.AddWithValue("@id", BBid);

                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static int Bahis_Duzenle(string BBid, string bahis_yapan, string bahis_miktari, DateTime bahis_tarihi, string bahis_durumu)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string update = "update bahis_bilgileri set bahis_yapan=@bahis_yapan, bahis_miktari=@bahis_miktari, bahis_tarihi=@bahis_tarihi, bahis_durumu=@bahis_durumu where id=@id";
                MySqlCommand komut = new MySqlCommand(update, baglanti);

                komut.Parameters.AddWithValue("@bahis_yapan", bahis_yapan);
                komut.Parameters.AddWithValue("@bahis_miktari", bahis_miktari);
                komut.Parameters.AddWithValue("@bahis_tarihi", bahis_tarihi);
                komut.Parameters.AddWithValue("@bahis_durumu", bahis_durumu);
                komut.Parameters.AddWithValue("@id", BBid);


                return komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return -1;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }


        public static List<Iddia_Bilgileri> Iddialari_Listele()
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                string select = "select * from iddia_bilgileri";
                MySqlCommand komut = new MySqlCommand(select, baglanti);

                MySqlDataReader dr = komut.ExecuteReader();
                List<Iddia_Bilgileri> Iddialar = new List<Iddia_Bilgileri>();
                while (dr.Read())
                {
                    Iddialar.Add(new Iddia_Bilgileri()
                    {
                        IBid = Guid.Parse(dr[0].ToString()),
                        konu = dr[1].ToString(),
                        aciklama = dr[2].ToString(),
                        tarih = DateTime.Parse(dr[3].ToString()),
                        sahip = dr[4].ToString(),
                        durum = dr[5].ToString()
                    });
                }

                return Iddialar;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        public static List<Bahis_Bilgileri> Bahisleri_Listele(string IBid)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                string select = "select * from bahis_bilgileri where iddia_id=@iddia_id";
                MySqlCommand komut = new MySqlCommand(select, baglanti);
                komut.Parameters.AddWithValue("@iddia_id", IBid);

                MySqlDataReader dr = komut.ExecuteReader();
                List<Bahis_Bilgileri> bahisler = new List<Bahis_Bilgileri>();
                while (dr.Read())
                {
                    bahisler.Add(new Bahis_Bilgileri()
                    {
                        BBid = Guid.Parse(dr[0].ToString()),
                        IBid = Guid.Parse(IBid),
                        bahis_yapan = dr[2].ToString(),
                        bahis_miktari = dr[3].ToString(),
                        bahis_tarihi = (DateTime)dr[4],
                        bahis_durumu = dr[5].ToString()

                    });
                }

                return bahisler;

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata oluştu\n" + hata.Message);
                return null;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }








        private static string databaseName = "iddia_bayisi";

        public static void Database_Ekle()
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                string createDatabaseQuery = $"CREATE DATABASE IF NOT EXISTS {databaseName};use {databaseName}; ";
                using (MySqlCommand command = new MySqlCommand(createDatabaseQuery, baglanti))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Veritabanı başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı oluşturma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        public static void Tablo_Ekle()
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open(); ;

                string createIddiaBilgileriTable = @"
                CREATE TABLE IF NOT EXISTS iddia_bilgileri (
                    id CHAR(36) PRIMARY KEY,
                    konu VARCHAR(255),
                    aciklama TEXT,
                    tarih DATE,
                    sahip VARCHAR(100),
                    durum VARCHAR(50)
                ) Engine=InnoDB;";

                string createBahisBilgileriTable = @"
                CREATE TABLE IF NOT EXISTS bahis_bilgileri (
                    id CHAR(36) PRIMARY KEY,
                    iddia_id CHAR(36),
                    FOREIGN KEY (iddia_id) REFERENCES iddia_bilgileri(id),
                    bahis_yapan VARCHAR(100),
                    bahis_miktari VARCHAR(50),
                    bahis_tarihi DATE,
                    bahis_durumu VARCHAR(50)
                ) Engine=InnoDB;";


                using (MySqlCommand command = new MySqlCommand(createIddiaBilgileriTable, baglanti))
                {
                    command.ExecuteNonQuery();
                }

                using (MySqlCommand command = new MySqlCommand(createBahisBilgileriTable, baglanti))
                {
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Tablolar başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tablo oluşturma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }





        }



        public static void Verileri_Ekle()
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                string insertIddiaBilgileri = @"
                    INSERT INTO iddia_bilgileri (id, konu, aciklama, tarih, sahip, durum) VALUES
                    ('e8f2b6fa-f5a6-4f3b-83b3-8a4eecb9a745', 'Konu 1', 'İddia açıklaması 1', '2024-05-01', 'Ali Veli', 'Açık'),
                    ('ed2c9481-c9fa-4e68-9877-312f5f37dcd8', 'Konu 2', 'İddia açıklaması 2', '2024-05-02', 'Ayşe Yılmaz', 'Açık'),
                    ('c834b9ae-0e17-4676-9e90-7a7eebe5de41', 'Konu 3', 'İddia açıklaması 3', '2024-05-03', 'Fatma Demir', 'Açık'),
                    ('91eaa6b9-1d68-44ea-8a1e-8dd4d8a64c4f', 'Konu 4', 'İddia açıklaması 4', '2024-05-04', 'Mehmet Ak', 'Kapalı'),
                    ('6397ef3a-24b2-4a16-a65b-9b9a4dc18d88', 'Konu 5', 'İddia açıklaması 5', '2024-05-05', 'Canan Çelik', 'Sonuçlanmış'),
                    ('b3a7336d-15a6-4fd7-83f8-8bfa9c03dcd4', 'Konu 6', 'İddia açıklaması 6', '2024-05-06', 'Emre Korkmaz', 'Açık'),
                    ('cda98d3b-302f-4f97-a937-77be88d8dcec', 'Konu 7', 'İddia açıklaması 7', '2024-05-07', 'Hülya Yıldız', 'Kapalı'),
                    ('ef3b06a6-5bb1-4a90-b6b6-a7e28ed9b6fa', 'Konu 8', 'İddia açıklaması 8', '2024-05-08', 'Kerem Kaya', 'Açık'),
                    ('f2db99a4-813b-4a65-8f3a-8b1efec9a8d9', 'Konu 9', 'İddia açıklaması 9', '2024-05-09', 'Merve Deniz', 'Sonuçlanmış'),
                    ('9b8d7cb1-bc29-43f3-8e8b-0af2a87a7f5d', 'Konu 10', 'İddia açıklaması 10', '2024-05-10', 'Ahmet Şahin', 'Açık');";

                string insertBahisBilgileri = @"
                INSERT INTO bahis_bilgileri (id, iddia_id, bahis_yapan, bahis_miktari, bahis_tarihi, bahis_durumu) VALUES
                ('ea72f92f-9d6f-4622-95b7-72e47db9e8d4', 'e8f2b6fa-f5a6-4f3b-83b3-8a4eecb9a745', 'Berk Eren', 100.00, '2024-05-01', 'Aktif'),
                ('ff17f9f3-38fc-4635-b7a5-14c5d63e7fae', 'ed2c9481-c9fa-4e68-9877-312f5f37dcd8', 'Selin Güler', 200.00, '2024-05-02', 'Sonuçlanmış'),
                ('f8c2e9fa-20e4-4c27-91f3-2e5d4c8c7f6e', 'c834b9ae-0e17-4676-9e90-7a7eebe5de41', 'Deniz Tunç', 150.00, '2024-05-03', 'İptal Edilmiş'),
                ('d7e5a2fa-3a96-4c8b-97b1-7f4d8e8d7c9f', '91eaa6b9-1d68-44ea-8a1e-8dd4d8a64c4f', 'Ece Yaman', 120.00, '2024-05-04', 'Sonuçlanmış'),
                ('a8c7b3fa-18e7-4f37-8b8f-8d4e6b6d8d5f', '6397ef3a-24b2-4a16-a65b-9b9a4dc18d88', 'Okan Aydın', 170.00, '2024-05-05', 'Aktif'),
                ('b7c8d4fa-25f9-4b27-9b1f-9f3d7d6f8e7f', 'b3a7336d-15a6-4fd7-83f8-8bfa9c03dcd4', 'Gizem Koç', 110.00, '2024-05-06', 'İptal Edilmiş'),
                ('e7f4b2fa-2f6a-4b8b-90e5-3e4c6c8f9d8f', 'cda98d3b-302f-4f97-a937-77be88d8dcec', 'Umut Özdemir', 130.00, '2024-05-07', 'Sonuçlanmış'),
                ('c8f2e3fa-36f7-4b47-9d2e-2f5e6e7d9e1f', 'ef3b06a6-5bb1-4a90-b6b6-a7e28ed9b6fa', 'Levent Demir', 140.00, '2024-05-08', 'Aktif'),
                ('f9d3e2fa-48e1-4c67-8e7a-1f6d7f9d8e2f', 'f2db99a4-813b-4a65-8f3a-8b1efec9a8d9', 'Hakan Karaca', 190.00, '2024-05-09', 'İptal Edilmiş'),
                ('b9e1d2fa-57e3-4a27-8f7b-3f8d7e9d6c4f', '9b8d7cb1-bc29-43f3-8e8b-0af2a87a7f5d', 'Burcu Sarı', 210.00, '2024-05-10', 'Aktif');";

                using (MySqlCommand command = new MySqlCommand(insertIddiaBilgileri, baglanti))
                {
                    command.ExecuteNonQuery();
                }

                using (MySqlCommand command = new MySqlCommand(insertBahisBilgileri, baglanti))
                {
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Veriler başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri ekleme hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
