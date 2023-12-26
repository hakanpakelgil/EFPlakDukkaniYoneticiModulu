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
    public partial class GirisForm : Form
    {
        Repository<Yonetici> Yoneticiler = new();
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();
            string hashedSifre = sha256_hash(sifre);
            if (kullaniciAdi == "" || sifre == "")
            {
                MessageBox.Show("Tüm alanların doldurulması zorunludur.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Yonetici varOlanYonetici = Yoneticiler.HepsiniGetir().FirstOrDefault(y => y.KullaniciAdi == kullaniciAdi);

            if (varOlanYonetici.KullaniciAdi == kullaniciAdi && varOlanYonetici.Sifre == hashedSifre)
            {
                AnaForm anaForm = new AnaForm();
                anaForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı !.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private string sha256_hash(string sifre)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new KayitForm(Yoneticiler);
            kayitForm.ShowDialog(); 
        }
    }
}
