using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Repository;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {

        private IMovieRepository movieRepository = RepositoryFactory.GetMovieRepository();


        public IActionResult Index(int? id)
        {

            

            if(id == null)
            {
                id = 1;
            }

            List<Movie> movies = movieRepository.GetPopularMovies(id);

            return View(movies);
        }

        public IActionResult About()
        {
            return View();
        }

        public Movie Movie()
        {
            String title = "Film Adi";
            String description = "Film aciklamasi";
            String director = "Film yonetmeni";
            String[] actors = { "Oyuncu 1", "Oyuncu 2" };

            Movie movie = new Movie
            {
                Title = title,
                Description = description,
                Director = director,
                Actors = actors.ToList()
            };

            return movie;
        }
    }
}
