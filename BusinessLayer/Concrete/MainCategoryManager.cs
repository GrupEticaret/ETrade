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
    public class MainCategoryManager : IMainCategoryService
    {
        IMainCategoryDal _mainCategoryDal;

        public MainCategoryManager(IMainCategoryDal mainCategoryDal)
        {
            _mainCategoryDal = mainCategoryDal;
        }

        public MainCategory GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<MainCategory> GetMostPopularCategories()
        {
            return _mainCategoryDal.GetList().OrderByDescending(x => x.MainCategoryID).Take(10).ToList();
        }

        public List<MainCategory> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(MainCategory t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(MainCategory t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(MainCategory t)
        {
            throw new NotImplementedException();
        }

        public List<MainCategory> GetMainCategoriesBySubCategories()
        {
            return _mainCategoryDal.GetMainCategoriesBySubCategories();
        }

        public List<MainCategory> GetMainCategoriesBySubCategoriesMostPopular()
        {
            return _mainCategoryDal.GetMainCategoriesBySubCategoriesMostPopular();
        }
    }
}
