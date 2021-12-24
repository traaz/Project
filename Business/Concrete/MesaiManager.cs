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
    public class MesaiManager : IMesaiService
    {
        IMesaiDal _mesaiDal;

        public MesaiManager(IMesaiDal mesaiDal)
        {
            _mesaiDal = mesaiDal;
        }

        public IResult Add(Mesai mesai)
        {
            _mesaiDal.Add(mesai);
            return new SuccessResult("Mesai eklendi");
        }

        public IResult Delete(Mesai mesai)
        {
            _mesaiDal.Delete(mesai);
            return new SuccessResult("Mesai silindi");
        }

        public IDataResult<List<Mesai>> GetAll()
        {
            return new SuccessDataResult<List<Mesai>>(_mesaiDal.GetAll());
        }

        public IDataResult<List<CalismaSaatiCovidDto>> GetCalismaSaatiCovidDto()
        {
            return new SuccessDataResult<List<CalismaSaatiCovidDto>>(_mesaiDal.GetCalismaSaatiCovid());
        }

        public IResult Update(Mesai mesai)
        {
            _mesaiDal.Update(mesai);
            return new SuccessResult("Mesai güncellendi");
        }
    }
}
