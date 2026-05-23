using MySql.Data.MySqlClient;
namespace _202507125019_anket_uygulamasi_
{
    public partial class FormLogin : Form

    {
        string connectionString = "server=localhost;port=3307;database=anketlabdb;uid=root;pwd=;";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (kullaniciAdi == "" || sifre == "")
            {
                MessageBox.Show("Lütfen kullanýcý adý ve þifre alanlarýný doldurunuz.");
                return;
            }

            using (MySqlConnection baglanti = new MySqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sorgu = "SELECT rol FROM kullanicilar WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";

                    MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", sifre);

                    object sonuc = komut.ExecuteScalar();

                    if (sonuc != null)
                    {
                        string rol = sonuc.ToString();

                        if (rol == "Admin")
                        {
                            MessageBox.Show("Admin giriþi baþarýlý.");

                            FormAdminDashboard adminPanel = new FormAdminDashboard();
                            adminPanel.Show();
                            this.Hide();
                        }
                        else if (rol == "User")
                        {
                            MessageBox.Show("Kullanýcý giriþi baþarýlý.");

                            FormUserDashboard userPanel = new FormUserDashboard();
                            userPanel.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanýcý adý veya þifre hatalý.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabaný baðlantý hatasý: " + ex.Message);
                }
            }
        }

        private void pnlSol_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}