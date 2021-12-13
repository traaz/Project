using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DozManager : IDozService
    {
        IDozDal _dozDal;

        public DozManager(IDozDal dozDal)
        {
            _dozDal = dozDal;
        }

        public IResult Add(Dozz doz)
        {
            _dozDal.Add(doz);
            return new SuccessResult("Doz bilgisi eklendi");
        }

        public IResult Delete(Dozz doz)
        {
            _dozDal.Delete(doz);
            return new SuccessResult("Doz bilgisi silindi");
        }

        public IDataResult<List<Dozz>> GetAll()
        {
            return new SuccessDataResult<List<Dozz>>(_dozDal.GetAll());
        }

        public IResult Update(Dozz doz)
        {
            _dozDal.Update(doz);
            return new SuccessResult("Doz bilgisi güncellendi");
        }
    }
}
