using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CovidManager : ICovidService
    {
        ICovidDal _covidDal;

        public CovidManager(ICovidDal covidDal)
        {
            _covidDal = covidDal;
        }

        public IResult Add(Covid covid)
        {
            _covidDal.Add(covid);
            return new SuccessResult("Covid bilgisi eklendi");
        }

        public IResult Delete(Covid covid)
        {
            _covidDal.Delete(covid);
            return new SuccessResult("Covid bilgisi silindi");
        }

        public IDataResult<List<Covid>> GetAll()
        {
            return new SuccessDataResult<List<Covid>>(_covidDal.GetAll());
        }

        public IDataResult<List<BiontechDto>> GetBiontech()
        {
            return new SuccessDataResult<List<BiontechDto>>(_covidDal.GetBiontech());
        }

        public IResult Update(Covid covid)
        {
            _covidDal.Update(covid);
            return new SuccessResult("Covid bilgisi güncellendi");
        }
    }
}
