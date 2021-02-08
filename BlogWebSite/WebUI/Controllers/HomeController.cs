using System.Collections.Generic;
using System.Linq;
using Data;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebUI.Controllers
{
    public class HomeController : Controller
    {

        private MyDbContext _myDbContext;

        public HomeController(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        

        public IActionResult Index(){
            List<Post> posts = _myDbContext.Posts.Include(p => p.User).ToList();
            ViewBag.Title = "Bayrktlihn/Home/Index";
            return View(posts);
        }
    }
}