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
    }
}
