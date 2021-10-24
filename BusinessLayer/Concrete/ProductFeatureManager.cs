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
    public class ProductFeatureManager : IProductFeatureService
    {
        IProductFeatureDal productFeatureDal;

        public ProductFeatureManager(IProductFeatureDal productFeatureDal)
        {
            this.productFeatureDal = productFeatureDal;
        }

        
        

        public ProductFeature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductFeature> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(ProductFeature t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ProductFeature t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ProductFeature t)
        {
            throw new NotImplementedException();
        }

       
    }
}
