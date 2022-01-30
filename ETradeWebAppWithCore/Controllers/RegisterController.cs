using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace ETradeWebAppWithCore.Controllers
{
    public class RegisterController : Controller
    {
        UserManager userManager = new UserManager(new EfUserRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            
            
        
            UserValidator userValidator = new UserValidator();
            DateTime nowDate =  DateTime.Now; // sadece tarih

            ValidationResult results = userValidator.Validate(user); 
            if (results.IsValid)//Eğer sonuçlar geçerli ise
            {

                user.UserRegistrationDate = nowDate;
                userManager.TAdd(user);
                ViewBag.regiterOperationControl = true;
                return RedirectToAction("Register", "Register");
            }
            else
            {
                

                foreach (var item in results.Errors)
                {

                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }


            return View();//işlem geçersiz ise bana bir view döndürür.
            

        }
    }
}
