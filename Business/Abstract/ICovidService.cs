using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICovidService
    {
        IDataResult<List<Covid>> GetAll();
        IResult Add(Covid covid);
        IResult Delete(Covid covid);
        IResult Update(Covid covid);
    }
}
