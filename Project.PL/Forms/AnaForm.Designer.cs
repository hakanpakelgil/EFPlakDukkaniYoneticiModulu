namespace Project.PL.Forms
{
    partial class AnaForm
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
            dgvAlbumler = new DataGridView();
            lblFiltreBasligi = new Label();
            cboFilterler = new ComboBox();
            label2 = new Label();
            txtAlbumAdi = new TextBox();
            groupBox1 = new GroupBox();
            btnSanatciEkle = new Button();
            chbSatisDurum = new CheckBox();
            label8 = new Label();
            nudIndirim = new NumericUpDown();
            label7 = new Label();
            nudFiyat = new NumericUpDown();
            label6 = new Label();
            cboSanatcilar = new ComboBox();
            label5 = new Label();
            dtpCikisTarihi = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIndirim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).BeginInit();
            SuspendLayout();
            // 
            // dgvAlbumler
            // 
            dgvAlbumler.AllowUserToAddRows = false;
            dgvAlbumler.AllowUserToDeleteRows = false;
            dgvAlbumler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlbumler.Location = new Point(344, 120);
            dgvAlbumler.Name = "dgvAlbumler";
            dgvAlbumler.ReadOnly = true;
            dgvAlbumler.RowHeadersWidth = 62;
            dgvAlbumler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlbumler.Size = new Size(672, 665);
            dgvAlbumler.TabIndex = 0;
            dgvAlbumler.RowHeaderMouseClick += dgvAlbumler_RowHeaderMouseClick;
            // 
            // lblFiltreBasligi
            // 
            lblFiltreBasligi.AutoSize = true;
            lblFiltreBasligi.Location = new Point(357, 51);
            lblFiltreBasligi.Name = "lblFiltreBasligi";
            lblFiltreBasligi.Size = new Size(59, 25);
            lblFiltreBasligi.TabIndex = 1;
            lblFiltreBasligi.Text = "label1";
            // 
            // cboFilterler
            // 
            cboFilterler.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterler.FormattingEnabled = true;
            cboFilterler.Location = new Point(12, 43);
            cboFilterler.Name = "cboFilterler";
            cboFilterler.Size = new Size(300, 33);
            cboFilterler.TabIndex = 2;
            cboFilterler.SelectedIndexChanged += cboFilterler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 15);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 3;
            label2.Text = "Filtre";
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(21, 71);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(246, 31);
            txtAlbumAdi.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSanatciEkle);
            groupBox1.Controls.Add(chbSatisDurum);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(nudIndirim);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(nudFiyat);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboSanatcilar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpCikisTarihi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAlbumAdi);
            groupBox1.Location = new Point(12, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 550);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Albüm Bilgileri";
            // 
            // btnSanatciEkle
            // 
            btnSanatciEkle.Location = new Point(21, 207);
            btnSanatciEkle.Name = "btnSanatciEkle";
            btnSanatciEkle.Size = new Size(246, 34);
            btnSanatciEkle.TabIndex = 9;
            btnSanatciEkle.Text = "Yeni Sanatçı Ekle";
            btnSanatciEkle.UseVisualStyleBackColor = true;
            btnSanatciEkle.Click += btnSanatciEkle_Click;
            // 
            // chbSatisDurum
            // 
            chbSatisDurum.AutoSize = true;
            chbSatisDurum.Location = new Point(21, 501);
            chbSatisDurum.Name = "chbSatisDurum";
            chbSatisDurum.Size = new Size(149, 29);
            chbSatisDurum.TabIndex = 16;
            chbSatisDurum.Text = "Devam Ediyor";
            chbSatisDurum.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 473);
            label8.Name = "label8";
            label8.Size = new Size(119, 25);
            label8.TabIndex = 16;
            label8.Text = "Satış Durumu";
            // 
            // nudIndirim
            // 
            nudIndirim.DecimalPlaces = 2;
            nudIndirim.Location = new Point(21, 439);
            nudIndirim.Name = "nudIndirim";
            nudIndirim.Size = new Size(246, 31);
            nudIndirim.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 402);
            label7.Name = "label7";
            label7.Size = new Size(114, 25);
            label7.TabIndex = 14;
            label7.Text = "İndirim Fiyatı";
            // 
            // nudFiyat
            // 
            nudFiyat.DecimalPlaces = 2;
            nudFiyat.Location = new Point(21, 368);
            nudFiyat.Name = "nudFiyat";
            nudFiyat.Size = new Size(246, 31);
            nudFiyat.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 340);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 12;
            label6.Text = "Fiyat";
            // 
            // cboSanatcilar
            // 
            cboSanatcilar.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSanatcilar.FormattingEnabled = true;
            cboSanatcilar.Location = new Point(21, 157);
            cboSanatcilar.Name = "cboSanatcilar";
            cboSanatcilar.Size = new Size(246, 33);
            cboSanatcilar.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 267);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 10;
            label5.Text = "Çıkış Tarihi";
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(21, 295);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(246, 31);
            dtpCikisTarihi.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 129);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 8;
            label4.Text = "Sanatçılar/Grup";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 43);
            label3.Name = "label3";
            label3.Size = new Size(97, 25);
            label3.TabIndex = 6;
            label3.Text = "Albüm Adı";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(12, 671);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(300, 34);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(12, 711);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(300, 34);
            btnGuncelle.TabIndex = 7;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(12, 751);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(300, 34);
            btnSil.TabIndex = 8;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 952);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(cboFilterler);
            Controls.Add(lblFiltreBasligi);
            Controls.Add(dgvAlbumler);
            Name = "AnaForm";
            Text = "Ana Form";
            ((System.ComponentModel.ISupportInitialize)dgvAlbumler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIndirim).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlbumler;
        private Label lblFiltreBasligi;
        private ComboBox cboFilterler;
        private Label label2;
        private TextBox txtAlbumAdi;
        private GroupBox groupBox1;
        private Label label6;
        private ComboBox cboSanatcilar;
        private Label label5;
        private DateTimePicker dtpCikisTarihi;
        private Label label4;
        private Label label3;
        private CheckBox chbSatisDurum;
        private Label label8;
        private NumericUpDown nudIndirim;
        private Label label7;
        private NumericUpDown nudFiyat;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnSanatciEkle;
    }
}