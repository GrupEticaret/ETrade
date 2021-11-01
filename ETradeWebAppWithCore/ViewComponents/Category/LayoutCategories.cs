using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETradeWebAppWithCore.ViewComponents.Category
{
    public class LayoutCategories : ViewComponent
    {
        MainCategoryManager mainCategoryManager = new MainCategoryManager(new EfMainCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = mainCategoryManager.GetMostPopularCategories();
            return View(values);
        }
    }
}
