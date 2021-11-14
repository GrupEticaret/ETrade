using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfMainCategoryRepository : GenericRepository<MainCategory>, IMainCategoryDal
    {
        public List<MainCategory> GetMainCategoriesBySubCategories()
        {
            using (var c = new Context())
            {
                return c.MainCategories.Include(x => x.SubCategories).ToList();
            }
        }
        public List<MainCategory> GetMainCategoriesBySubCategoriesMostPopular()
        {
            using (var c = new Context())
            {
                return c.MainCategories.Include(x => x.SubCategories).Take(9).ToList();
            }
        }
    }
}
