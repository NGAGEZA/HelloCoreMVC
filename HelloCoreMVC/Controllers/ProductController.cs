using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloCoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product p = new Product();
            p.ProductId = "101";
            p.ProductName = "ASP.NET Core MVC Basic";
            p.ProductPrice = 229;

            return View(p);
        }
    }
}