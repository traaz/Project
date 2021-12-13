using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public IResult Update(Ilac ilac)
        {
            _ilacDal.Update(ilac);
            return new SuccessResult("Ilac bilgisi güncellendi");
        }
    }
}
