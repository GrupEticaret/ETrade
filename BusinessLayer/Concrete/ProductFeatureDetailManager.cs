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

        public void AddProductFeatureDetail(ProductFeatureDetail productFeatureDetail)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductFeatureDetail(ProductFeatureDetail productFeatureDetail)
        {
            throw new NotImplementedException();
        }

        public ProductFeatureDetail GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductFeatureDetail> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateProductFeatureDetail(ProductFeatureDetail productFeatureDetail)
        {
            throw new NotImplementedException();
        }
    }
}
