using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _202507125019_anket_uygulamasi_
{
    public partial class FormAdminDashboard : Form
    {
        string connectionString = "server=localhost;port=3307;database=anketlabdb;uid=root;pwd=;";

        public FormAdminDashboard()
        {
            InitializeComponent();
        }

        private void FormAdminDashboard_Load(object sender, EventArgs e)
        {
            IstatistikKartlariniYukle();
            SonOlusturulanAnketleriListele();
            KatilimIstatistikleriniYukle();
            KategoriDagiliminiYukle();
        }

        private void lblAdminLogoBaslik_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSonuclar form = new FormSonuclar();
            form.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void btnAnketOlustur_Click(object sender, EventArgs e)
        {
            FormAnketOlustur form = new FormAnketOlustur();
            form.Show();
        }

        private void btnAnketListele_Click(object sender, EventArgs e)
        {
            FormAnketListele form = new FormAnketListele();
            form.Show();
        }

        private void btnSonuclar_Click(object sender, EventArgs e)
        {
            FormSonuclar form = new FormSonuclar();
            form.Show();
        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            FormKategoriler form = new FormKategoriler();
            form.Show();
        }

        private void btnHizliYeniAnket_Click(object sender, EventArgs e)
        {
            FormAnketOlustur form = new FormAnketOlustur();
            form.Show();
        }

        private void btnRaporGor_Click(object sender, EventArgs e)
        {
            FormSonuclar form = new FormSonuclar();
            form.Show();
        }

        private void SonOlusturulanAnketleriListele()
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string arama = txtAdminAra.Text.Trim();

                    if (arama == "Ara...")
                    {
                        arama = "";
                    }

                    string sorgu = @"
                SELECT 
                    a.baslik AS 'Anket Başlığı',
                    k.kategori_adi AS 'Kategori',
                    a.tarih AS 'Tarih'
                FROM anketler a
                INNER JOIN kategoriler k ON a.kategori_id = k.id
                WHERE a.baslik LIKE @arama
                   OR k.kategori_adi LIKE @arama
                ORDER BY a.tarih DESC
                LIMIT 5";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@arama", "%" + arama + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(komut);
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);

                    dgvSonAnketler.DataSource = tablo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Son oluşturulan anketler yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void KatilimIstatistikleriniYukle()
        {
            pnlKatilimGrafik.Controls.Clear();

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = @"
                        SELECT 
                            MONTH(tarih) AS AyNo,
                            COUNT(*) AS CevapSayisi
                        FROM cevaplar
                        GROUP BY MONTH(tarih)
                        ORDER BY AyNo";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(komut);
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);

                    Label baslik = new Label();
                    baslik.Text = "Anket Katılım İstatistikleri";
                    baslik.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    baslik.ForeColor = Color.FromArgb(30, 30, 45);
                    baslik.Location = new Point(20, 15);
                    baslik.AutoSize = true;
                    pnlKatilimGrafik.Controls.Add(baslik);

                    if (tablo.Rows.Count == 0)
                    {
                        Label bosMesaj = new Label();
                        bosMesaj.Text = "Henüz cevap verisi bulunmamaktadır.";
                        bosMesaj.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                        bosMesaj.ForeColor = Color.DimGray;
                        bosMesaj.Location = new Point(25, 60);
                        bosMesaj.AutoSize = true;
                        pnlKatilimGrafik.Controls.Add(bosMesaj);
                        return;
                    }

                    int maxCevap = 1;

                    foreach (DataRow row in tablo.Rows)
                    {
                        int cevapSayisi = Convert.ToInt32(row["CevapSayisi"]);

                        if (cevapSayisi > maxCevap)
                        {
                            maxCevap = cevapSayisi;
                        }
                    }

                    int y = 60;
                    int maxBarWidth = 250;

                    foreach (DataRow row in tablo.Rows)
                    {
                        int ayNo = Convert.ToInt32(row["AyNo"]);
                        int cevapSayisi = Convert.ToInt32(row["CevapSayisi"]);

                        string ayAdi = AyAdiniGetir(ayNo);

                        Label lblAy = new Label();
                        lblAy.Text = ayAdi;
                        lblAy.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        lblAy.ForeColor = Color.FromArgb(60, 60, 70);
                        lblAy.Location = new Point(25, y);
                        lblAy.Size = new Size(45, 22);

                        Panel barArkaPlan = new Panel();
                        barArkaPlan.BackColor = Color.FromArgb(235, 235, 240);
                        barArkaPlan.Location = new Point(80, y + 5);
                        barArkaPlan.Size = new Size(maxBarWidth, 12);

                        int barWidth = (cevapSayisi * maxBarWidth) / maxCevap;

                        if (barWidth < 12)
                        {
                            barWidth = 12;
                        }

                        Panel barDolgu = new Panel();
                        barDolgu.BackColor = Color.FromArgb(128, 0, 170);
                        barDolgu.Location = new Point(80, y + 5);
                        barDolgu.Size = new Size(barWidth, 12);

                        Label lblSayi = new Label();
                        lblSayi.Text = cevapSayisi + " cevap";
                        lblSayi.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        lblSayi.ForeColor = Color.FromArgb(50, 50, 60);
                        lblSayi.Location = new Point(340, y - 1);
                        lblSayi.Size = new Size(90, 22);

                        pnlKatilimGrafik.Controls.Add(lblAy);
                        pnlKatilimGrafik.Controls.Add(barArkaPlan);
                        pnlKatilimGrafik.Controls.Add(barDolgu);
                        pnlKatilimGrafik.Controls.Add(lblSayi);
                        barDolgu.BringToFront();

                        y += 32;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Katılım istatistikleri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private string AyAdiniGetir(int ayNo)
        {
            switch (ayNo)
            {
                case 1: return "Oca";
                case 2: return "Şub";
                case 3: return "Mar";
                case 4: return "Nis";
                case 5: return "May";
                case 6: return "Haz";
                case 7: return "Tem";
                case 8: return "Ağu";
                case 9: return "Eyl";
                case 10: return "Eki";
                case 11: return "Kas";
                case 12: return "Ara";
                default: return "-";
            }
        }

        private void KategoriDagiliminiYukle()
        {
            pnlKategoriDagilim.Controls.Clear();

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = @"
                        SELECT 
                            k.kategori_adi AS Kategori,
                            COUNT(a.id) AS AnketSayisi
                        FROM kategoriler k
                        LEFT JOIN anketler a ON a.kategori_id = k.id
                        GROUP BY k.kategori_adi
                        ORDER BY AnketSayisi DESC";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(komut);
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);

                    Label baslik = new Label();
                    baslik.Text = "Kategori Dağılımı";
                    baslik.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    baslik.ForeColor = Color.FromArgb(30, 30, 45);
                    baslik.Location = new Point(20, 15);
                    baslik.AutoSize = true;
                    pnlKategoriDagilim.Controls.Add(baslik);

                    if (tablo.Rows.Count == 0)
                    {
                        Label bosMesaj = new Label();
                        bosMesaj.Text = "Kategori verisi bulunmamaktadır.";
                        bosMesaj.Font = new Font("Segoe UI", 9, FontStyle.Italic);
                        bosMesaj.ForeColor = Color.DimGray;
                        bosMesaj.Location = new Point(25, 60);
                        bosMesaj.AutoSize = true;
                        pnlKategoriDagilim.Controls.Add(bosMesaj);
                        return;
                    }

                    int toplamAnket = 0;

                    foreach (DataRow row in tablo.Rows)
                    {
                        toplamAnket += Convert.ToInt32(row["AnketSayisi"]);
                    }

                    if (toplamAnket == 0)
                    {
                        toplamAnket = 1;
                    }

                    Color[] renkler =
                    {
                        Color.FromArgb(128, 0, 170),
                        Color.FromArgb(240, 0, 130),
                        Color.FromArgb(60, 120, 220),
                        Color.FromArgb(245, 150, 0),
                        Color.FromArgb(40, 170, 120)
                    };

                    int y = 58;
                    int index = 0;
                    int maxBarWidth = 210;

                    foreach (DataRow row in tablo.Rows)
                    {
                        string kategori = row["Kategori"]?.ToString() ?? "";
                        int anketSayisi = Convert.ToInt32(row["AnketSayisi"]);
                        int yuzde = (anketSayisi * 100) / toplamAnket;

                        Color renk = renkler[index % renkler.Length];

                        Panel renkKutusu = new Panel();
                        renkKutusu.BackColor = renk;
                        renkKutusu.Location = new Point(30, y + 4);
                        renkKutusu.Size = new Size(10, 10);

                        Label lblKategori = new Label();
                        lblKategori.Text = kategori;
                        lblKategori.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                        lblKategori.ForeColor = renk;
                        lblKategori.Location = new Point(50, y - 2);
                        lblKategori.Size = new Size(110, 22);

                        Label lblBilgi = new Label();
                        lblBilgi.Text = anketSayisi + " anket  %" + yuzde;
                        lblBilgi.Font = new Font("Segoe UI", 9);
                        lblBilgi.ForeColor = Color.FromArgb(60, 60, 70);
                        lblBilgi.Location = new Point(165, y - 2);
                        lblBilgi.Size = new Size(130, 22);

                        Panel barArkaPlan = new Panel();
                        barArkaPlan.BackColor = Color.FromArgb(235, 235, 240);
                        barArkaPlan.Location = new Point(50, y + 20);
                        barArkaPlan.Size = new Size(maxBarWidth, 8);

                        int barWidth = (yuzde * maxBarWidth) / 100;

                        if (anketSayisi > 0 && barWidth < 10)
                        {
                            barWidth = 10;
                        }

                        Panel barDolgu = new Panel();
                        barDolgu.BackColor = renk;
                        barDolgu.Location = new Point(50, y + 20);
                        barDolgu.Size = new Size(barWidth, 8);

                        pnlKategoriDagilim.Controls.Add(renkKutusu);
                        pnlKategoriDagilim.Controls.Add(lblKategori);
                        pnlKategoriDagilim.Controls.Add(lblBilgi);
                        pnlKategoriDagilim.Controls.Add(barArkaPlan);
                        pnlKategoriDagilim.Controls.Add(barDolgu);

                        y += 42;
                        index++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategori dağılımı yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void IstatistikKartlariniYukle()
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string toplamAnketSorgu = "SELECT COUNT(*) FROM anketler";
                    MySqlCommand komutToplamAnket = new MySqlCommand(toplamAnketSorgu, baglanti);
                    lblToplamAnket.Text = komutToplamAnket.ExecuteScalar().ToString();

                    string toplamKullaniciSorgu = "SELECT COUNT(*) FROM kullanicilar";
                    MySqlCommand komutToplamKullanici = new MySqlCommand(toplamKullaniciSorgu, baglanti);
                    lblToplamKullanici.Text = komutToplamKullanici.ExecuteScalar().ToString();

                    string aktifKategoriSorgu = "SELECT COUNT(*) FROM kategoriler";
                    MySqlCommand komutAktifKategori = new MySqlCommand(aktifKategoriSorgu, baglanti);
                    lblAktifKategori.Text = komutAktifKategori.ExecuteScalar().ToString();

                    string bugunkuCevapSorgu = @"
                SELECT COUNT(*) 
                FROM cevaplar 
                WHERE DATE(tarih) = CURDATE()";

                    MySqlCommand komutBugunkuCevap = new MySqlCommand(bugunkuCevapSorgu, baglanti);
                    lblBugunkuCevap.Text = komutBugunkuCevap.ExecuteScalar().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("İstatistik kartları yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void txtAdminAra_TextChanged(object sender, EventArgs e)
        {
            SonOlusturulanAnketleriListele();
        }

        private void txtAdminAra_Enter(object sender, EventArgs e)
        {
            if (txtAdminAra.Text == "Ara...")
            {
                txtAdminAra.Text = "";
                txtAdminAra.ForeColor = Color.Black;
            }
        }

        private void txtAdminAra_Leave(object sender, EventArgs e)
        {
            if (txtAdminAra.Text.Trim() == "")
            {
                txtAdminAra.Text = "Ara...";
                txtAdminAra.ForeColor = Color.Gray;
            }
        }
    }
}
