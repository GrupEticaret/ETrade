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
    public class ProductPriceManager : IProductPriceService
    {
        IProductPriceDal _productPriceDal;

        public ProductPriceManager(IProductPriceDal productPriceDal)
        {
            _productPriceDal = productPriceDal;
        }

        public void AddProductPrice(ProductPrice productPrice)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductPrice(ProductPrice productPrice)
        {
            throw new NotImplementedException();
        }

        public ProductPrice GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductPrice> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateProductPrice(ProductPrice productPrice)
        {
            throw new NotImplementedException();
        }
    }
}
