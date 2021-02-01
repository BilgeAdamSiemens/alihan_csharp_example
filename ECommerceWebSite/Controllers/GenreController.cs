using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Repository;

namespace WebApplication3.Controllers
{
    public class GenreController : Controller
    {
        private IMovieRepository _movieRepository = RepositoryFactory.GetMovieRepository();

        public IActionResult List(int id)
        {
            
            return View();
        }
    }
}
