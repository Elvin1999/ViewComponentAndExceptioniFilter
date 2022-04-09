using Microsoft.AspNetCore.Mvc;
using RazorPages.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;

namespace RazorPages.Controllers
{

    public class HomeController : Controller
    {
        public HomeController()
        {
            int a = 10;
        }
        [HandleException(ViewName = "DivideByZeroException", ExceptionType =typeof(DivideByZeroException))]
        [HandleException(ViewName = "Error", ExceptionType =typeof(SecurityException))]
        public IActionResult Index()
        {
            //throw new SecurityException("Some exception");

            return View();
        }
        
        public IActionResult Index2()
        {
           // throw new Exception("Some exception");
            return View();
        }
    }
}
