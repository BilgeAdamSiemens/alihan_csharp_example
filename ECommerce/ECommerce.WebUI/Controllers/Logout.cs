using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
    public class Logout : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Remove("customer");

            return Redirect("/Home/Index");
        }
    }
}
