using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class HobiManager : IHobiService
    {
        IHobiDal _hobiDal;

        public HobiManager(IHobiDal hobiDal)
        {
            _hobiDal = hobiDal;
        }

        public IResult Add(Hobii hobi)
        {
            _hobiDal.Add(hobi);
            return new SuccessResult("Hobi bilgisi eklendi");
        }

        public IResult Delete(Hobii hobi)
        {
            _hobiDal.Delete(hobi);
            return new SuccessResult("Hobi bilgisi silindi");
        }

        public IDataResult<List<Hobii>> GetAll()
        {
            return new SuccessDataResult<List<Hobii>>(_hobiDal.GetAll());
        }

        public IResult Update(Hobii hobi)
        {
            _hobiDal.Update(hobi);
            return new SuccessResult("Hobi bilgisi güncellendi");
        }
    }
}
