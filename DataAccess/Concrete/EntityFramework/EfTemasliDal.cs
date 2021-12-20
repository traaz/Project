using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTemasliDal : EfEntityRepositoryBase<Temasli, SirketDBContext>, ITemasliDal
    {
        public List<int> GetTop3TemasliId()
        {
            using (SirketDBContext context = new SirketDBContext())
            {
                var result = context.Temaslilar
.GroupBy(x => x.TemasliCalisanId)
.OrderByDescending(grp => grp.Count())
.Select(grp => grp.Key)
.Take(3)
.ToList();
                return result;


            }
        }
    }
}
