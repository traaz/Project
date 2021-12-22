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

        public IDataResult<Calisan> GetById(int id)
        {
            return new SuccessDataResult<Calisan>(_calisanDal.Get(c => c.CalisanId == id));
        }

        public IDataResult<List<Calisan>> GetAll()
        {
            return new SuccessDataResult<List<Calisan>>(_calisanDal.GetAll());
        }

        public EgitimDurumuCovidDto GetDoktoraCovid()
        {
            return _calisanDal.GetDoktoraCovid();
        }

        public EgitimDurumuCovidDto GetLisanCovid()
        {
            return _calisanDal.GetLisansCovid();
        }

        public EgitimDurumuCovidDto GetLisanssizCovid()
        {
            return _calisanDal.GetLisanssizCovid();
        }

        public EgitimDurumuCovidDto GetYuksekLisansCovid()
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
