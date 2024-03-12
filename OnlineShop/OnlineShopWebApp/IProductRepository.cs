using OnlineShopWebApp.Models;
using System.Collections.Generic;

namespace OnlineShopWebApp
{
    public interface IProductRepository
    {
        List<Product> GetAll();

        Product GetById(int id);
        
    }
}
