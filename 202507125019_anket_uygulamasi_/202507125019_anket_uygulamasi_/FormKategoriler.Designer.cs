namespace _202507125019_anket_uygulamasi_
{
    partial class FormKategoriler
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKategoriler));
            lblBaslik = new Label();
            lblAciklama = new Label();
            lblKategoriAdi = new Label();
            txtKategoriAdi = new TextBox();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvKategoriler = new DataGridView();
            btnGeriDon = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(20, 35, 70);
            lblBaslik.Location = new Point(35, 30);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(163, 37);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Kategoriler";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.ForeColor = Color.DimGray;
            lblAciklama.Location = new Point(40, 80);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(399, 15);
            lblAciklama.TabIndex = 1;
            lblAciklama.Text = "Anket kategorilerini bu ekrandan ekleyebilir, güncelleyebilir ve silebilirsiniz.";
            // 
            // lblKategoriAdi
            // 
            lblKategoriAdi.AutoSize = true;
            lblKategoriAdi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblKategoriAdi.Location = new Point(40, 135);
            lblKategoriAdi.Name = "lblKategoriAdi";
            lblKategoriAdi.Size = new Size(89, 17);
            lblKategoriAdi.TabIndex = 2;
            lblKategoriAdi.Text = "Kategori Adı:";
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKategoriAdi.Location = new Point(40, 162);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(330, 25);
            txtKategoriAdi.TabIndex = 3;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.FromArgb(128, 0, 170);
            btnEkle.FlatAppearance.BorderSize = 0;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle.ForeColor = Color.White;
            btnEkle.Location = new Point(400, 155);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 40);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(60, 130, 220);
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(510, 155);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 40);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(195, 45, 65);
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(630, 155);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(90, 40);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // dgvKategoriler
            // 
            dgvKategoriler.AllowUserToAddRows = false;
            dgvKategoriler.AllowUserToDeleteRows = false;
            dgvKategoriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKategoriler.BackgroundColor = Color.White;
            dgvKategoriler.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 0, 170);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKategoriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKategoriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 120, 215);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvKategoriler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvKategoriler.EnableHeadersVisualStyles = false;
            dgvKategoriler.Location = new Point(40, 220);
            dgvKategoriler.MultiSelect = false;
            dgvKategoriler.Name = "dgvKategoriler";
            dgvKategoriler.ReadOnly = true;
            dgvKategoriler.RowHeadersVisible = false;
            dgvKategoriler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKategoriler.Size = new Size(680, 220);
            dgvKategoriler.TabIndex = 7;
            dgvKategoriler.CellClick += dgvKategoriler_CellClick;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.FromArgb(90, 90, 110);
            btnGeriDon.FlatAppearance.BorderSize = 0;
            btnGeriDon.FlatStyle = FlatStyle.Flat;
            btnGeriDon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriDon.ForeColor = Color.White;
            btnGeriDon.Location = new Point(40, 460);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(130, 40);
            btnGeriDon.TabIndex = 8;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(192, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FormKategoriler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 248);
            ClientSize = new Size(784, 511);
            Controls.Add(pictureBox1);
            Controls.Add(btnGeriDon);
            Controls.Add(dgvKategoriler);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(txtKategoriAdi);
            Controls.Add(lblKategoriAdi);
            Controls.Add(lblAciklama);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormKategoriler";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnketLab - Kategoriler";
            Load += FormKategoriler_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKategoriler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblAciklama;
        private Label lblKategoriAdi;
        private TextBox txtKategoriAdi;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvKategoriler;
        private Button btnGeriDon;
        private PictureBox pictureBox1;
    }
}