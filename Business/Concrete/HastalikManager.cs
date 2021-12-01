using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public IResult Update(Hastalik hastalik)
        {
            _hastalikDal.Update(hastalik);
            return new SuccessResult("Hastalik güncellendi");
        }
    }
}
