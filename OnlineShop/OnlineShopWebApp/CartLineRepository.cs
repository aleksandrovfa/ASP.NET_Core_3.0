using System.Collections.Generic;
using System.Linq;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp
{
    public class CartLineRepository
    {
        private static List<CartLine> lineCollection = new List<CartLine>();

        public static void AddItem(Product product, int quantity)
        {
            CartLine line = lineCollection
                .Where(g => g.Product.Id == product.Id)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public static void RemoveLine(Product product)
        {
            lineCollection.RemoveAll(l => l.Product.Id == product.Id);
        }

        public static decimal ComputeTotalValue()
        {
            return lineCollection.Sum(e => e.Cost);

        }
        public static void Clear()
        {
            lineCollection.Clear();
        }

        public static IEnumerable<CartLine> Lines
        {
            get { return lineCollection; }
        }
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Cost
        {
            get
            {
                return Quantity * Product.Cost;
            }
        }
    }
}
