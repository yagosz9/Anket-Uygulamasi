using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _202507125019_anket_uygulamasi_
{
    public partial class FormSonuclarim : Form
    {
        string connectionString = "server=localhost;port=3307;database=anketlabdb;uid=root;pwd=;";

        int kullaniciId = 2; // Şimdilik user kullanıcısının id değeri

        public FormSonuclarim()
        {
            InitializeComponent();
        }

        private void FormSonuclarim_Load(object sender, EventArgs e)
        {
            SonuclarimiListele();
        }

        private void SonuclarimiListele()
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = @"
                        SELECT 
                            a.baslik AS 'Anket Başlığı',
                            s.soru_metni AS 'Soru',
                            c.cevap AS 'Verilen Cevap',
                            c.tarih AS 'Cevap Tarihi'
                        FROM cevaplar c
                        INNER JOIN sorular s ON c.soru_id = s.id
                        INNER JOIN anketler a ON s.anket_id = a.id
                        WHERE c.kullanici_id = @kullaniciId
                        ORDER BY c.tarih DESC";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(komut);
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);

                    dgvSonuclarim.DataSource = tablo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sonuçlarım listeleme hatası: " + ex.Message);
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            SonuclarimiListele();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}