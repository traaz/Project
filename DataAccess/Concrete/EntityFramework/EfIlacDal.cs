using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfIlacDal : EfEntityRepositoryBase<Ilac, SirketDBContext>, IilacDal
    {
       
        public List<string> GetTop3Ilac()
        {
            using (SirketDBContext context=new SirketDBContext())
            {
                var result = context.Ilaclar
.GroupBy(x => x.IlacIsmi)
.OrderByDescending(grp => grp.Count())
.Select(grp => grp.Key)
.Take(3)
.ToList();
                return result;
            }
        }


        public List<IlacCovidDto> GetTop3IlacCovidDto()
        {
            using(SirketDBContext context=new SirketDBContext())
            {
                var query= context.Ilaclar
.GroupBy(x => x.IlacIsmi)
.OrderByDescending(grp => grp.Count())
.Select(grp => grp.Key)
.Take(3)
.ToList();

                var result = from covids in context.Covids
                             join calisan in context.Calisanlar on covids.CalisanId equals calisan.CalisanId
                             join ilac in context.Ilaclar on covids.CalisanId equals ilac.CalisanId
                             where query.Contains(ilac.IlacIsmi)
                             select new IlacCovidDto
                             {
                                 TcNo = calisan.TcNo,
                                 Isim = calisan.Isim,
                                 Soyisim = calisan.Soyisim,
                                 CovidYakalanmaTarih = covids.CovidYakalanmaTarih,
                                 CovidBitisTarih = covids.CovidBitisTarih,
                                 IlacIsmi = ilac.IlacIsmi
                             };

                return result.ToList();

            }
        }

        public List<IlacCovidDto> GetCovid(string ilac)
        {
            using(SirketDBContext context=new SirketDBContext())
            {
                var result=  from covids in context.Covids
                             join calisan in context.Calisanlar on covids.CalisanId equals calisan.CalisanId
                             join i in context.Ilaclar on covids.CalisanId equals i.CalisanId
                             where i.IlacIsmi == ilac
                             select new IlacCovidDto
                             {
                                 TcNo = calisan.TcNo,
                                 Isim = calisan.Isim,
                                 Soyisim = calisan.Soyisim,
                                 CovidYakalanmaTarih = covids.CovidYakalanmaTarih,
                                 CovidBitisTarih = covids.CovidBitisTarih,
                                 IlacIsmi = i.IlacIsmi
                             };

                return result.ToList();



            }
        }

    }
}
