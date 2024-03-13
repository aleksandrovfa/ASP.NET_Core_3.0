using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using OnlineShopWebApp.Models;
using System.Linq;
using System.Web;
using Constants = OnlineShopWebApp.InMemoryConstants;

namespace OnlineShopWebApp.Controllers
{
    public class CartController : Controller
    {
        private readonly IConstants constants;
        private readonly IProductRepository productRepository;
        private readonly ICartRepository cartRepository;
        public CartController(ICartRepository cartRepository, IProductRepository productRepository, IConstants constants)
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

        public IActionResult Remove(int productId)
        {
            Product product = productRepository.GetAll()
                .FirstOrDefault(g => g.Id == productId);

            if (product != null)
            {
                cartRepository.RemoveItem(product, constants.UserId);
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

