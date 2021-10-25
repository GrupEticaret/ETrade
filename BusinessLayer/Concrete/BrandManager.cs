using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        
       

        public Brand GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Brand t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Brand t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Brand t)
        {
            throw new NotImplementedException();
        }

       
    }
}
