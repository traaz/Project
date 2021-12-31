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
    public class IlacManager : IilacService
    {
        IilacDal _ilacDal;

        public IlacManager(IilacDal ilacDal)
        {
            _ilacDal = ilacDal;
        }

        public IResult Add(Ilac ilac)
        {
            _ilacDal.Add(ilac);
            return new SuccessResult("Ilac bilgisi eklendi");
        }

        public IResult Delete(Ilac ilac)
        {
            _ilacDal.Delete(ilac);
            return new SuccessResult("Ilac bilgisi silindi");
        }

        public IDataResult<List<Ilac>> GetAll()
        {
            return new SuccessDataResult<List<Ilac>>(_ilacDal.GetAll());
        }

        public IDataResult<List<IlacCovidDto>> GetCovid(string ilac)
        {
            return new SuccessDataResult<List<IlacCovidDto>>(_ilacDal.GetCovid(ilac));
        }

        public IDataResult<List<IlacCalisanDto>> GetIlacCalisan(string ilac)
        {
            return new SuccessDataResult<List<IlacCalisanDto>>(_ilacDal.GetIlacCalisanDto(ilac));
        }

        public IDataResult<List<IlacCovidDto>> GetIlacCovidDto()
        {
            return new SuccessDataResult<List<IlacCovidDto>>(_ilacDal.GetTop3IlacCovidDto());
        }

        public IDataResult<List<string>> GetTop3Ilac()
        {
            return new SuccessDataResult<List<string>>(_ilacDal.GetTop3Ilac());
        }

        public IDataResult<List<Top3IlacCalisanDto>> GetTop3IlacCalisan()
        {
            return new SuccessDataResult<List<Top3IlacCalisanDto>>(_ilacDal.GetTop3IlacCalisanDto());
        }

        public IResult Update(Ilac ilac)
        {
            _ilacDal.Update(ilac);
            return new SuccessResult("Ilac bilgisi güncellendi");
        }
    }
}
