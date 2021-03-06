using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMainCategoryService : IGenericService<MainCategory>
    {
        List<MainCategory> GetMostPopularCategories();
        List<MainCategory> GetMainCategoriesBySubCategories();
        List<MainCategory> GetMainCategoriesBySubCategoriesMostPopular();

        /*
        void AddMainCategory(MainCategory mainCategory);
        void DeleteMainCategory(MainCategory mainCategory);
        void UpdateMainCategory(MainCategory mainCategory);
        List<MainCategory> GetList();
        MainCategory GetByID(int id);
        */
    }
}
