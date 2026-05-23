using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _202507125019_anket_uygulamasi_
{
    public partial class FormKullaniciAnketleriGor : Form
    {
        string connectionString = "server=localhost;port=3307;database=anketlabdb;uid=root;pwd=;";

        public FormKullaniciAnketleriGor()
        {
            InitializeComponent();
        }

        private void FormKullaniciAnketleriGor_Load(object sender, EventArgs e)
        {
            AnketleriListele();
        }

        private void AnketleriListele()
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = @"
                        SELECT 
                            a.id AS 'ID',
                            a.baslik AS 'Anket Başlığı',
                            k.kategori_adi AS 'Kategori',
                            a.tarih AS 'Oluşturulma Tarihi'
                        FROM anketler a
                        INNER JOIN kategoriler k ON a.kategori_id = k.id
                        ORDER BY a.tarih DESC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti);
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);

                    dgvAnketler.DataSource = tablo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anketleri listeleme hatası: " + ex.Message);
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            AnketleriListele();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}