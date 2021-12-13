using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SemptonManager : ISemptonService
    {
        ISemptonDal _semptonDal;

        public SemptonManager(ISemptonDal semptonDal)
        {
            _semptonDal = semptonDal;
        }

        public IResult Add(Sempton sempton)
        {
            _semptonDal.Add(sempton);
            return new SuccessResult("Sempton bilgisi eklendi");
        }

        public IResult Delete(Sempton sempton)
        {
            _semptonDal.Delete(sempton);
            return new SuccessResult("Sempton bilgisi silindi");
        }

        public IDataResult<List<Sempton>> GetAll()
        {
            return new SuccessDataResult<List<Sempton>>(_semptonDal.GetAll());
        }

        public IResult Update(Sempton sempton)
        {
            _semptonDal.Update(sempton);
            return new SuccessResult("Sempton bilgisi güncellendi");
        }
    }
}
