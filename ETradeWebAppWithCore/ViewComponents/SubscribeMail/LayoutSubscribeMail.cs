using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETradeWebAppWithCore.ViewComponents.SubscribeMail
{
    public class LayoutSubscribeMail : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
