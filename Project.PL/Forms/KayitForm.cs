using Project.BL.Repository;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.PL.Forms
{
    public partial class KayitForm : Form
    {
        private readonly Repository<Yonetici> _Yoneticiler;

        public KayitForm(Repository<Yonetici> Yoneticiler)
        {
            InitializeComponent();
            _Yoneticiler = Yoneticiler;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string sifreTekrar = txtSifreTekrar.Text.Trim();
            string hashedSifre = sha256_hash(sifre);
            if (kullaniciAdi == "" || sifre == "")
            {
                MessageBox.Show("Tüm alanların doldurulması zorunludur.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Girdiğiniz şifreler eşleşmiyor.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Yonetici varOlanYonetici = _Yoneticiler.HepsiniGetir().FirstOrDefault(y => y.KullaniciAdi == kullaniciAdi);
            if (varOlanYonetici != null)
            {
                MessageBox.Show("Bu bilgilere sahip bir kullanıcı bulunmaktadır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!SifreKontrol(sifre))
            {
                return;
            }
            Yonetici yeniYonetici = new Yonetici();
            yeniYonetici.KullaniciAdi = kullaniciAdi;
            yeniYonetici.Sifre = hashedSifre;
            try
            {
                _Yoneticiler.Ekle(yeniYonetici);
                MessageBox.Show("Yönetici başarıyla eklendi..", "Bilgi",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {

                MessageBox.Show($"Hata Oluştu :{ex.Message}");
                
            }
            this.Close();
        }

        private bool SifreKontrol(string sifre)
        {
            if (sifre.Length < 8)
            {
                MessageBox.Show("Şifre en az sekiz karakter uzunluğunda olamlıdır.", "Uyarı",
                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            int buyukHarfSayisi = 0;
            int kucukHarfSayisi = 0;
            int ozelKarakterSayisi = 0;
            List<char> ozelKarakterler = new List<char> { '!', ':', '+', '*' };

            foreach (char karakter in sifre)
            {
                if (char.IsUpper(karakter))
                    buyukHarfSayisi++;
                if (char.IsLower(karakter))
                    kucukHarfSayisi++;
                if (ozelKarakterler.Contains(karakter))
                {
                    ozelKarakterSayisi++;
                    ozelKarakterler.Remove(karakter);
                }
            }
            if (buyukHarfSayisi < 2)
            {
                MessageBox.Show("Şifre en az iki büyük harf içermektedir.", "Uyarı",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (kucukHarfSayisi < 3)
            {
                MessageBox.Show("Şifre en az üç küçük harf içermektedir.", "Uyarı",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ozelKarakterSayisi < 2)
            {
                MessageBox.Show("Şifre en az iki özel karakter içermektedir.", "Uyarı",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }


    }
}


