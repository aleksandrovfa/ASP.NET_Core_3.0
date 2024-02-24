using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<Product> _products;
        // branch 1
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _products = new List<Product>();
            _products.Add(new Product
            {
                Id = 1,
                Name = "Name1",
                Cost = 11,
                Description = "Decrip1"
            });

            _products.Add(new Product
            {
                Id = 2,
                Name = "Name2",
                Cost = 12,
                Description = "Decrip2"
            });

            _products.Add(new Product
            {
                Id = 3,
                Name = "Name3",
                Cost = 13,
                Description = "Decrip3"
            });

        }

        public string Index()
        {
            return String.Join("\n\n", _products.Select(x => x.ToString()).ToList());
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
