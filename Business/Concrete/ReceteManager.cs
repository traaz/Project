using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ReceteManager : IReceteService
    {
        IReceteDal _receteDal;

        public ReceteManager(IReceteDal receteDal)
        {
            _receteDal = receteDal;
        }

        public IResult Add(Recete recete)
        {
            _receteDal.Add(recete);
            return new SuccessResult("Reçete eklendi");
        }

        public IResult Delete(Recete recete)
        {
            _receteDal.Delete(recete);
            return new SuccessResult("Reçete silindi");
        }

        public IDataResult<List<Recete>> GetAll()
        {
            return new SuccessDataResult<List<Recete>>(_receteDal.GetAll());
        }

        public IResult Update(Recete recete)
        {
            _receteDal.Update(recete);
            return new SuccessResult("Reçete güncellendi");
        }
    }
}
