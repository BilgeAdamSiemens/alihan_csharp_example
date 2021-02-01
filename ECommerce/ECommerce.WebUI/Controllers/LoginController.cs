using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Data;
using ECommerce.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class LoginController : Controller
    {

        private ICustomerRepository _customerRepository;

        public LoginController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IActionResult Form()
        {
            ViewBag.Message = TempData["Message"];
            ViewBag.LogoutMessage = TempData["LogoutMessage"];
            return View();
        }

        public IActionResult Enter(String fullName)
        {
            if(fullName == null)
            {
                return RedirectToAction("Form");
            }

            Customer customer = _customerRepository.FindByFullName(fullName);

            if(customer == null)
            {
                TempData["Message"] = "Boyle bir kullanıcı bulunamadı";
                return RedirectToAction("Form");
            }

            HttpContext.Session.SetObject("customer", customer);

            return Redirect("/Home/Index");
        }

       
    }
}
