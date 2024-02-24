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
    public class CalculatorController : Controller
    {
        private readonly ILogger<CalculatorController> _logger;
        // branch 1
        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        public string Index(string a = "0", string b = "0")
        {
            string result = (Convert.ToDouble(a) + Convert.ToDouble(b)).ToString();

            return $"{a} + {b} = {result}";
        }

       
    }
}
