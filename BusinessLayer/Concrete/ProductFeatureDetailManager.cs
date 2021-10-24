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
    public class ProductFeatureDetailManager : IProductFeatureDetailService
    {
        IProductFeatureDetailDal _productFeatureDetailDal;

        public ProductFeatureDetailManager(IProductFeatureDetailDal productFeatureDetailDal)
        {
            _productFeatureDetailDal = productFeatureDetailDal;
        }

       


     

        public ProductFeatureDetail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductFeatureDetail> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(ProductFeatureDetail t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ProductFeatureDetail t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ProductFeatureDetail t)
        {
            throw new NotImplementedException();
        }

       
    }
}
