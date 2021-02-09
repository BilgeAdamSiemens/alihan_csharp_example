using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class AboutController : Controller
    {
        [Authorize]
        public IActionResult Index(){
            return View();
        }
    }
}