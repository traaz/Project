using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IKronikHastalikService
    {
        IDataResult<List<KronikHastalik>> GetAll();
        IResult Add(KronikHastalik kronikHastalik);
        IResult Delete(KronikHastalik kronikHastalik);
        IResult Update(KronikHastalik kronikHastalik);
    }
}
