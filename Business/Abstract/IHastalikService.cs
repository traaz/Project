using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
 public   interface IHastalikService
    {
        IDataResult<List<Hastalik>> GetAll();
        IResult Add(Hastalik hastalik);
        IResult Delete(Hastalik hastalik);
        IResult Update(Hastalik hastalik);
    }
}
