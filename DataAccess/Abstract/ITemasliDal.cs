using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ITemasliDal: IEntityRepository<Temasli>
    {
        List<int> GetTop3TemasliId();
    }
}
