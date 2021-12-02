using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IMesaiService

    {
        IDataResult<List<Mesai>> GetAll();
        IResult Add(Mesai mesai);
        IResult Delete(Mesai mesai);
        IResult Update(Mesai mesai);
    }
}
