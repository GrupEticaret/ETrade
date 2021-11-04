using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETradeWebAppWithCore.ViewComponents.Blog
{
    public class LayoutProductListWithCategory : ViewComponent
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());
        public IViewComponentResult Invoke()
        {
            var values = productManager.GetBlogListWithCategory();
            return View(values);
        }
    }
}
