using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ISemptonService
    {
        IDataResult<List<Sempton>> GetAll();
        IResult Add(Sempton sempton);
        IResult Delete(Sempton sempton);
        IResult Update(Sempton sempton);
    }
}

