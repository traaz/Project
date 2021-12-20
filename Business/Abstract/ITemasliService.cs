using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ITemasliService
    {
        IDataResult<List<Temasli>> GetAll();
        IResult Add(Temasli temasli);
        IResult Delete(Temasli temasli);
        IResult Update(Temasli temasli);
        IDataResult<List<int>> GetTop3TemasliId();
    }
}
