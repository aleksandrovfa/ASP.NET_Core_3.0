using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using System.Linq;
using System.Web;

namespace OnlineShopWebApp.Controllers
{
    public class CartController : Controller
    {
        private ProductRepository repository;
        public CartController()
        {
            repository = new ProductRepository();
        }

        public IActionResult Index()
        {
            return View(CartLineRepository.Lines);
        }


        public IActionResult Add(int productId)
        {
            Product product = repository.GetAll()
                .FirstOrDefault(g => g.Id == productId);

            if (product != null)
            {
                CartLineRepository.AddItem(product, 1);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Remove(int productId)
        {
            Product game = repository.GetAll()
                .FirstOrDefault(g => g.Id == productId);

            if (game != null)
            {
                CartLineRepository.RemoveLine(game);
            }
            return RedirectToAction("Index");
        }

        //public Cart GetCart()
        //{
        //    Cart cart = (Cart)Session["Cart"];
        //    if (cart == null)
        //    {
        //        cart = new Cart();
        //        Session["Cart"] = cart;
        //    }
        //    return cart;
        //}
    }
}

