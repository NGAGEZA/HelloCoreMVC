using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UsingMultipleModels.Models;

namespace UsingMultipleModels.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewBag.AllCustomers = GetAllCustomers();
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

        public List<Customers> GetAllCustomers()
        {
            List<Customers> lstCustomers = new List<Customers>();

            lstCustomers.Add(new Customers
            {
                CustomerId = "A001",
                FullName = "Wittaya",
                Address = "Bankok"
            });
            lstCustomers.Add(new Customers
            {
                CustomerId = "A002",
                FullName = "Wittaya",
                Address = "Bankok"
            });
            lstCustomers.Add(new Customers
            {
                CustomerId = "A003",
                FullName = "Wittaya",
                Address = "Bankok"
            });

            return lstCustomers;
        }
        
          
        
    }
}
