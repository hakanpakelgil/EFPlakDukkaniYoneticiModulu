namespace Project.PL.Forms
{
    partial class KayitForm
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
            btnKayitOl = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label3 = new Label();
            txtSifreTekrar = new TextBox();
            SuspendLayout();
            // 
            // btnKayitOl
            // 
            btnKayitOl.Location = new Point(249, 299);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(352, 44);
            btnKayitOl.TabIndex = 11;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 170);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 10;
            label2.Text = "Şifresi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 104);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 9;
            label1.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(249, 164);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(352, 31);
            txtSifre.TabIndex = 7;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(249, 101);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(352, 31);
            txtKullaniciAdi.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 237);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 13;
            label3.Text = "Şifre Tekrar";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(249, 231);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(352, 31);
            txtSifreTekrar.TabIndex = 12;
            txtSifreTekrar.UseSystemPasswordChar = true;
            // 
            // KayitForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 418);
            Controls.Add(label3);
            Controls.Add(txtSifreTekrar);
            Controls.Add(btnKayitOl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Name = "KayitForm";
            Text = "Kayıt Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKayitOl;
        private Label label2;
        private Label label1;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private TextBox txtSifreTekrar;
    }
}