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
    public class StartController : Controller
    {
        private readonly ILogger<StartController> _logger;
        // branch 1
        public StartController(ILogger<StartController> logger)
        {
            _logger = logger;
        }

        public string Hello()
        {
            var currentTime = DateTime.Now;
            string greeting;

            if (currentTime.Hour >= 0 && currentTime.Hour < 6)
            {
                greeting = "Доброй ночи";
            }
            else if (currentTime.Hour >= 6 && currentTime.Hour < 12)
            {
                greeting = "Доброе утро";
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
            {
                greeting = "Добрый день";
            }
            else
            {
                greeting = "Добрый вечер";
            }

            return greeting;
        }

      
    }
}
