namespace _202507125019_anket_uygulamasi_
{
    partial class FormSonuclar
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
            cmbAnketler = new ComboBox();
            lblAnketSec = new Label();
            dgvSonuclar = new DataGridView();
            btnGeriDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSonuclar).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.Location = new Point(35, 30);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(219, 37);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Anket Sonuçları";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAciklama.ForeColor = Color.DimGray;
            lblAciklama.Location = new Point(40, 80);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(396, 17);
            lblAciklama.TabIndex = 1;
            lblAciklama.Text = "Seçilen ankete ait cevap dağılımı ve kullanıcı cevapları görüntülenir.";
            // 
            // cmbAnketler
            // 
            cmbAnketler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnketler.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbAnketler.FormattingEnabled = true;
            cmbAnketler.Location = new Point(40, 165);
            cmbAnketler.Name = "cmbAnketler";
            cmbAnketler.Size = new Size(420, 25);
            cmbAnketler.TabIndex = 2;
            cmbAnketler.SelectedIndexChanged += cmbAnketler_SelectedIndexChanged;
            // 
            // lblAnketSec
            // 
            lblAnketSec.AutoSize = true;
            lblAnketSec.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnketSec.Location = new Point(40, 135);
            lblAnketSec.Name = "lblAnketSec";
            lblAnketSec.Size = new Size(72, 17);
            lblAnketSec.TabIndex = 3;
            lblAnketSec.Text = "Anket Seç:";
            // 
            // dgvSonuclar
            // 
            dgvSonuclar.AllowUserToAddRows = false;
            dgvSonuclar.AllowUserToDeleteRows = false;
            dgvSonuclar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSonuclar.BackgroundColor = Color.White;
            dgvSonuclar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSonuclar.Location = new Point(40, 230);
            dgvSonuclar.Name = "dgvSonuclar";
            dgvSonuclar.ReadOnly = true;
            dgvSonuclar.RowHeadersVisible = false;
            dgvSonuclar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSonuclar.Size = new Size(880, 270);
            dgvSonuclar.TabIndex = 4;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.FromArgb(80, 80, 90);
            btnGeriDon.Cursor = Cursors.Hand;
            btnGeriDon.FlatAppearance.BorderSize = 0;
            btnGeriDon.FlatStyle = FlatStyle.Flat;
            btnGeriDon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriDon.ForeColor = Color.White;
            btnGeriDon.Location = new Point(40, 520);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(140, 40);
            btnGeriDon.TabIndex = 5;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // FormSonuclar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(984, 573);
            Controls.Add(btnGeriDon);
            Controls.Add(dgvSonuclar);
            Controls.Add(lblAnketSec);
            Controls.Add(cmbAnketler);
            Controls.Add(lblAciklama);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSonuclar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnketLab - Sonuçlar";
            Load += FormSonuclar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSonuclar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblAciklama;
        private ComboBox cmbAnketler;
        private Label lblAnketSec;
        private DataGridView dgvSonuclar;
        private Button btnGeriDon;
    }
}