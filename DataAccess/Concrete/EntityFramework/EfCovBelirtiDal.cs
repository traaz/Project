using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCovBelirtiDal : EfEntityRepositoryBase<CovidBelirti, SirketDBContext>, ICovBelirtiDal
    {
        public List<string> GetTop3Belirti()
        {
            using(SirketDBContext context=new SirketDBContext())
            {
                var result = context.CovidBelirtiler
 .GroupBy(x => x.Belirti)
 .OrderByDescending(grp => grp.Count())
 .Select(grp => grp.Key)
 .Take(3)
 .ToList();
                return result;

            }
        }
    }
}
