using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfKronikHastalikDal : EfEntityRepositoryBase<KronikHastalik, SirketDBContext>, IKronikHastalikDal
    {
        public List<KronikHastalikCovidDto> GetKronikHastalikCovidDto(string kronikHastalik)
        {
            using(SirketDBContext context=new SirketDBContext())
            {
              
                  var result=from kronik in context.KronikHastaliklar
                         join covid in context.Covids on kronik.CovidId equals covid.CovidId
                         join calisan in context.Calisanlar on covid.CalisanId equals calisan.CalisanId
                         where kronik.KronikHastalikIsmi == kronikHastalik

                         select new KronikHastalikCovidDto
                         {
                             TcNo = calisan.TcNo,
                             Isim = calisan.Isim,
                             Soyisim = calisan.Soyisim,
                             GecenSure = EF.Functions.DateDiffDay(covid.CovidYakalanmaTarih,covid.CovidBitisTarih)
                         }; 
            return result.ToList();
               
            }
        }
    }
}
