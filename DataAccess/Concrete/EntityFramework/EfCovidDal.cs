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
    public class EfCovidDal : EfEntityRepositoryBase<Covid, SirketDBContext>, ICovidDal
    {
        public AsiCovidDto GetAsiCovid()
        {
            using(SirketDBContext context=new SirketDBContext())
            {
                var query = from c in context.Covids
                     group c by 1 into g
                     select new AsiCovidDto
                     {
                         AsiCovidOrani = g.Sum(x => x.AsiDurumu == "1" ? 1 : 0) / (double)g.Max(x => x.CovidId),
                         AsisizCovidOrani= g.Sum(x => x.AsiDurumu == "0" ? 1 : 0) / (double)g.Max(x => x.CovidId)

                     };
                return query.First();
            }
        }

        public List<BiontechDto> GetBiontech()
        {
            using(SirketDBContext context=new SirketDBContext())
            {
                var result = from covid in context.Covids
                             join asi in context.Asilar on covid.CovidId equals asi.CovidId
                             join calisan in context.Calisanlar on covid.CalisanId equals calisan.CalisanId
                             join hastalik in context.Hastaliklar on calisan.CalisanId equals hastalik.CalisanId
                             where asi.AsiIsmi == "Biontech"
                             select new BiontechDto
                             {
                                 TcNo = calisan.TcNo,
                                 Isim = calisan.Isim,
                                 Soyisim = calisan.Soyisim,
                                 CovidYakalanmaTarih = covid.CovidYakalanmaTarih,
                                 CovidBitisTarih = covid.CovidBitisTarih,
                                 AsiIsmi = asi.AsiIsmi,
                                 HastalikIsmi = hastalik.HastalikIsmi

                             };
                return result.ToList();

            }
        }

        public List<KanGrubuCovidDto> GetKanGrubuCovidDto()
        {
            using(SirketDBContext context=new SirketDBContext())
            {
                var result = from calisan in context.Calisanlar
                             join covids in context.Covids on calisan.CalisanId equals covids.CalisanId
                             group calisan by calisan.KanGrubu into kan
                             select new KanGrubuCovidDto
                             {
                                 KanGrubu = kan.Key,
                                 CovidMiktari = kan.Count()
                             };
                return result.ToList();

            } 
        }
    }
}
