using System;
using System.Collections.Generic;
using System.Linq;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp
{
    public class InMemoryCartRepository : ICartRepository
    {
        public  List<Cart> carts = new List<Cart>();


        public Cart TryGetByUserId(string userId)
        {
            return carts.FirstOrDefault(x => x.UserId == userId);
        }

        public  void AddItem(Product product, string userId)
        {


            var cart = TryGetByUserId(userId);

            if (cart == null)
            {
                cart = new Cart()
                {
                    Id = Guid.NewGuid(),
                    UserId = userId,
                    Items = new List<CartItem>()
                    {
                        new CartItem()
                        {
                            Product = product,
                            Quantity = 1
                        }
                    }
                };
                carts.Add(cart);
            }

            CartItem line = cart.Items
                .Where(g => g.Product.Id == product.Id)
                .FirstOrDefault();

            if (line == null)
            {
                cart.Items.Add(new CartItem
                {
                    Product = product,
                    Quantity = 1
                });
            }
            else
            {
                line.Quantity += 1;
            }
        }

        public void RemoveItem(Product product, string userId)
        {
            var cart = TryGetByUserId(userId);
            if(cart != null)
            {
                cart.Items.RemoveAll(l => l.Product.Id == product.Id);
            }
        }
    }

    
}
