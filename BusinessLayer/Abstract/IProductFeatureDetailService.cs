using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductFeatureDetailService
    {
        void AddProductFeatureDetail(ProductFeatureDetail productFeatureDetail);
        void DeleteProductFeatureDetail(ProductFeatureDetail productFeatureDetail);
        void UpdateProductFeatureDetail(ProductFeatureDetail productFeatureDetail);
        List<ProductFeatureDetail> GetList();
        ProductFeatureDetail GetByID(int id);
    }
}
