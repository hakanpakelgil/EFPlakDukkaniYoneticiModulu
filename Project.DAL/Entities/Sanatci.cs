using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class Sanatci
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        // Navigation Property
        public virtual List<Album> Albumler { get; set; }
        public override string ToString()
        {
            return Ad;
        }
    }
}
