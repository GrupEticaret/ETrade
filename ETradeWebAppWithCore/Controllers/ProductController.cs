using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETradeWebAppWithCore.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductRepository());
        public IActionResult Index()
        {
            //var values = productManager.GetBlogListWithCategory();
            //Bu index blogların listelendiği sayfa olacak
            return View();
            
        }
    }
}
