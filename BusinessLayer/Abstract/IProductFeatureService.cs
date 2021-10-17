using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductFeatureService
    {
        void AddProductFeature(ProductFeature productFeature);
        void DeleteProductFeature(ProductFeature productFeature);
        void UpdateProductFeature(ProductFeature productFeature);
        List<ProductFeature> GetList();
        ProductFeature GetByID(int id);
    }
}
