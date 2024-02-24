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

        public string Index(string a = "0", string b = "0", string op = "+")
        {
            double da = Convert.ToDouble(a);
            double db = Convert.ToDouble(b);
            double result = 0;
            switch (op)
            {
                case "+":
                    result = da + db;
                    break;
                case "-":
                    result = da - db;
                    break;
                case "*":
                    result = da * db;
                    break;
                
            }
            return $"{da} {op} {db} = {result}";
        }

       
    }
}
