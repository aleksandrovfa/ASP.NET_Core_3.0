using OnlineShopWebApp.Models;

namespace OnlineShopWebApp
{
    public interface ICartRepository
    {
        Cart TryGetByUserId(string userId);

        void AddItem(Product product, string userId);
        void RemoveItem(Product product, string userId);
        void Clear(string userId);
    }
}