namespace _202507125019_anket_uygulamasi_
{
    partial class FormKullaniciAnketleriGor
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
            lblBaslik = new Label();
            lblAciklama = new Label();
            dgvAnketler = new DataGridView();
            btnYenile = new Button();
            btnGeriDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAnketler).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.Location = new Point(35, 30);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(189, 37);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Anketleri Gör";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAciklama.ForeColor = Color.DimGray;
            lblAciklama.Location = new Point(40, 80);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(364, 17);
            lblAciklama.TabIndex = 1;
            lblAciklama.Text = "Sistemde bulunan anketleri bu ekrandan görüntüleyebilirsiniz.";
            // 
            // dgvAnketler
            // 
            dgvAnketler.AllowUserToAddRows = false;
            dgvAnketler.AllowUserToDeleteRows = false;
            dgvAnketler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnketler.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 20, 90);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAnketler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAnketler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 0, 170);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAnketler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAnketler.EnableHeadersVisualStyles = false;
            dgvAnketler.Location = new Point(40, 130);
            dgvAnketler.Name = "dgvAnketler";
            dgvAnketler.ReadOnly = true;
            dgvAnketler.RowHeadersVisible = false;
            dgvAnketler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnketler.Size = new Size(800, 320);
            dgvAnketler.TabIndex = 2;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.FromArgb(128, 0, 170);
            btnYenile.Cursor = Cursors.Hand;
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(40, 480);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(130, 40);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenile";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.FromArgb(80, 80, 90);
            btnGeriDon.Cursor = Cursors.Hand;
            btnGeriDon.FlatAppearance.BorderSize = 0;
            btnGeriDon.FlatStyle = FlatStyle.Flat;
            btnGeriDon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriDon.ForeColor = Color.White;
            btnGeriDon.Location = new Point(190, 480);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(130, 40);
            btnGeriDon.TabIndex = 4;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // FormKullaniciAnketleriGor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(884, 561);
            Controls.Add(btnGeriDon);
            Controls.Add(btnYenile);
            Controls.Add(dgvAnketler);
            Controls.Add(lblAciklama);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormKullaniciAnketleriGor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnketLab - Anketleri Gör";
            Load += FormKullaniciAnketleriGor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAnketler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblAciklama;
        private DataGridView dgvAnketler;
        private Button btnYenile;
        private Button btnGeriDon;
    }
}