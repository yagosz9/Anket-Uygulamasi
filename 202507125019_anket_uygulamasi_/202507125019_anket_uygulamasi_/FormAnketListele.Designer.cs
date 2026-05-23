namespace _202507125019_anket_uygulamasi_
{
    partial class FormAnketListele
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
            txtAra = new TextBox();
            cmbKategoriFiltre = new ComboBox();
            btnYenile = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvAnketler = new DataGridView();
            txtYeniBaslik = new TextBox();
            lblAra = new Label();
            label1 = new Label();
            btnGeriDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnketler).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(35, 35, 45);
            lblBaslik.Location = new Point(30, 25);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(418, 37);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Anketleri Listele / Güncelle / Sil";
            // 
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAra.Location = new Point(30, 110);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(280, 25);
            txtAra.TabIndex = 1;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // cmbKategoriFiltre
            // 
            cmbKategoriFiltre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategoriFiltre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbKategoriFiltre.FormattingEnabled = true;
            cmbKategoriFiltre.Location = new Point(340, 110);
            cmbKategoriFiltre.Name = "cmbKategoriFiltre";
            cmbKategoriFiltre.Size = new Size(220, 25);
            cmbKategoriFiltre.TabIndex = 2;
            cmbKategoriFiltre.SelectedIndexChanged += cmbKategoriFiltre_SelectedIndexChanged;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.FromArgb(128, 0, 170);
            btnYenile.Cursor = Cursors.Hand;
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(590, 108);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(100, 35);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.FromArgb(60, 130, 220);
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.ForeColor = Color.White;
            btnGuncelle.Location = new Point(705, 108);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 35);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(190, 50, 70);
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(830, 108);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(90, 35);
            btnSil.TabIndex = 5;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // dgvAnketler
            // 
            dgvAnketler.AllowUserToAddRows = false;
            dgvAnketler.AllowUserToDeleteRows = false;
            dgvAnketler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnketler.BackgroundColor = Color.White;
            dgvAnketler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnketler.Location = new Point(30, 160);
            dgvAnketler.MultiSelect = false;
            dgvAnketler.Name = "dgvAnketler";
            dgvAnketler.ReadOnly = true;
            dgvAnketler.RowHeadersVisible = false;
            dgvAnketler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnketler.Size = new Size(900, 300);
            dgvAnketler.TabIndex = 6;
            dgvAnketler.CellClick += dgvAnketler_CellClick;
            // 
            // txtYeniBaslik
            // 
            txtYeniBaslik.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtYeniBaslik.Location = new Point(200, 495);
            txtYeniBaslik.Name = "txtYeniBaslik";
            txtYeniBaslik.Size = new Size(430, 25);
            txtYeniBaslik.TabIndex = 7;
            // 
            // lblAra
            // 
            lblAra.AutoSize = true;
            lblAra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAra.Location = new Point(30, 88);
            lblAra.Name = "lblAra";
            lblAra.Size = new Size(72, 17);
            lblAra.TabIndex = 8;
            lblAra.Text = "Anket Ara:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(200, 474);
            label1.Name = "label1";
            label1.Size = new Size(134, 17);
            label1.TabIndex = 9;
            label1.Text = "Seçilen Anket Başlığı:";
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.FromArgb(80, 80, 90);
            btnGeriDon.FlatStyle = FlatStyle.Flat;
            btnGeriDon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriDon.ForeColor = Color.White;
            btnGeriDon.Location = new Point(34, 489);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(120, 40);
            btnGeriDon.TabIndex = 10;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // FormAnketListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(984, 561);
            Controls.Add(btnGeriDon);
            Controls.Add(label1);
            Controls.Add(lblAra);
            Controls.Add(txtYeniBaslik);
            Controls.Add(dgvAnketler);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnYenile);
            Controls.Add(cmbKategoriFiltre);
            Controls.Add(txtAra);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAnketListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnketLab - Anketleri Listele";
            Load += FormAnketListele_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnketler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private TextBox txtAra;
        private ComboBox cmbKategoriFiltre;
        private Button btnYenile;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvAnketler;
        private TextBox txtYeniBaslik;
        private Label lblAra;
        private Label label1;
        private Button btnGeriDon;
    }
}