using Core.DataAccess.EntityFramework;
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
        public List<LisansCovid> GetLisansCovid()
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
                
                





                /*from c in context.C
                         join b in context.Brands
                         on c.BrandId equals b.BrandId
                         join co in context.Colors
                         on c.ColorId equals co.ColorId

                         select new CarDetailDto { CarDescription = c.Description, BrandName = b.BrandName, ColorName = co.ColorName, DailyPrice = c.DailyPrice };

            return result.ToList();*/
            }
        }
    }
}
