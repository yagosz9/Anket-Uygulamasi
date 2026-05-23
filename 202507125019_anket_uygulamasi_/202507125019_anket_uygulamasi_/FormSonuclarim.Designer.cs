namespace _202507125019_anket_uygulamasi_
{
    partial class FormSonuclarim
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblBaslik = new Label();
            lblAciklama = new Label();
            dgvSonuclarim = new DataGridView();
            btnYenile = new Button();
            btnGeriDon = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSonuclarim).BeginInit();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = Color.FromArgb(35, 35, 45);
            lblBaslik.Location = new Point(35, 30);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(161, 37);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Sonuçlarım";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAciklama.ForeColor = Color.DimGray;
            lblAciklama.Location = new Point(40, 80);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(406, 17);
            lblAciklama.TabIndex = 1;
            lblAciklama.Text = "Cevap verdiğiniz anketler ve seçtiğiniz cevaplar bu ekranda listelenir.";
            // 
            // dgvSonuclarim
            // 
            dgvSonuclarim.AllowUserToAddRows = false;
            dgvSonuclarim.AllowUserToDeleteRows = false;
            dgvSonuclarim.AllowUserToResizeRows = false;
            dgvSonuclarim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSonuclarim.BackgroundColor = Color.White;
            dgvSonuclarim.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(64, 20, 90);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSonuclarim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSonuclarim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 0, 170);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSonuclarim.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSonuclarim.EnableHeadersVisualStyles = false;
            dgvSonuclarim.Location = new Point(40, 130);
            dgvSonuclarim.MultiSelect = false;
            dgvSonuclarim.Name = "dgvSonuclarim";
            dgvSonuclarim.ReadOnly = true;
            dgvSonuclarim.RowHeadersVisible = false;
            dgvSonuclarim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSonuclarim.Size = new Size(800, 320);
            dgvSonuclarim.TabIndex = 2;
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
            // FormSonuclarim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(884, 561);
            Controls.Add(btnGeriDon);
            Controls.Add(btnYenile);
            Controls.Add(dgvSonuclarim);
            Controls.Add(lblAciklama);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormSonuclarim";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnketLab - Sonuçlarım\n";
            Load += FormSonuclarim_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSonuclarim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblAciklama;
        private DataGridView dgvSonuclarim;
        private Button btnYenile;
        private Button btnGeriDon;
    }
}