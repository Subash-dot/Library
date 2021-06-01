using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            var obj = new { id =1,Name ="name", Address="address" };
            return View(obj);
        }

        public ViewResult AboutUs()
        {
            return View();
        }
    }
}
