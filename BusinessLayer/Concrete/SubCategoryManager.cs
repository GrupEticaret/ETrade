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
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public void AddSubCategory(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }

        public void DeleteSubCategory(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }

        public SubCategory GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubCategory> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateSubCategory(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }
    }
}
