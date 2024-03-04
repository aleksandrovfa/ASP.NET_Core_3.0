﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShopWebApp.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public decimal Cost
        {
            get
            {
                return Items.Sum(x => x.Cost);
            }
        }
    }
}
