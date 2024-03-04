using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using OnlineShopWebApp.Models;
using System.Linq;
using System.Web;
using Constants = OnlineShopWebApp.Constants;

namespace OnlineShopWebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly Constants constants;
        private readonly ProductRepository productRepository;
        private readonly CartRepository cartRepository;
        public CartController(CartRepository cartRepository, ProductRepository productRepository, Constants constants)
        {
            this.productRepository = productRepository;
            this.cartRepository = cartRepository;
            this.constants = constants;
        }

        public IActionResult Index()
        {
            
            return View(cartRepository.TryGetByUserId(constants.UserId));
        }


        public IActionResult Add(int productId)
        {
            Product product = productRepository.GetAll()
                .FirstOrDefault(g => g.Id == productId);

            if (product != null)
            {
                cartRepository.AddItem(product, constants.UserId);
            }
            return RedirectToAction("Index");
        }

        //public IActionResult Remove(int productId)
        //{
        //    Product game = productRepository.GetAll()
        //        .FirstOrDefault(g => g.Id == productId);

        //    if (game != null)
        //    {
        //        CartRepository.RemoveLine(game);
        //    }
        //    return RedirectToAction("Index");
        //}

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

