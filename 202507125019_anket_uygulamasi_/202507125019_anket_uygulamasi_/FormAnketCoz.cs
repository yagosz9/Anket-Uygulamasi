using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _202507125019_anket_uygulamasi_
{
    public partial class FormAnketCoz : Form
    {
        string connectionString = "server=localhost;port=3307;database=anketlabdb;uid=root;pwd=;";

        int seciliAnketId = 0;
        int seciliSoruId = 0;

       
        int kullaniciId = 2;

        public FormAnketCoz()
        {
            InitializeComponent();
        }

        private void FormAnketCoz_Load(object sender, EventArgs e)
        {
            AnketleriYukle();
            SecenekleriGizle();
        }

        private void AnketleriYukle()
        {
            cmbAnketler.Items.Clear();

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "SELECT id, baslik FROM anketler ORDER BY tarih DESC";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    MySqlDataReader okuyucu = komut.ExecuteReader();

                    while (okuyucu.Read())
                    {
                        cmbAnketler.Items.Add(new AnketCozComboBoxItem
                        {
                            Text = okuyucu["baslik"].ToString(),
                            Value = Convert.ToInt32(okuyucu["id"])
                        });
                    }

                    okuyucu.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anket yükleme hatası: " + ex.Message);
                }
            }
        }

        private void cmbAnketler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAnketler.SelectedItem == null)
            {
                return;
            }

            AnketCozComboBoxItem secilenAnket = (AnketCozComboBoxItem)cmbAnketler.SelectedItem;
            seciliAnketId = secilenAnket.Value;

            SoruyuVeSecenekleriYukle(seciliAnketId);
        }

        private void SoruyuVeSecenekleriYukle(int anketId)
        {
            SecenekleriGizle();

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string soruSorgu = @"
                        SELECT id, soru_metni 
                        FROM sorular 
                        WHERE anket_id = @anketId 
                        LIMIT 1";

                    MySqlCommand soruKomut = new MySqlCommand(soruSorgu, baglanti);
                    soruKomut.Parameters.AddWithValue("@anketId", anketId);

                    MySqlDataReader soruOkuyucu = soruKomut.ExecuteReader();

                    if (soruOkuyucu.Read())
                    {
                        seciliSoruId = Convert.ToInt32(soruOkuyucu["id"]);
                        lblSoruMetni.Text = soruOkuyucu["soru_metni"].ToString();
                    }
                    else
                    {
                        seciliSoruId = 0;
                        lblSoruMetni.Text = "Bu ankete ait soru bulunamadı.";
                        soruOkuyucu.Close();
                        return;
                    }

                    soruOkuyucu.Close();

                    string secenekSorgu = @"
                        SELECT secenek_metni 
                        FROM secenekler 
                        WHERE soru_id = @soruId
                        ORDER BY id ASC";

                    MySqlCommand secenekKomut = new MySqlCommand(secenekSorgu, baglanti);
                    secenekKomut.Parameters.AddWithValue("@soruId", seciliSoruId);

                    MySqlDataReader secenekOkuyucu = secenekKomut.ExecuteReader();

                    RadioButton[] secenekRadio =
                    {
                        rbSecenek1,
                        rbSecenek2,
                        rbSecenek3,
                        rbSecenek4
                    };

                    int index = 0;

                    while (secenekOkuyucu.Read() && index < secenekRadio.Length)
                    {
                        secenekRadio[index].Text = secenekOkuyucu["secenek_metni"].ToString();
                        secenekRadio[index].Visible = true;
                        secenekRadio[index].Checked = false;
                        index++;
                    }

                    secenekOkuyucu.Close();

                    if (index == 0)
                    {
                        lblSoruMetni.Text = "Bu soruya ait cevap seçeneği bulunamadı.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Soru ve seçenek yükleme hatası: " + ex.Message);
                }
            }
        }

        private bool DahaOnceCevapVerdiMi(int soruId, int kullaniciId)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = @"
                        SELECT COUNT(*) 
                        FROM cevaplar 
                        WHERE soru_id = @soruId 
                        AND kullanici_id = @kullaniciId";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@soruId", soruId);
                    komut.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    int cevapSayisi = Convert.ToInt32(komut.ExecuteScalar());

                    return cevapSayisi > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cevap kontrol hatası: " + ex.Message);
                    return false;
                }
            }
        }

        private void btnCevapKaydet_Click(object sender, EventArgs e)
        {
            if (seciliSoruId == 0)
            {
                MessageBox.Show("Lütfen önce bir anket seçiniz.");
                return;
            }

            string secilenCevap = "";

            if (rbSecenek1.Checked)
            {
                secilenCevap = rbSecenek1.Text;
            }
            else if (rbSecenek2.Checked)
            {
                secilenCevap = rbSecenek2.Text;
            }
            else if (rbSecenek3.Checked)
            {
                secilenCevap = rbSecenek3.Text;
            }
            else if (rbSecenek4.Checked)
            {
                secilenCevap = rbSecenek4.Text;
            }

            if (secilenCevap == "")
            {
                MessageBox.Show("Lütfen bir cevap seçiniz.");
                return;
            }

            if (DahaOnceCevapVerdiMi(seciliSoruId, kullaniciId))
            {
                MessageBox.Show("Bu ankete daha önce cevap verdiniz. Aynı ankete tekrar cevap veremezsiniz.");
                return;
            }

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = @"
                        INSERT INTO cevaplar 
                        (soru_id, kullanici_id, cevap) 
                        VALUES 
                        (@soruId, @kullaniciId, @cevap)";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@soruId", seciliSoruId);
                    komut.Parameters.AddWithValue("@kullaniciId", kullaniciId);
                    komut.Parameters.AddWithValue("@cevap", secilenCevap);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Cevabınız başarıyla kaydedildi.");

                    rbSecenek1.Checked = false;
                    rbSecenek2.Checked = false;
                    rbSecenek3.Checked = false;
                    rbSecenek4.Checked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cevap kaydetme hatası: " + ex.Message);
                }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SecenekleriGizle()
        {
            seciliSoruId = 0;

            lblSoruMetni.Text = "Soru burada görünecek.";

            rbSecenek1.Text = "";
            rbSecenek2.Text = "";
            rbSecenek3.Text = "";
            rbSecenek4.Text = "";

            rbSecenek1.Visible = false;
            rbSecenek2.Visible = false;
            rbSecenek3.Visible = false;
            rbSecenek4.Visible = false;

            rbSecenek1.Checked = false;
            rbSecenek2.Checked = false;
            rbSecenek3.Checked = false;
            rbSecenek4.Checked = false;
        }

        private class AnketCozComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}