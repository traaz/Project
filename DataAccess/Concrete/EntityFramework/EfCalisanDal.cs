using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
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
        public List<int> GetDoktoraCovid()
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

                return result.ToList();
            }
        }
        public List<int> GetLisansCovid()
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

                return result.ToList();


            }
        }

        public List<int> GetLisanssizCovid()
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

                return result.ToList();
            }
        }
        public List<int> GetYuksekLisansCovid()
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

                return result.ToList();
            }
        }
    }
}
