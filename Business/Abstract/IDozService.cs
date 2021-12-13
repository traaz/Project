using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IDozService
    {
        IDataResult<List<Dozz>> GetAll();
        IResult Add(Dozz doz);
        IResult Delete(Dozz doz);
        IResult Update(Dozz doz);
    }
}

