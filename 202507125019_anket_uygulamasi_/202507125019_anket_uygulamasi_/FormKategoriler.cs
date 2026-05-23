using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _202507125019_anket_uygulamasi_
{
    public partial class FormKategoriler : Form
    {
        string connectionString = "server=localhost;port=3307;database=anketlabdb;uid=root;pwd=;";

        int secilenKategoriId = 0;

        public FormKategoriler()
        {
            InitializeComponent();
        }

        private void FormKategoriler_Load(object sender, EventArgs e)
        {
            KategorileriListele();
        }

        private void KategorileriListele()
        {
            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = @"
                        SELECT 
                            id AS 'ID',
                            kategori_adi AS 'Kategori Adı'
                        FROM kategoriler
                        ORDER BY kategori_adi ASC";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sorgu, baglanti);
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);

                    dgvKategoriler.DataSource = tablo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategori listeleme hatası: " + ex.Message);
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text.Trim() == "")
            {
                MessageBox.Show("Kategori adı boş bırakılamaz.");
                return;
            }

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "INSERT INTO kategoriler (kategori_adi) VALUES (@kategoriAdi)";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@kategoriAdi", txtKategoriAdi.Text.Trim());

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kategori başarıyla eklendi.");

                    txtKategoriAdi.Clear();
                    secilenKategoriId = 0;
                    KategorileriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategori ekleme hatası: " + ex.Message);
                }
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                secilenKategoriId = Convert.ToInt32(dgvKategoriler.Rows[e.RowIndex].Cells["ID"].Value);
                txtKategoriAdi.Text = dgvKategoriler.Rows[e.RowIndex].Cells["Kategori Adı"].Value.ToString();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (secilenKategoriId == 0)
            {
                MessageBox.Show("Lütfen güncellenecek kategoriyi seçiniz.");
                return;
            }

            if (txtKategoriAdi.Text.Trim() == "")
            {
                MessageBox.Show("Kategori adı boş bırakılamaz.");
                return;
            }

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "UPDATE kategoriler SET kategori_adi = @kategoriAdi WHERE id = @id";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@kategoriAdi", txtKategoriAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@id", secilenKategoriId);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kategori başarıyla güncellendi.");

                    txtKategoriAdi.Clear();
                    secilenKategoriId = 0;
                    KategorileriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategori güncelleme hatası: " + ex.Message);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenKategoriId == 0)
            {
                MessageBox.Show("Lütfen silinecek kategoriyi seçiniz.");
                return;
            }

            DialogResult cevap = MessageBox.Show(
                "Seçilen kategoriyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (cevap != DialogResult.Yes)
            {
                return;
            }

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string kontrolSorgu = "SELECT COUNT(*) FROM anketler WHERE kategori_id = @id";
                    MySqlCommand kontrolKomut = new MySqlCommand(kontrolSorgu, baglanti);
                    kontrolKomut.Parameters.AddWithValue("@id", secilenKategoriId);

                    int kullanilanAnketSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                    if (kullanilanAnketSayisi > 0)
                    {
                        MessageBox.Show("Bu kategoriye bağlı anketler olduğu için kategori silinemez.");
                        return;
                    }

                    string sorgu = "DELETE FROM kategoriler WHERE id = @id";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", secilenKategoriId);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kategori başarıyla silindi.");

                    txtKategoriAdi.Clear();
                    secilenKategoriId = 0;
                    KategorileriListele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kategori silme hatası: " + ex.Message);
                }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}