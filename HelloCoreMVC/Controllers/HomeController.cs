using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloCoreMVC.Models;

namespace HelloCoreMVC.Controllers
{
    public class HomeController : Controller
    {
       // [Route("api/index")] //ปิดบังเส้นทาง url
        public IActionResult Index()
        {

            // ValueTuple Test
            //var FullName = (FirstName: "Wittaya", LastName: "Suttisak");
            //ViewData["myname"] = FullName.FirstName + " " + FullName.LastName;

            //var result = 0;
            //int x = 200;
            //int y = 300;

            //AddData(x, y);

            //void AddData(int num1, int num2)
            //{
            //    result = num1 + num2;
            //}

            //ViewData["result"] = result;

            //return View();
            //var productLists = new List<Product>();
            //productLists.Add(new Product{ProductId = "001",ProductName = "Using VB",ProductPrice = 299});
            //productLists.Add(new Product { ProductId = "002", ProductName = "Using C#", ProductPrice = 399 });
            //productLists.Add(new Product { ProductId = "003", ProductName = "Using ASP.NET Core MVC", ProductPrice = 275 });

            //return View(productLists);

            var p = new Product();
            p.ProductId = "101";
            p.ProductName = "ASP.NET Core MVC Basic";
            p.ProductPrice = 229;

            return View(p);
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
