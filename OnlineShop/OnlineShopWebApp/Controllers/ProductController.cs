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

    public class ProductController : Controller
    {
        private readonly ProductRepository productRepository;

        public ProductController()
        {
            productRepository = new ProductRepository();
        }
        public string Index(int id)
        {
            var product = productRepository.TryGetById(id);
            if (product == null)
            {
                return "Продукта с таким id не существует";
            }
            return $"{product}\n{product.Description}";
        }
    }
}

