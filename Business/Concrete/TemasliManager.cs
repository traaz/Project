using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TemasliManager : ITemasliService
    {
        ITemasliDal _temasliDal;

        public TemasliManager(ITemasliDal temasliDal)
        {
            _temasliDal = temasliDal;
        }

        public IResult Add(Temasli temasli)
        {
            _temasliDal.Add(temasli);
            return new SuccessResult("Temasli bilgisi eklendi");
        }

        public IResult Delete(Temasli temasli)
        {
            _temasliDal.Delete(temasli);
            return new SuccessResult("Temasli bilgisi silindi");
        }

        public IDataResult<List<Temasli>> GetAll()
        {
            return new SuccessDataResult<List<Temasli>>(_temasliDal.GetAll());
        }

        public IResult Update(Temasli temasli)
        {
            _temasliDal.Update(temasli);
            return new SuccessResult("Temasli bilgisi güncellendi");
        }
    }
}
