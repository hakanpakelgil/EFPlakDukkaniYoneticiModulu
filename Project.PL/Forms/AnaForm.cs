using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Project.BL.Repository;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.PL.Forms
{
    public partial class AnaForm : Form
    {
        Repository<Album> albumRepository = new Repository<Album>();
        Repository<Sanatci> sanatciRepository = new Repository<Sanatci>();
        Album seciliAlbum;
        public AnaForm()
        {
            InitializeComponent();
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            cboFilterler.Items.Clear();
            cboFilterler.Items.AddRange(new string[]
            {
                "Tüm Albümler",
                "Satışı durmuş albümler",
                "Satışı devam eden albümler",
                "Sisteme en son eklenen 10 albüm",
                "İndirimdeki albümler"
             });

            cboFilterler.SelectedIndex = 0;
            cboSanatcilar.DataSource = sanatciRepository.HepsiniGetir();
            dgvAlbumler.DataSource = albumRepository.HepsiniGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string albumAdi = txtAlbumAdi.Text.Trim();
            int sanatciId = ((Sanatci)cboSanatcilar.SelectedItem).Id;
            DateTime cikisTarihi = dtpCikisTarihi.Value.Date;
            decimal fiyat = nudFiyat.Value;
            decimal indirimOrani = nudIndirim.Value;
            bool satisDurum;
            if (chbSatisDurum.Checked)
            {
                satisDurum = true;
            }
            else
            {
                satisDurum = false;
            }
            if (albumAdi == "")
            {
                MessageBox.Show("Albüm Adı Boş Olamaz.");
                return;
            }
            if (sanatciId == null)
            {
                MessageBox.Show("Sanatçı Ekleyiniz.");
                return;
            }
            Album yeniAlbum = new Album();
            yeniAlbum.Ad = albumAdi;
            yeniAlbum.SanatciId = sanatciId;
            yeniAlbum.CikisTarihi = cikisTarihi;
            yeniAlbum.Fiyat = fiyat;
            yeniAlbum.IndirimOrani = indirimOrani;
            yeniAlbum.SatisDurumu = satisDurum;

            try
            {
                albumRepository.Ekle(yeniAlbum);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata :{ex.Message}");
            }

            VerileriYukle();
        }
       

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                seciliAlbum = (Album)dgvAlbumler.SelectedRows[0].DataBoundItem;

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}");
            }
            string albumAdi = txtAlbumAdi.Text.Trim();
            Sanatci sanatci = (Sanatci)cboSanatcilar.SelectedItem;
            DateTime cikisTarihi = dtpCikisTarihi.Value.Date;
            decimal fiyat = nudFiyat.Value;
            decimal indirimOrani = nudIndirim.Value;
            bool satisDurum;
            if (chbSatisDurum.Checked)
            {
                satisDurum = true;
            }
            else
            {
                satisDurum = false;
            }
            if (albumAdi == "")
            {
                MessageBox.Show("Albüm Adı Boş Olamaz.");
                return;
            }
            if (sanatci == null)
            {
                MessageBox.Show("Sanatçı Ekleyiniz.");
                return;
            }

            seciliAlbum.Ad = albumAdi;
            seciliAlbum.Sanatci = sanatci;
            seciliAlbum.CikisTarihi = cikisTarihi;
            seciliAlbum.Fiyat = fiyat;
            seciliAlbum.IndirimOrani = indirimOrani;
            seciliAlbum.SatisDurumu = satisDurum;

            try
            {
                albumRepository.Guncelle();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata :{ex.Message}");
            }

            VerileriYukle();
        }


        private void SeciliAlbumBilgileriniDoldur()
        {
            try
            {
                if (dgvAlbumler.SelectedRows.Count > 0)
                {
                    seciliAlbum= ((Album)dgvAlbumler.SelectedRows[0].DataBoundItem);
                    //seciliAlbum = albumRepository.IdYeGoreGetir(seciliAlbum.Id);
                    txtAlbumAdi.Text = seciliAlbum.Ad;
                    cboSanatcilar.SelectedItem = seciliAlbum.Sanatci;
                    dtpCikisTarihi.Value = seciliAlbum.CikisTarihi;
                    nudFiyat.Value = seciliAlbum.Fiyat;
                    nudIndirim.Value = seciliAlbum.IndirimOrani;
                    if (seciliAlbum.SatisDurumu)
                    {
                        chbSatisDurum.Checked = true;
                    }
                    else
                    {
                        chbSatisDurum.Checked = false;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata: {ex.Message}");
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvAlbumler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir albüm seçiniz.");
                return;
            }
            try
            {
                seciliAlbum = (Album)dgvAlbumler.SelectedRows[0].DataBoundItem;
                albumRepository.Sil(seciliAlbum);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata :{ex.Message}");
            }
            VerileriYukle();
        }

        private void btnSanatciEkle_Click(object sender, EventArgs e)
        {
            SanatciBilgileriForm sanatciBilgileriForm = new SanatciBilgileriForm(sanatciRepository);
            sanatciBilgileriForm.ShowDialog();
        }

        private void cboFilterler_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboFilterler.SelectedIndex)
            {
                case 0:
                    lblFiltreBasligi.Text = cboFilterler.SelectedItem.ToString();
                    dgvAlbumler.DataSource = albumRepository.HepsiniGetir()
                    .ToList();
                    break;
                case 1:
                    dgvAlbumler.DataSource = albumRepository.HepsiniGetir()
                   .Where(a => a.SatisDurumu == false)
                   .Select(a => new
                   {
                       Ad = a.Ad,
                       Sanatçı = a.Sanatci.Ad
                   }).ToList();
                    break;
                case 2:
                    dgvAlbumler.DataSource = albumRepository.HepsiniGetir()
                   .Where(a => a.SatisDurumu == true)
                   .Select(a => new
                   {
                       Ad = a.Ad,
                       Sanatçı = a.Sanatci.Ad
                   }).ToList();
                    break;
                case 3:
                    dgvAlbumler.DataSource = albumRepository.HepsiniGetir()
                   .OrderByDescending(a => a.Id)
                   .Select(a => new
                   {
                       Ad = a.Ad,
                       Sanatçı = a.Sanatci.Ad
                   })
                   .Take(10)
                   .ToList();
                    break;
                case 4:
                    dgvAlbumler.DataSource = albumRepository.HepsiniGetir()
                   .OrderByDescending(a => a.IndirimOrani)
                   .Select(a => new
                   {
                       Ad = a.Ad,
                       Sanatçı = a.Sanatci.Ad
                   })
                   .ToList();
                    break;
                default:
                    break;
            }
        }

        private void dgvAlbumler_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SeciliAlbumBilgileriniDoldur();
        }
    }
}


