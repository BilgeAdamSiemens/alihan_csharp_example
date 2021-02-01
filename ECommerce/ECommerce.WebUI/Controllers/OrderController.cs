using System;
using System.Collections.Generic;
using ECommerce.Data;
using ECommerce.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class OrderController : Controller
    {

        private IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IActionResult List()
        {
            List<Order> orders = _orderRepository.FindAll();

            return View(orders);
        }

        public IActionResult Detail(int id)
        {
            Order order = _orderRepository.FindById(id);

            return View(order);
        }

        public IActionResult Delete(int id)
        {
            _orderRepository.DeleteById(id);
            return RedirectToAction("List");
        }

        public IActionResult Save()
        {
            Cart cart = HttpContext.Session.GetObject<Cart>("cart");
            Customer customer = HttpContext.Session.GetObject<Customer>("customer");

            if (cart == null)
            {
                TempData["Message"] = "Sepet boş durumda";
                return Redirect("/Cart/Index");
            }
            else if(cart.CartItems.Count < 1)
            {
                TempData["Message"] = "Sepet boş durumda";
                return Redirect("/Cart/Index");
            }

            if(customer == null)
            {
                return Redirect("/Login/Form");
            }


            Order order = new Order
            {
                Cart = cart,
                Customer = customer,
                Date = DateTime.Now,
                OrderStatus = OrderStatus.Processing

            };
            _orderRepository.Save(order);

            Cart newCart = new Cart
            {
                Id = Guid.NewGuid().ToString()
            };

            HttpContext.Session.SetObject("cart", newCart);



            return RedirectToAction("List");
        }
    }
}
