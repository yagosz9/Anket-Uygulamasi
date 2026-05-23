namespace _202507125019_anket_uygulamasi_
{
    partial class FormAnketOlustur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBaslik = new Label();
            lblAciklama = new Label();
            pnlAnketBilgileri = new Panel();
            btnGeriDon = new Button();
            btnAnketKaydet = new Button();
            txtSecenek4 = new TextBox();
            txtSecenek3 = new TextBox();
            txtSecenek2 = new TextBox();
            txtSecenek1 = new TextBox();
            lblSecenekler = new Label();
            txtSoruMetni = new TextBox();
            lblSoru = new Label();
            cmbKategori = new ComboBox();
            lblKategori = new Label();
            txtAnketBasligi = new TextBox();
            lblAnketBasligi = new Label();
            pnlAnketBilgileri.SuspendLayout();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(35, 35, 45);
            lblBaslik.Location = new Point(40, 30);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(273, 40);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Yeni Anket Oluştur";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAciklama.ForeColor = Color.DimGray;
            lblAciklama.Location = new Point(45, 80);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(482, 17);
            lblAciklama.TabIndex = 1;
            lblAciklama.Text = "Anket başlığını, kategorisini ve sorularını ekleyerek yeni bir anket oluşturabilirsiniz.";
            // 
            // pnlAnketBilgileri
            // 
            pnlAnketBilgileri.BackColor = Color.White;
            pnlAnketBilgileri.BorderStyle = BorderStyle.FixedSingle;
            pnlAnketBilgileri.Controls.Add(btnGeriDon);
            pnlAnketBilgileri.Controls.Add(btnAnketKaydet);
            pnlAnketBilgileri.Controls.Add(txtSecenek4);
            pnlAnketBilgileri.Controls.Add(txtSecenek3);
            pnlAnketBilgileri.Controls.Add(txtSecenek2);
            pnlAnketBilgileri.Controls.Add(txtSecenek1);
            pnlAnketBilgileri.Controls.Add(lblSecenekler);
            pnlAnketBilgileri.Controls.Add(txtSoruMetni);
            pnlAnketBilgileri.Controls.Add(lblSoru);
            pnlAnketBilgileri.Controls.Add(cmbKategori);
            pnlAnketBilgileri.Controls.Add(lblKategori);
            pnlAnketBilgileri.Controls.Add(txtAnketBasligi);
            pnlAnketBilgileri.Controls.Add(lblAnketBasligi);
            pnlAnketBilgileri.Location = new Point(40, 120);
            pnlAnketBilgileri.Name = "pnlAnketBilgileri";
            pnlAnketBilgileri.Size = new Size(812, 392);
            pnlAnketBilgileri.TabIndex = 2;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.FromArgb(80, 80, 90);
            btnGeriDon.Cursor = Cursors.Hand;
            btnGeriDon.FlatAppearance.BorderSize = 0;
            btnGeriDon.FlatStyle = FlatStyle.Flat;
            btnGeriDon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriDon.ForeColor = Color.White;
            btnGeriDon.Location = new Point(590, 326);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(150, 45);
            btnGeriDon.TabIndex = 12;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // btnAnketKaydet
            // 
            btnAnketKaydet.BackColor = Color.FromArgb(128, 0, 170);
            btnAnketKaydet.Cursor = Cursors.Hand;
            btnAnketKaydet.FlatAppearance.BorderSize = 0;
            btnAnketKaydet.FlatStyle = FlatStyle.Flat;
            btnAnketKaydet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAnketKaydet.ForeColor = Color.White;
            btnAnketKaydet.Location = new Point(30, 325);
            btnAnketKaydet.Name = "btnAnketKaydet";
            btnAnketKaydet.Size = new Size(180, 45);
            btnAnketKaydet.TabIndex = 11;
            btnAnketKaydet.Text = "Anketi Kaydet";
            btnAnketKaydet.UseVisualStyleBackColor = false;
            btnAnketKaydet.Click += btnAnketKaydet_Click;
            // 
            // txtSecenek4
            // 
            txtSecenek4.Location = new Point(410, 280);
            txtSecenek4.Multiline = true;
            txtSecenek4.Name = "txtSecenek4";
            txtSecenek4.Size = new Size(330, 30);
            txtSecenek4.TabIndex = 10;
            txtSecenek4.Text = "Kararsızım";
            // 
            // txtSecenek3
            // 
            txtSecenek3.Location = new Point(30, 280);
            txtSecenek3.Multiline = true;
            txtSecenek3.Name = "txtSecenek3";
            txtSecenek3.Size = new Size(330, 30);
            txtSecenek3.TabIndex = 9;
            txtSecenek3.Text = "Kısmen";
            // 
            // txtSecenek2
            // 
            txtSecenek2.Location = new Point(410, 235);
            txtSecenek2.Multiline = true;
            txtSecenek2.Name = "txtSecenek2";
            txtSecenek2.Size = new Size(330, 30);
            txtSecenek2.TabIndex = 8;
            txtSecenek2.Text = "Hayır";
            // 
            // txtSecenek1
            // 
            txtSecenek1.Location = new Point(30, 235);
            txtSecenek1.Multiline = true;
            txtSecenek1.Name = "txtSecenek1";
            txtSecenek1.Size = new Size(330, 30);
            txtSecenek1.TabIndex = 7;
            txtSecenek1.Text = "Evet";
            // 
            // lblSecenekler
            // 
            lblSecenekler.AutoSize = true;
            lblSecenekler.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSecenekler.ForeColor = Color.FromArgb(35, 35, 45);
            lblSecenekler.Location = new Point(30, 205);
            lblSecenekler.Name = "lblSecenekler";
            lblSecenekler.Size = new Size(118, 17);
            lblSecenekler.TabIndex = 6;
            lblSecenekler.Text = "Cevap Seçenekleri";
            // 
            // txtSoruMetni
            // 
            txtSoruMetni.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoruMetni.Location = new Point(30, 150);
            txtSoruMetni.Multiline = true;
            txtSoruMetni.Name = "txtSoruMetni";
            txtSoruMetni.Size = new Size(710, 30);
            txtSoruMetni.TabIndex = 5;
            // 
            // lblSoru
            // 
            lblSoru.AutoSize = true;
            lblSoru.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSoru.ForeColor = Color.FromArgb(35, 35, 45);
            lblSoru.Location = new Point(30, 120);
            lblSoru.Name = "lblSoru";
            lblSoru.Size = new Size(76, 17);
            lblSoru.TabIndex = 4;
            lblSoru.Text = "Soru Metni";
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Items.AddRange(new object[] { "Eğitim", "Spor", "Teknoloji", "Sosyal" });
            cmbKategori.Location = new Point(420, 60);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(320, 25);
            cmbKategori.TabIndex = 3;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lblKategori
            // 
            lblKategori.AutoSize = true;
            lblKategori.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKategori.ForeColor = Color.FromArgb(35, 35, 45);
            lblKategori.Location = new Point(420, 30);
            lblKategori.Name = "lblKategori";
            lblKategori.Size = new Size(60, 17);
            lblKategori.TabIndex = 2;
            lblKategori.Text = "Kategori";
            // 
            // txtAnketBasligi
            // 
            txtAnketBasligi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAnketBasligi.Location = new Point(30, 60);
            txtAnketBasligi.Multiline = true;
            txtAnketBasligi.Name = "txtAnketBasligi";
            txtAnketBasligi.PlaceholderText = "Örn: Öğrenci Memnuniyet Anketi";
            txtAnketBasligi.Size = new Size(350, 30);
            txtAnketBasligi.TabIndex = 1;
            // 
            // lblAnketBasligi
            // 
            lblAnketBasligi.AutoSize = true;
            lblAnketBasligi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnketBasligi.ForeColor = Color.FromArgb(35, 35, 45);
            lblAnketBasligi.Location = new Point(30, 30);
            lblAnketBasligi.Name = "lblAnketBasligi";
            lblAnketBasligi.Size = new Size(89, 17);
            lblAnketBasligi.TabIndex = 0;
            lblAnketBasligi.Text = "Anket Başlığı";
            // 
            // FormAnketOlustur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(884, 561);
            Controls.Add(pnlAnketBilgileri);
            Controls.Add(lblAciklama);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAnketOlustur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnketLab - Anket Oluştur";
            Load += FormAnketOlustur_Load;
            pnlAnketBilgileri.ResumeLayout(false);
            pnlAnketBilgileri.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblAciklama;
        private Panel pnlAnketBilgileri;
        private Label lblKategori;
        private TextBox txtAnketBasligi;
        private Label lblAnketBasligi;
        private TextBox txtSecenek4;
        private TextBox txtSecenek3;
        private TextBox txtSecenek2;
        private TextBox txtSecenek1;
        private Label lblSecenekler;
        private TextBox txtSoruMetni;
        private Label lblSoru;
        private ComboBox cmbKategori;
        private Button btnGeriDon;
        private Button btnAnketKaydet;
    }
}