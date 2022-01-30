using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IMainCategoryDal : IGenericDal<MainCategory>
    {
        List<MainCategory> GetMainCategoriesBySubCategories();
        List<MainCategory> GetMainCategoriesBySubCategoriesMostPopular();
    }
}
