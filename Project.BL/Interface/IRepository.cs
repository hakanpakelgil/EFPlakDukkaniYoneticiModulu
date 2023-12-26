using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BL.Interface
{
    public interface IRepository<T> where T : class
    {
        public void Ekle(T eklenecekOge);

        public void Guncelle();

        public void Sil(T silinecek);

        public T IdYeGoreGetir(int id);

        public List<T> HepsiniGetir();

        public DbSet<T> HepsiniEagerLoadingleGetir();
    }

}


