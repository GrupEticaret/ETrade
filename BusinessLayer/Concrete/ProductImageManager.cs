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
    public class ProductImageManager : IProductImageService
    {
        IProductImageDal _productImageDal;

        public ProductImageManager(IProductImageDal productImageDal)
        {
            _productImageDal = productImageDal;
        }

        public void AddProductImage(ProductImage productImage)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductImage(ProductImage productImage)
        {
            throw new NotImplementedException();
        }

        public ProductImage GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductImage> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateProductImage(ProductImage productImage)
        {
            throw new NotImplementedException();
        }
    }
}
