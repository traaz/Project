using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IilacService
    {
        IDataResult<List<Ilac>> GetAll();
        IResult Add(Ilac ilac);
        IResult Delete(Ilac ilac);
        IResult Update(Ilac ilac);
        IDataResult<List<string>> GetTop3Ilac();
        IDataResult<List<IlacCovidDto>> GetIlacCovidDto();
        IDataResult<List<IlacCovidDto>> GetCovid(string ilac);

    }
}
