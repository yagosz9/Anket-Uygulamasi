using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _202507125019_anket_uygulamasi_
{
    public partial class FormAnketListele : Form
    {
        string connectionString = "server=localhost;port=3307;database=anketlabdb;uid=root;pwd=;";

        public FormAnketListele()
        {
            InitializeComponent();
            KategorileriYukle();
            AnketleriListele();
        }

        private void FormAnketListele_Load(object sender, EventArgs e)
        {
            AnketleriListele();
        }

        private void KategorileriYukle()
        {
            cmbKategoriFiltre.Items.Clear();
            cmbKategoriFiltre.Items.Add("Tüm Kategoriler");

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "SELECT kategori_adi FROM kategoriler";
                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    MySqlDataReader okuyucu = komut.ExecuteReader();

                    while (okuyucu.Read())
                    {
                        cmbKategoriFiltre.Items.Add(okuyucu["kategori_adi"].ToString());
                    }

                    cmbKategoriFiltre.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategori yükleme hatası: " + ex.Message);
                }
            }
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
                        a.tarih AS 'Tarih'
                    FROM anketler a
                    INNER JOIN kategoriler k ON a.kategori_id = k.id
                    WHERE a.baslik LIKE @arama";

                    if (cmbKategoriFiltre.SelectedItem != null &&
                        cmbKategoriFiltre.SelectedItem.ToString() != "Tüm Kategoriler")
                    {
                        sorgu += " AND k.kategori_adi = @kategori";
                    }

                    sorgu += " ORDER BY a.tarih DESC";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@arama", "%" + txtAra.Text.Trim() + "%");

                    if (cmbKategoriFiltre.SelectedItem != null &&
                        cmbKategoriFiltre.SelectedItem.ToString() != "Tüm Kategoriler")
                    {
                        komut.Parameters.AddWithValue("@kategori", cmbKategoriFiltre.SelectedItem.ToString());
                    }

                    MySqlDataAdapter adapter = new MySqlDataAdapter(komut);
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);

                    dgvAnketler.DataSource = tablo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Anket listeleme hatası: " + ex.Message);
                }
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            AnketleriListele();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            AnketleriListele();
        }

        private void cmbKategoriFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnketleriListele();
        }

        private void dgvAnketler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtYeniBaslik.Text = dgvAnketler.Rows[e.RowIndex].Cells["Anket Başlığı"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvAnketler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek anketi seçiniz.");
                return;
            }

            if (txtYeniBaslik.Text.Trim() == "")
            {
                MessageBox.Show("Anket başlığı boş bırakılamaz.");
                return;
            }

            int anketId = Convert.ToInt32(dgvAnketler.SelectedRows[0].Cells["ID"].Value);

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "UPDATE anketler SET baslik = @baslik WHERE id = @id";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@baslik", txtYeniBaslik.Text.Trim());
                    komut.Parameters.AddWithValue("@id", anketId);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Anket başlığı başarıyla güncellendi.");

                    txtYeniBaslik.Clear();
                    AnketleriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Güncelleme hatası: " + ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvAnketler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek anketi seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show(
                "Seçilen anketi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (cevap != DialogResult.Yes)
            {
                return;
            }

            int anketId = Convert.ToInt32(dgvAnketler.SelectedRows[0].Cells["ID"].Value);

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    MySqlTransaction transaction = baglanti.BeginTransaction();

                    try
                    {
                        string secenekSil = @"
                        DELETE s2 FROM secenekler s2
                        INNER JOIN sorular s ON s2.soru_id = s.id
                        WHERE s.anket_id = @anketId";

                        MySqlCommand komutSecenekSil = new MySqlCommand(secenekSil, baglanti, transaction);
                        komutSecenekSil.Parameters.AddWithValue("@anketId", anketId);
                        komutSecenekSil.ExecuteNonQuery();

                        string soruSil = "DELETE FROM sorular WHERE anket_id = @anketId";
                        MySqlCommand komutSoruSil = new MySqlCommand(soruSil, baglanti, transaction);
                        komutSoruSil.Parameters.AddWithValue("@anketId", anketId);
                        komutSoruSil.ExecuteNonQuery();

                        string anketSil = "DELETE FROM anketler WHERE id = @anketId";
                        MySqlCommand komutAnketSil = new MySqlCommand(anketSil, baglanti, transaction);
                        komutAnketSil.Parameters.AddWithValue("@anketId", anketId);
                        komutAnketSil.ExecuteNonQuery();

                        transaction.Commit();

                        MessageBox.Show("Anket başarıyla silindi.");

                        txtYeniBaslik.Clear();
                        AnketleriListele();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Silme sırasında hata oluştu: " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
                }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}