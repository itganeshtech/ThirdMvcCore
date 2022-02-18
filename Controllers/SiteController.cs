using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThirdMvcCore.Models;

namespace ThirdMvcCore.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser(RegisterUserModel user)
        {
            if(!user.IsAgreedToTerms)
            {
                ModelState.AddModelError("IsAgreedToTerms", "Please Check to proceed further");
            }
            return View();
        }

        //[HttpPost]
        //public IActionResult Index(EmployeeModel employee)
        //{
        //    return View();
        //}
    }
}
