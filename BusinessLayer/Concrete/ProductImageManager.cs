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

        

        

        public ProductImage GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductImage> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(ProductImage t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ProductImage t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ProductImage t)
        {
            throw new NotImplementedException();
        }

        
    }
}
