using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCalisanDal : EfEntityRepositoryBase<Calisan, SirketDBContext>, ICalisanDal
    {
       
        public EgitimDurumuCovidDto GetDoktoraCovid()
        {
            using (SirketDBContext context = new SirketDBContext())
            {
                var result =
    (from cal1 in context.Calisanlar
     where cal1.Doktora == 1
     select cal1.CalisanId)
    .Intersect
        (from cal2 in context.Covids
         select cal2.CalisanId);

                int sayiMiktari =result.ToList().Count();
                var query = new EgitimDurumuCovidDto
                {
                    SayiMiktari = sayiMiktari,
                    CalisanId = result.ToList()
                };
                return query;
               
            }
        }


        public EgitimDurumuCovidDto GetLisansCovid()
        {
            using (SirketDBContext context = new SirketDBContext())
            {
                var result =
    (from cal1 in context.Calisanlar
     where cal1.Lisans == 1
     select cal1.CalisanId)
    .Intersect
        (from cal2 in context.Covids
         select cal2.CalisanId);

                int sayiMiktari = result.ToList().Count();
                var query = new EgitimDurumuCovidDto
                {
                    SayiMiktari = sayiMiktari,
                    CalisanId = result.ToList()
                };
                return query;


            }
        }

        public EgitimDurumuCovidDto GetLisanssizCovid()
        {
            using (SirketDBContext context = new SirketDBContext())
            {
                var result =
    (from cal1 in context.Calisanlar
     where cal1.Lisans == 0
     select cal1.CalisanId)
    .Intersect
        (from cal2 in context.Covids
         select cal2.CalisanId);

                int sayiMiktari = result.ToList().Count();
                var query = new EgitimDurumuCovidDto
                {
                    SayiMiktari = sayiMiktari,
                    CalisanId = result.ToList()
                };
                return query;
            }
        }
        public EgitimDurumuCovidDto GetYuksekLisansCovid()
        {
            using (SirketDBContext context = new SirketDBContext())
            {
                var result =
    (from cal1 in context.Calisanlar
     where cal1.YuksekLisans == 1
     select cal1.CalisanId)
    .Intersect
        (from cal2 in context.Covids
         select cal2.CalisanId);

                int sayiMiktari = result.ToList().Count();
                var query = new EgitimDurumuCovidDto
                {
                    SayiMiktari = sayiMiktari,
                    CalisanId = result.ToList()
                };
                return query;
            }
        }
    }
}
