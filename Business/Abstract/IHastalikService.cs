using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
 public   interface IHastalikService
    {
        IDataResult<List<Hastalik>> GetAll();
        IResult Add(Hastalik hastalik);
        IResult Delete(Hastalik hastalik);
        IResult Update(Hastalik hastalik);
        IDataResult<List<string>> GetHastalikDto();
        IDataResult<List<HastaCalisanlarDto>> GetHastaCalisanlarDto();
        IDataResult<List<HastalikDto>> GetSehirTopHastalik(string sehir);
        IDataResult<List<int>> GetTop10HastalikCalisanId();
        IDataResult<List<SonBirAyCovidDto>> GetSonBirAyCovidDto();
    }
}
