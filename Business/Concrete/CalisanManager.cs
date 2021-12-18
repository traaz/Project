﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CalisanManager : ICalisanService
    {
        ICalisanDal _calisanDal;

        public CalisanManager(ICalisanDal calisanDal)
        {
            _calisanDal = calisanDal;
        }

        public IResult Add(Calisan calisan)
        {
            _calisanDal.Add(calisan);
            return new SuccessResult("Calisan eklendi");
        }

        public IResult Delete(Calisan calisan)
        {
            _calisanDal.Delete(calisan);
            return new SuccessResult("Calisan silindi");
        }

        public IDataResult<List<Calisan>> GetAll()
        {
            return new SuccessDataResult<List<Calisan>>(_calisanDal.GetAll());
        }

        public List<int> GetDoktoraCovid()
        {
            return _calisanDal.GetDoktoraCovid();
        }

        public List<int> GetLisanCovid()
        {
            return _calisanDal.GetLisansCovid();
        }

        public List<int> GetLisanssizCovid()
        {
            return _calisanDal.GetLisanssizCovid();
        }

        public List<int> GetYuksekLisansCovid()
        {
            return _calisanDal.GetYuksekLisansCovid();
        }

        public IResult Update(Calisan calisan)
        {
            _calisanDal.Update(calisan);
            return new SuccessResult("Kullanıcı güncellendi");
        }
    }
}
