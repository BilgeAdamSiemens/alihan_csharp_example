using System;
using ECommerce.Data;
using ECommerce.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ECommerce.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository _productRepository;

        public CartController(IProductRepository productRepository )
        {
            _productRepository = productRepository;
        }

        public IActionResult Delete(int? id)
        {
            Cart cart = HttpContext.Session.GetObject<Cart>("cart");
            cart.RemoveCartItemByProductId(id.Value);
            HttpContext.Session.SetObject("cart", cart);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            
            Cart cart = HttpContext.Session.GetObject<Cart>("cart");

            ViewBag.Message = TempData["Message"];
            
            if(cart == null)
            {
                cart = new Cart
                {
                    Id = Guid.NewGuid().ToString()
                };
                HttpContext.Session.SetObject("cart", cart);
            }
            
            return View(cart);
        }

        [HttpPost]
        public IActionResult Save(int ?productId, int? quantity) {

            Cart cart = null;

            Product product = _productRepository.FindById(productId.Value);

           


            if (HttpContext.Session.GetObject<Cart>("cart") == null)
            {
                cart = new Cart
                {
                    Id = Guid.NewGuid().ToString()
                };
                HttpContext.Session.SetObject("cart", cart);
            }

            cart = HttpContext.Session.GetObject<Cart>("cart");

            cart.AddProduct(product, quantity.Value);
            HttpContext.Session.SetObject("cart", cart);


            return RedirectToAction("Index");
        }
    }

    public static class SessionExtensions
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
