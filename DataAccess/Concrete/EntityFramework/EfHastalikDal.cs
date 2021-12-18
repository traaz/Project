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

    }
}


