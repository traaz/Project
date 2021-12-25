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
    public class AsiManager : IAsiService
    {
        IAsiDal _asiDal;

        public AsiManager(IAsiDal asiDal)
        {
            _asiDal = asiDal;
        }

        public IResult Add(Asi asi)
        {
            _asiDal.Add(asi);
            return new SuccessResult("Asi bilgisi eklendi");
        }

        public IResult Delete(Asi asi)
        {
            _asiDal.Delete(asi);
            return new SuccessResult("Asi bilgisi silindi");
        }

        public IDataResult<List<Asi>> GetAll()
        {
            return new SuccessDataResult<List<Asi>>(_asiDal.GetAll());
        }

        public IDataResult<List<BiontechSinovacCovidDto>> GetBiontechSinovacCovid()
        {
            return new SuccessDataResult<List<BiontechSinovacCovidDto>>(_asiDal.GetBiontechSinovacCovidDto());
        }

        public IResult Update(Asi asi)
        {
            _asiDal.Update(asi);
            return new SuccessResult("Asi bilgisi güncellendi");
        }
    }
}
