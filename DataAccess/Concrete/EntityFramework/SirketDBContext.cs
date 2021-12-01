using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
  public  class SirketDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SirketDB;Trusted_Connection=true");
        }

        public DbSet<Calisan> Calisanlar { get; set;  }
        public DbSet<Hastalik> Hastaliklar { get; set; }
        public DbSet<Recete> Receteler { get; set; }





    }
}
