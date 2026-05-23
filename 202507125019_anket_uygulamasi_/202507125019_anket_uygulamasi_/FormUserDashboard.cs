using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _202507125019_anket_uygulamasi_
{
    public partial class FormUserDashboard : Form
    {
        string connectionString = "server=localhost;port=3307;database=anketlabdb;uid=root;pwd=;";

        int kullaniciId = 2;

        public FormUserDashboard()
        {
            InitializeComponent();
        }

        private void FormUserDashboard_Load(object sender, EventArgs e)
        {
            KullaniciIstatistikleriniYukle();
        }

        private void btnAnketleriGor_Click(object sender, EventArgs e)
        {
            FormKullaniciAnketleriGor form = new FormKullaniciAnketleriGor();
            form.Show();
        }

        private void btnIcerikAnketleriGor_Click(object sender, EventArgs e)
        {
            FormKullaniciAnketleriGor form = new FormKullaniciAnketleriGor();
            form.Show();
        }

        private void btnAnketCoz_Click(object sender, EventArgs e)
        {
            FormAnketCoz form = new FormAnketCoz();
            form.Show();
        }

        private void btnIcerikAnketCoz_Click(object sender, EventArgs e)
        {
            FormAnketCoz form = new FormAnketCoz();
            form.Show();
        }

        private void btnSonuclarim_Click(object sender, EventArgs e)
        {
            FormSonuclarim form = new FormSonuclarim();
            form.Show();
        }

        private void btnIcerikSonuclar_Click(object sender, EventArgs e)
        {
            FormSonuclarim form = new FormSonuclarim();
            form.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void KullaniciIstatistikleriniYukle()
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                   
                    string toplamAnketSorgu = "SELECT COUNT(*) FROM anketler";
                    MySqlCommand toplamAnketKomut = new MySqlCommand(toplamAnketSorgu, baglanti);
                    int toplamAnket = Convert.ToInt32(toplamAnketKomut.ExecuteScalar());

                   
                    string cevaplananSorgu = @"
                        SELECT COUNT(DISTINCT s.anket_id)
                        FROM cevaplar c
                        INNER JOIN sorular s ON c.soru_id = s.id
                        WHERE c.kullanici_id = @kullaniciId";

                    MySqlCommand cevaplananKomut = new MySqlCommand(cevaplananSorgu, baglanti);
                    cevaplananKomut.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    int cevaplanan = Convert.ToInt32(cevaplananKomut.ExecuteScalar());

                   
                    int bekleyen = toplamAnket - cevaplanan;

                    if (bekleyen < 0)
                    {
                        bekleyen = 0;
                    }

                    
                    lblToplamAnket.Text = toplamAnket.ToString();
                    lblCevaplanan.Text = cevaplanan.ToString();
                    lblBekleyen.Text = bekleyen.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kullanıcı istatistikleri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }
    }
}