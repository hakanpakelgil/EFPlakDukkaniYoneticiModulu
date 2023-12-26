using Microsoft.EntityFrameworkCore;
using Project.BL.Interface;
using Project.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BL.Repository
{
    public class Repository<T> :IRepository<T> where T : class
    {
        private static UygulamaDbContext _db = new UygulamaDbContext();
        private DbSet<T> varliklar;
        public Repository()
        {
            varliklar = _db.Set<T>();
        }

        public void Ekle(T eklenecekOge)
        {
            varliklar.Add(eklenecekOge);
            _db.SaveChanges();
        }


        public void Guncelle()
        {
            _db.SaveChanges();
        }

        public DbSet<T> HepsiniEagerLoadingleGetir()
        {
            return varliklar;
        }

        public List<T> HepsiniGetir()
        {
            return varliklar.ToList();
        }

        public T IdYeGoreGetir(int id)
        {
            return varliklar.Find(id)!;
        }

        public void Sil(T silinecek)
        {

            _db.Remove(silinecek);
            _db.SaveChanges();
        }

    }
}

