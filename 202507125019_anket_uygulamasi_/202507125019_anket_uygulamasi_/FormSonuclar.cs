using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _202507125019_anket_uygulamasi_
{
    public partial class FormSonuclar : Form
    {
        string connectionString = "server=localhost;port=3307;database=anketlabdb;uid=root;pwd=;";

        public FormSonuclar()
        {
            InitializeComponent();
        }

        private void FormSonuclar_Load(object sender, EventArgs e)
        {
            AnketleriYukle();
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
                        cmbAnketler.Items.Add(new SonucComboBoxItem
                        {
                            Text = okuyucu["baslik"].ToString(),
                            Value = Convert.ToInt32(okuyucu["id"])
                        });
                    }
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

            SonucComboBoxItem secilenAnket = (SonucComboBoxItem)cmbAnketler.SelectedItem;
            int anketId = secilenAnket.Value;

            SonuclariListele(anketId);
        }

        private void SonuclariListele(int anketId)
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = @"
                        SELECT 
                            s.soru_metni AS 'Soru',
                            c.cevap AS 'Verilen Cevap',
                            COUNT(c.cevap) AS 'Cevap Sayısı'
                        FROM cevaplar c
                        INNER JOIN sorular s ON c.soru_id = s.id
                        WHERE s.anket_id = @anketId
                        GROUP BY s.soru_metni, c.cevap
                        ORDER BY COUNT(c.cevap) DESC";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@anketId", anketId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(komut);
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);

                    dgvSonuclar.DataSource = tablo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sonuç listeleme hatası: " + ex.Message);
                }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private class SonucComboBoxItem
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