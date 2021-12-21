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
    public class KronikHastalikManager : IKronikHastalikService
    {
        IKronikHastalikDal _kronikHastalik;

        public KronikHastalikManager(IKronikHastalikDal kronikHastalik)
        {
            _kronikHastalik = kronikHastalik;
        }

        public IResult Add(KronikHastalik kronikHastalik)
        {
            _kronikHastalik.Add(kronikHastalik);
            return new SuccessResult("Kronik hastalik eklendi");
        }

        public IResult Delete(KronikHastalik kronikHastalik)
        {
            _kronikHastalik.Delete(kronikHastalik);
            return new SuccessResult("Kronik hastalik silindi");
        }

        public IDataResult<List<KronikHastalik>> GetAll()
        {
            return new SuccessDataResult<List<KronikHastalik>>(_kronikHastalik.GetAll());
        }

        public IDataResult<List<KronikHastalikCovidDto>> GetKronikHastalikCovidDto(string kronikHastalik)
        {
            return new SuccessDataResult<List<KronikHastalikCovidDto>>(_kronikHastalik.GetKronikHastalikCovidDto(kronikHastalik));
        }

        public IResult Update(KronikHastalik kronikHastalik)
        {
            _kronikHastalik.Update(kronikHastalik);
            return new SuccessResult("Kronik hastalik güncellendi");
        }
    }
}
