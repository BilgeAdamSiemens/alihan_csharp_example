using System.Linq;
using Data;
using Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebUI.Controllers
{
    public class PostController : Controller
    {
        private MyDbContext _myDbContext;
        public PostController(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public IActionResult Detail(int id){
            Post post = _myDbContext.Posts.Include(p => p.User).FirstOrDefault(p => p.PostId == id);
            return View(post);
        }
    }
}