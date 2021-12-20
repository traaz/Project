using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CovidBelirtiManager : ICovBelirtiService
    {
        ICovBelirtiDal _covBelirtiDal;

        public CovidBelirtiManager(ICovBelirtiDal covBelirtiDal)
        {
            _covBelirtiDal = covBelirtiDal;
        }

        public IResult Add(CovidBelirti covidBelirti)
        {
            _covBelirtiDal.Add(covidBelirti);
            return new SuccessResult("Covid belirti bilgisi eklendi");
        }

        public IResult Delete(CovidBelirti covidBelirti)
        {
            _covBelirtiDal.Delete(covidBelirti);
            return new SuccessResult("Covid belirti bilgisi silindi");
        }

        public IDataResult<List<CovidBelirti>> GetAll()
        {
            return new SuccessDataResult<List<CovidBelirti>>(_covBelirtiDal.GetAll());
        }

        public IDataResult<List<string>> GetTop3Belirti()
        {
            return new SuccessDataResult<List<string>>(_covBelirtiDal.GetTop3Belirti());
        }

        public IResult Update(CovidBelirti covidBelirti)
        {
            _covBelirtiDal.Update(covidBelirti);
            return new SuccessResult("Covid belirti bilgisi güncellendi");
        }
    }
}
