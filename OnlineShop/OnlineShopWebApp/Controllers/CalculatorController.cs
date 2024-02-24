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
    public class CalcController : Controller
    {
        private readonly ILogger<CalcController> _logger;
        // branch 1
        public CalcController(ILogger<CalcController> logger)
        {
            _logger = logger;
        }

        public string Index(string a = "0", string b = "0", string c = "+")
        {
            double da = Convert.ToDouble(a);
            double db = Convert.ToDouble(b);
            double result = 0;
            if (c == null) c = "+";
            switch (c)
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
                case "/":
                    result = da / db;
                    break;

            }
            return $"{da} {c} {db} = {result}";
        }

       
    }
}
