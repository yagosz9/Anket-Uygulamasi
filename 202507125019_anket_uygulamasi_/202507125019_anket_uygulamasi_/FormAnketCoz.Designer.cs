namespace _202507125019_anket_uygulamasi_
{
    partial class FormAnketCoz
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
            lblAnketSec = new Label();
            cmbAnketler = new ComboBox();
            lblSoruMetni = new Label();
            rbSecenek1 = new RadioButton();
            rbSecenek2 = new RadioButton();
            rbSecenek3 = new RadioButton();
            rbSecenek4 = new RadioButton();
            btnCevapKaydet = new Button();
            btnGeriDon = new Button();
            SuspendLayout();
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.Location = new Point(40, 30);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(202, 37);
            lblBaslik.TabIndex = 0;
            lblBaslik.Text = "Anket Cevapla";
            // 
            // lblAnketSec
            // 
            lblAnketSec.AutoSize = true;
            lblAnketSec.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblAnketSec.Location = new Point(40, 100);
            lblAnketSec.Name = "lblAnketSec";
            lblAnketSec.Size = new Size(72, 17);
            lblAnketSec.TabIndex = 1;
            lblAnketSec.Text = "Anket Seç:";
            // 
            // cmbAnketler
            // 
            cmbAnketler.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnketler.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cmbAnketler.FormattingEnabled = true;
            cmbAnketler.Location = new Point(40, 130);
            cmbAnketler.Name = "cmbAnketler";
            cmbAnketler.Size = new Size(420, 25);
            cmbAnketler.TabIndex = 2;
            cmbAnketler.SelectedIndexChanged += cmbAnketler_SelectedIndexChanged;
            // 
            // lblSoruMetni
            // 
            lblSoruMetni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSoruMetni.Location = new Point(40, 190);
            lblSoruMetni.Name = "lblSoruMetni";
            lblSoruMetni.Size = new Size(760, 60);
            lblSoruMetni.TabIndex = 3;
            lblSoruMetni.Text = "Soru burada görünecek.";
            // 
            // rbSecenek1
            // 
            rbSecenek1.AutoSize = true;
            rbSecenek1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rbSecenek1.Location = new Point(60, 270);
            rbSecenek1.Name = "rbSecenek1";
            rbSecenek1.Size = new Size(93, 24);
            rbSecenek1.TabIndex = 4;
            rbSecenek1.TabStop = true;
            rbSecenek1.Text = "Seçenek 1";
            rbSecenek1.UseVisualStyleBackColor = true;
            // 
            // rbSecenek2
            // 
            rbSecenek2.AutoSize = true;
            rbSecenek2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rbSecenek2.Location = new Point(60, 315);
            rbSecenek2.Name = "rbSecenek2";
            rbSecenek2.Size = new Size(93, 24);
            rbSecenek2.TabIndex = 5;
            rbSecenek2.TabStop = true;
            rbSecenek2.Text = "Seçenek 2";
            rbSecenek2.UseVisualStyleBackColor = true;
            // 
            // rbSecenek3
            // 
            rbSecenek3.AutoSize = true;
            rbSecenek3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rbSecenek3.Location = new Point(60, 360);
            rbSecenek3.Name = "rbSecenek3";
            rbSecenek3.Size = new Size(93, 24);
            rbSecenek3.TabIndex = 6;
            rbSecenek3.TabStop = true;
            rbSecenek3.Text = "Seçenek 3";
            rbSecenek3.UseVisualStyleBackColor = true;
            // 
            // rbSecenek4
            // 
            rbSecenek4.AutoSize = true;
            rbSecenek4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            rbSecenek4.Location = new Point(60, 405);
            rbSecenek4.Name = "rbSecenek4";
            rbSecenek4.Size = new Size(93, 24);
            rbSecenek4.TabIndex = 7;
            rbSecenek4.TabStop = true;
            rbSecenek4.Text = "Seçenek 4";
            rbSecenek4.UseVisualStyleBackColor = true;
            // 
            // btnCevapKaydet
            // 
            btnCevapKaydet.BackColor = Color.FromArgb(128, 0, 170);
            btnCevapKaydet.FlatAppearance.BorderSize = 0;
            btnCevapKaydet.FlatStyle = FlatStyle.Flat;
            btnCevapKaydet.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCevapKaydet.ForeColor = Color.White;
            btnCevapKaydet.Location = new Point(40, 480);
            btnCevapKaydet.Name = "btnCevapKaydet";
            btnCevapKaydet.Size = new Size(180, 45);
            btnCevapKaydet.TabIndex = 8;
            btnCevapKaydet.Text = "Cevabı Kaydet";
            btnCevapKaydet.UseVisualStyleBackColor = false;
            btnCevapKaydet.Click += btnCevapKaydet_Click;
            // 
            // btnGeriDon
            // 
            btnGeriDon.BackColor = Color.FromArgb(80, 80, 90);
            btnGeriDon.FlatAppearance.BorderSize = 0;
            btnGeriDon.FlatStyle = FlatStyle.Flat;
            btnGeriDon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGeriDon.ForeColor = Color.White;
            btnGeriDon.Location = new Point(240, 480);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(140, 45);
            btnGeriDon.TabIndex = 9;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = false;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // FormAnketCoz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 252);
            ClientSize = new Size(884, 561);
            Controls.Add(btnGeriDon);
            Controls.Add(btnCevapKaydet);
            Controls.Add(rbSecenek4);
            Controls.Add(rbSecenek3);
            Controls.Add(rbSecenek2);
            Controls.Add(rbSecenek1);
            Controls.Add(lblSoruMetni);
            Controls.Add(cmbAnketler);
            Controls.Add(lblAnketSec);
            Controls.Add(lblBaslik);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAnketCoz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnketLab - Anket Çöz";
            Load += FormAnketCoz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBaslik;
        private Label lblAnketSec;
        private ComboBox cmbAnketler;
        private Label lblSoruMetni;
        private RadioButton rbSecenek1;
        private RadioButton rbSecenek2;
        private RadioButton rbSecenek3;
        private RadioButton rbSecenek4;
        private Button btnCevapKaydet;
        private Button btnGeriDon;
    }
}