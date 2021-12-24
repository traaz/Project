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
    public class EfMesaiDal : EfEntityRepositoryBase<Mesai, SirketDBContext>, IMesaiDal
    {
        public List<CalismaSaatiCovidDto> GetCalismaSaatiCovid()
        {
            using(SirketDBContext context = new SirketDBContext())
            {
                var result = from mesai in context.Mesailer
                             join covid in context.Covids on mesai.CalisanId equals covid.CalisanId
                             group mesai by EF.Functions.DateDiffHour(mesai.IsBaslangicSaati, mesai.IsBitisSaati) into calismaSaati
                             select new CalismaSaatiCovidDto
                             {
                                 CalismaSaati = calismaSaati.Key,
                                 CovidMiktari=calismaSaati.Count()
                             };
                return result.ToList();


            }
        }

        public HaftasonuCovidDto GetHaftasonuCovidDto()
        {
            using(SirketDBContext context=new SirketDBContext())
            {
                var result = from mesai in context.Mesailer
                             join calisan in context.Calisanlar on mesai.CalisanId equals calisan.CalisanId
                             join covid in context.Covids on mesai.CalisanId equals covid.CalisanId
                             where mesai.GunAdi == "Cumartesi " || mesai.GunAdi == "Pazar"
                             select new List<int>
                             {                                
                                 calisan.CalisanId
                             }.FirstOrDefault();
               
                int sayi = result.Distinct().ToList().Count();
                var query = new HaftasonuCovidDto()
                {
                    SayiMiktari = sayi,
                    CalisanId= result.Distinct().ToList()
                };
                return query;
                
            }
        }
    }
}
