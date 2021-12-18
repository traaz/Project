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
        public DbSet<Hobii> Hobiler { get; set; }
        public DbSet<Hastalik> Hastaliklar { get; set; }
        
        public DbSet<Covid> Covids { get; set; }
        public DbSet<Mesai> Mesailer { get; set; }
        public DbSet<Ilac> Ilaclar { get; set; }
        
        public DbSet<Sempton> Semptonlar { get; set; }
        public DbSet<CovidBelirti> CovidBelirtiler { get; set; }
        public DbSet<Asi> Asilar { get; set; }
        public DbSet<KronikHastalik> KronikHastaliklar { get; set; }



    }
}
