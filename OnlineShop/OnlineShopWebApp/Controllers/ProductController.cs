﻿using System;
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
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        //public string Index(int id)
        //{
        //    var product = productRepository.TryGetById(id);
        //    if (product == null)
        //    {
        //        return "Продукта с таким id не существует";
        //    }
        //    return $"{product}\n{product.Description}";
        //}

        public IActionResult Index(int id)
        {
            var product = productRepository.GetAll().FirstOrDefault(x => x.Id == id);
            return View(product);
        }
    }
}

