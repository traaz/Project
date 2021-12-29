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
    public class HastalikManager : IHastalikService
    {
        IHastalikDal _hastalikDal;

        public HastalikManager(IHastalikDal hastalikDal)
        {
            _hastalikDal = hastalikDal;
        }

        public IResult Add(Hastalik hastalik)
        {
            _hastalikDal.Add(hastalik);
            return new SuccessResult("Hastalik eklendi");
        }

        public IResult Delete(Hastalik hastalik)
        {
            _hastalikDal.Delete(hastalik);
            return new SuccessResult("Hastalik silindi");
        }

        public IDataResult<List<Hastalik>> GetAll()
        {
            return new SuccessDataResult<List<Hastalik>>(_hastalikDal.GetAll());
        }

        public IDataResult<List<HastaCalisanlarDto>> GetHastaCalisanlarDto()
        {
            return new SuccessDataResult<List<HastaCalisanlarDto>>(_hastalikDal.GetHastaCalisanDto());
        }

        public IDataResult<List<string>> GetHastalikDto()
        {
            return new SuccessDataResult<List<string>>(_hastalikDal.GetHastalikDto());
        }

        public IDataResult<List<HastalikDto>> GetSehirTopHastalik(string sehir)
        {
            return new SuccessDataResult<List<HastalikDto>>(_hastalikDal.GetSehirHastalik(sehir));
        }

        public IDataResult<List<SonBirAyCovidDto>> GetSonBirAyCovidDto()
        {
            return new SuccessDataResult<List<SonBirAyCovidDto>>(_hastalikDal.GetSonBirAyCovidDto());
        }

        public IDataResult<List<int>> GetTop10HastalikCalisanId()
        {
            return new SuccessDataResult<List<int>>(_hastalikDal.GetTop10HastalikCalisanId());
        }

        public IResult Update(Hastalik hastalik)
        {
            _hastalikDal.Update(hastalik);
            return new SuccessResult("Hastalik güncellendi");
        }

     
    }
}
