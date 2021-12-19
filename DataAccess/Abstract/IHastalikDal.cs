using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IHastalikDal: IEntityRepository<Hastalik>
    {
        List<string> GetHastalikDto();
        List<HastaCalisanlarDto> GetHastaCalisanDto();
        List<HastalikDto> GetSehirHastalik(string sehir);
    }
}
