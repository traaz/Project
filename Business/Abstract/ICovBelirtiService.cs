using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface ICovBelirtiService
    {
        IDataResult<List<CovidBelirti>> GetAll();
        IResult Add(CovidBelirti covidBelirti);
        IResult Delete(CovidBelirti covidBelirti);
        IResult Update(CovidBelirti covidBelirti);

    }
}
