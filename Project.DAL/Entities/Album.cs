using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class Album
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public DateTime CikisTarihi { get; set; }

        [Precision(18,2)]
        public decimal Fiyat { get; set; }

        [Precision(3, 2)]
        public decimal IndirimOrani { get; set; }
        public bool SatisDurumu { get; set; }

        //Navigation Property
        public int SanatciId { get; set; }
        public virtual Sanatci Sanatci { get; set; } = null!;

        public override string ToString()
        {
            return Ad + " " + Sanatci.Ad;
        }
    }
}
