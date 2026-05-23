using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _202507125019_anket_uygulamasi_
{
    public partial class FormAnketOlustur : Form
    {
        string connectionString = "server=localhost;port=3307;database=anketlabdb;uid=root;pwd=;";

        public FormAnketOlustur()
        {
            InitializeComponent();
            KategorileriYukle();
        }

        private void FormAnketOlustur_Load(object sender, EventArgs e)
        {

        }

        private void KategorileriYukle()
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "SELECT id, kategori_adi FROM kategoriler";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    MySqlDataReader okuyucu = komut.ExecuteReader();

                    cmbKategori.Items.Clear();

                    while (okuyucu.Read())
                    {
                        cmbKategori.Items.Add(new ComboBoxItem
                        {
                            Text = okuyucu["kategori_adi"]?.ToString() ?? "",
                            Value = Convert.ToInt32(okuyucu["id"])
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategori yükleme hatası: " + ex.Message);
                }
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKategori.SelectedItem == null)
            {
                return;
            }

            ComboBoxItem secilenKategori = (ComboBoxItem)cmbKategori.SelectedItem;
            string kategoriAdi = secilenKategori.Text;

            KategoriyeGoreSecenekleriDoldur(kategoriAdi);
        }

        private void KategoriyeGoreSecenekleriDoldur(string kategoriAdi)
        {
            kategoriAdi = kategoriAdi.ToLower();

            if (kategoriAdi.Contains("eğitim") || kategoriAdi.Contains("egitim"))
            {
                txtSecenek1.Text = "Kesinlikle Katılıyorum";
                txtSecenek2.Text = "Katılıyorum";
                txtSecenek3.Text = "Katılmıyorum";
                txtSecenek4.Text = "Fikrim Yok";
            }
            else if (kategoriAdi.Contains("spor"))
            {
                txtSecenek1.Text = "Evet, katılırım";
                txtSecenek2.Text = "Hayır, katılmam";
                txtSecenek3.Text = "İzleyici olarak gelirim";
                txtSecenek4.Text = "Kararsızım";
            }
            else if (kategoriAdi.Contains("teknoloji"))
            {
                txtSecenek1.Text = "Telefon";
                txtSecenek2.Text = "Bilgisayar";
                txtSecenek3.Text = "Tablet";
                txtSecenek4.Text = "Akıllı Saat";
            }
            else if (kategoriAdi.Contains("sosyal"))
            {
                txtSecenek1.Text = "Evet";
                txtSecenek2.Text = "Hayır";
                txtSecenek3.Text = "Bazen";
                txtSecenek4.Text = "Fikrim Yok";
            }
            else if (kategoriAdi.Contains("memnuniyet"))
            {
                txtSecenek1.Text = "Çok Memnunum";
                txtSecenek2.Text = "Memnunum";
                txtSecenek3.Text = "Memnun Değilim";
                txtSecenek4.Text = "Kararsızım";
            }
            else
            {
                txtSecenek1.Text = "Evet";
                txtSecenek2.Text = "Hayır";
                txtSecenek3.Text = "Kısmen";
                txtSecenek4.Text = "Kararsızım";
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnketKaydet_Click(object sender, EventArgs e)
        {
            if (txtAnketBasligi.Text.Trim() == "" ||
                cmbKategori.SelectedItem == null ||
                txtSoruMetni.Text.Trim() == "" ||
                txtSecenek1.Text.Trim() == "" ||
                txtSecenek2.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen anket başlığı, kategori, soru ve en az iki seçenek giriniz.");
                return;
            }

            ComboBoxItem secilenKategori = (ComboBoxItem)cmbKategori.SelectedItem;
            int kategoriId = secilenKategori.Value;

            int olusturanId = 1; // Şimdilik admin kullanıcının id değeri

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    MySqlTransaction transaction = baglanti.BeginTransaction();

                    try
                    {
                        string anketSorgu = @"INSERT INTO anketler 
                                             (baslik, kategori_id, olusturan_id) 
                                             VALUES 
                                             (@baslik, @kategoriId, @olusturanId);
                                             SELECT LAST_INSERT_ID();";

                        MySqlCommand anketKomut = new MySqlCommand(anketSorgu, baglanti, transaction);
                        anketKomut.Parameters.AddWithValue("@baslik", txtAnketBasligi.Text.Trim());
                        anketKomut.Parameters.AddWithValue("@kategoriId", kategoriId);
                        anketKomut.Parameters.AddWithValue("@olusturanId", olusturanId);

                        int anketId = Convert.ToInt32(anketKomut.ExecuteScalar());

                        string soruSorgu = @"INSERT INTO sorular 
                                            (anket_id, soru_metni) 
                                            VALUES 
                                            (@anketId, @soruMetni);
                                            SELECT LAST_INSERT_ID();";

                        MySqlCommand soruKomut = new MySqlCommand(soruSorgu, baglanti, transaction);
                        soruKomut.Parameters.AddWithValue("@anketId", anketId);
                        soruKomut.Parameters.AddWithValue("@soruMetni", txtSoruMetni.Text.Trim());

                        int soruId = Convert.ToInt32(soruKomut.ExecuteScalar());

                        string secenekSorgu = @"INSERT INTO secenekler 
                                               (soru_id, secenek_metni) 
                                               VALUES 
                                               (@soruId, @secenekMetni)";

                        string[] secenekler =
                        {
                            txtSecenek1.Text.Trim(),
                            txtSecenek2.Text.Trim(),
                            txtSecenek3.Text.Trim(),
                            txtSecenek4.Text.Trim()
                        };

                        foreach (string secenek in secenekler)
                        {
                            if (secenek != "")
                            {
                                MySqlCommand secenekKomut = new MySqlCommand(secenekSorgu, baglanti, transaction);
                                secenekKomut.Parameters.AddWithValue("@soruId", soruId);
                                secenekKomut.Parameters.AddWithValue("@secenekMetni", secenek);
                                secenekKomut.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        MessageBox.Show("Anket başarıyla veritabanına kaydedildi.");

                        txtAnketBasligi.Clear();
                        txtSoruMetni.Clear();
                        txtSecenek1.Clear();
                        txtSecenek2.Clear();
                        txtSecenek3.Clear();
                        txtSecenek4.Clear();
                        cmbKategori.SelectedIndex = -1;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
                }
            }
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}