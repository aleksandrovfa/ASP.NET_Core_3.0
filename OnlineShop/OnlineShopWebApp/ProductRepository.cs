using OnlineShopWebApp.Models;
using System.Collections.Generic;

namespace OnlineShopWebApp
{
    public class ProductRepository
    {
        private  List<Product> products = new List<Product>()
        {
            new Product("Оно", 
                450, 
                "Автор: Стивен Кинг",
                "https://ir.ozone.ru/s3/multimedia-5/wc1000/6819155033.jpg"),
            new Product("Мрачный жнец", 
                350, 
                "Автор: Терри Пратчетт",
                "https://ir.ozone.ru/s3/multimedia-c/wc1000/6053518440.jpg"),
            new Product("Странник по звездам", 
                300, 
                "Автор: Джек Лондон",
                "https://ir.ozone.ru/s3/multimedia-5/wc1000/6324688829.jpg"),
            new Product("Крутые наследнички", 
                350, 
                "Автор: Дарья Донцова",
                "https://ir.ozone.ru/s3/multimedia-l/wc1000/6605430429.jpg"),
        };
        public List<Product> GetAll()
        {
            return products;
        }

        public Product TryGetById(int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                    return product;
            }
            return null;
        }
    }
}
