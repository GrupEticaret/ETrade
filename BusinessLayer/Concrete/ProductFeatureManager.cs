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

        public void AddProductFeature(ProductFeature productFeature)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductFeature(ProductFeature productFeature)
        {
            throw new NotImplementedException();
        }

        public ProductFeature GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductFeature> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateProductFeature(ProductFeature productFeature)
        {
            throw new NotImplementedException();
        }
    }
}
