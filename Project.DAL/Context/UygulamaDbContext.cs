using Microsoft.EntityFrameworkCore;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class UygulamaDbContext : DbContext
    {
        public DbSet<Album> Albumler { get; set; }
        public DbSet<Sanatci> Sanatcilar { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=EFUygulamaMaraton;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
