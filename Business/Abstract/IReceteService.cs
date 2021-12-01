using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IReceteService
    {
        IDataResult<List<Recete>> GetAll();
        IResult Add(Recete recete);
        IResult Delete(Recete recete);
        IResult Update(Recete recete);
    }
}
