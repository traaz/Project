using Core.Utilities.Results;
using Entities.Concrete;
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
    }
}
