using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHastalikDal : EfEntityRepositoryBase<Hastalik, SirketDBContext>, IHastalikDal
    {
         public List<string> GetHastalikDto()
 {
     using (SirketDBContext context = new SirketDBContext())
     {
         var result = context.Hastaliklar
.GroupBy(x => x.HastalikIsmi)
.OrderByDescending(grp => grp.Count())
.Select(grp => grp.Key)
.Take(3)
.ToList();
         return result;
     }
 }
    /*    public List<HastalikDto> GetHastalikDto()
        {
            using(SirketDBContext context=new SirketDBContext())
            {
                var result = from hastalik in context.Hastaliklar
                             group hastalik by hastalik.HastalikIsmi into isim
                             orderby isim.Count() descending
                             select new HastalikDto { HastalikIsmi = isim.Key };
                return result.Take(3).ToList();
            }
           
        }*/

        public List<HastaCalisanlarDto> GetHastaCalisanDto()
        {
            using(SirketDBContext context=new SirketDBContext())
            {
                var query= context.Hastaliklar
.GroupBy(x => x.HastalikIsmi)
.OrderByDescending(grp => grp.Count())
.Select(grp => grp.Key)
.Take(3)
.ToList();

                var result = from hastalik in context.Hastaliklar
                             join calisan in context.Calisanlar
                             on hastalik.CalisanId equals calisan.CalisanId where query.Contains(hastalik.HastalikIsmi)
                             select new HastaCalisanlarDto
                             {
                                 TcNo =calisan.TcNo,Isim=calisan.Isim,Soyisim=calisan.Soyisim,HastalikIsmi=hastalik.HastalikIsmi
                             };
                            return result.ToList();

            }
        }
    }
}


