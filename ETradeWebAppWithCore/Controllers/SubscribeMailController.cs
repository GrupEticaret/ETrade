using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using ETradeWebAppWithCore.Models.AraModeller;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETradeWebAppWithCore.Controllers
{
    public class SubscribeMailController : Controller
    {
        SubscribeMailManager sm = new SubscribeMailManager(new EfSubscribeMailRepository());
        public async Task<IActionResult> SubscribeMail(SubscribeMail p)
        {
            try
            {
                p.MailStatus = true;
                await sm.AddSubscribeMail(p); ;

                return Json(new ResultModel { Success = true });
            }
            catch (System.Exception ex)
            {
                return Json(new ResultModel { Success = false, Message = ex.Message });
            }




        }
    }
}
