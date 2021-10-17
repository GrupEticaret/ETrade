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

        public void AddMainCategory(MainCategory mainCategory)
        {
            throw new NotImplementedException();
        }

        public void DeleteMainCategory(MainCategory mainCategory)
        {
            throw new NotImplementedException();
        }

        public MainCategory GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MainCategory> GetList()
        {
            throw new NotImplementedException();
        }

        public void UpdateMainCategory(MainCategory mainCategory)
        {
            throw new NotImplementedException();
        }
    }
}
