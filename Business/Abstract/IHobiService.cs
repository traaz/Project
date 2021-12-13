using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IHobiService
    {
        IDataResult<List<Hobii>> GetAll();
        IResult Add(Hobii hobi);
        IResult Delete(Hobii hobi);
        IResult Update(Hobii hobi);
    }
}
