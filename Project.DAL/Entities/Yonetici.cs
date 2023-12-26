using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class Yonetici
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; } = null!;
        public string Sifre { get; set; } = null!;
    }
}
