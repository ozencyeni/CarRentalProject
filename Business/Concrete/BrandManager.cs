using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandyDal;

        public BrandManager(IBrandDal brandyDal)
        {
            _brandyDal = brandyDal;
        }

        public List<Brand> GetAll()
        {
            return _brandyDal.GetAll();
        }

        public Brand GetById(int brandId)
        {
            return _brandyDal.Get(b => b.BrandId == brandId);
        }
    }
}
