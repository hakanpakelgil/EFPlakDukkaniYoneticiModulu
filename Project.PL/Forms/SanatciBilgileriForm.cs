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
    public partial class SanatciBilgileriForm : Form
    {
        private readonly Repository<Sanatci> _sanatciRepository;

        public SanatciBilgileriForm(Repository<Sanatci> sanatciRepository)
        {
            InitializeComponent();
            _sanatciRepository = sanatciRepository;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sanatci yeniSanatci = new Sanatci();
            if (txtSanatciAdi.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen Ad Bilgisi Giriniz.");
                return;
            }
            yeniSanatci.Ad = txtSanatciAdi.Text.Trim();
            try
            {

                _sanatciRepository.Ekle(yeniSanatci);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Hata :{ex.Message}");
            }
            dgvSanatcilar.DataSource = _sanatciRepository.HepsiniGetir();
        }
    }
}
