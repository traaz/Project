using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IAsiService
    {
        IDataResult<List<Asi>> GetAll();
        IResult Add(Asi asi);
        IResult Delete(Asi asi);
        IResult Update(Asi asi);
        IDataResult<List<BiontechSinovacCovidDto>> GetBiontechSinovacCovid();
    }
}
