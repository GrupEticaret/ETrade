using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductPriceService
    {
        void AddProductPrice(ProductPrice productPrice);
        void DeleteProductPrice(ProductPrice productPrice);
        void UpdateProductPrice(ProductPrice productPrice);
        List<ProductPrice> GetList();
        ProductPrice GetByID(int id);
    }
}
