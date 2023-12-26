namespace Project.PL.Forms
{
    partial class GirisForm
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
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            label1 = new Label();
            label2 = new Label();
            btnYeniKayit = new Button();
            SuspendLayout();
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(254, 125);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(352, 31);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(254, 188);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(352, 31);
            txtSifre.TabIndex = 1;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(254, 264);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(352, 34);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 128);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(161, 194);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "Şifresi";
            // 
            // btnYeniKayit
            // 
            btnYeniKayit.Location = new Point(254, 333);
            btnYeniKayit.Name = "btnYeniKayit";
            btnYeniKayit.Size = new Size(352, 34);
            btnYeniKayit.TabIndex = 5;
            btnYeniKayit.Text = "Kayıt Ekle";
            btnYeniKayit.UseVisualStyleBackColor = true;
            btnYeniKayit.Click += btnYeniKayit_Click;
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 493);
            Controls.Add(btnYeniKayit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Name = "GirisForm";
            Text = "Giriş Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Button btnGiris;
        private Label label1;
        private Label label2;
        private Button btnYeniKayit;
    }
}