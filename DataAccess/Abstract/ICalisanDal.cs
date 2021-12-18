using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICalisanDal:IEntityRepository<Calisan>
    {
        List<int> GetLisanssizCovid();
        List<int> GetLisansCovid();
        List<int> GetYuksekLisansCovid();
        List<int> GetDoktoraCovid();
    }
}
