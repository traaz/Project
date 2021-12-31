using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IilacDal: IEntityRepository<Ilac>
    {
        List<string> GetTop3Ilac();
        List<IlacCovidDto> GetTop3IlacCovidDto();
        List<IlacCovidDto> GetCovid(string ilac);
        List<Top3IlacCalisanDto> GetTop3IlacCalisanDto();
        List<IlacCalisanDto> GetIlacCalisanDto(string ilac);
    }
}
