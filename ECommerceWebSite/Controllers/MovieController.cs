using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using WebApplication3.Models;
using WebApplication3.Repository;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class MovieController : Controller
    {


        private IMovieRepository _movieRepository = RepositoryFactory.GetMovieRepository();
        private IGenreRepository _genreRepository = RepositoryFactory.GetGenreRepository();
        private IWebHostEnvironment _webHostEnvironment;

        public MovieController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }


        public IActionResult List()
        {




            String genreId = (String) RouteData.Values["id"];

            List<Movie> movies = null;

            if(genreId == null)
            {
                movies = _movieRepository.FindAll();
            }
            else
            {
                movies = _movieRepository.FindAllByGenreId(int.Parse(genreId));
            }

            return View(movies);
        }

        public IActionResult Detail(int? id)
        {
            Movie movie = null;

            if(id == null)
            {
                return NotFound();
            }

            try
            {
                movie = _movieRepository.FindById(id.Value);
            }
            catch(NotFoundException e)
            {
                return NotFound();
            }
            
            return View(movie);
        }

        public IActionResult Create()
        {
            MovieGenresViewModel movieGenresViewModel = new MovieGenresViewModel();

            movieGenresViewModel.Genres = _genreRepository.FindAll();
            movieGenresViewModel.Movie = new Movie();

            return View(movieGenresViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Movie movie, String theActors, int genreId, IFormFile imageUrl)
        {

            if(imageUrl != null)
            {
                String imageName = Guid.NewGuid().ToString() + imageUrl.FileName;

                String fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","img", imageName);
                using (FileStream fs = System.IO.File.Create(fullPath))
                {
                    await imageUrl.CopyToAsync(fs);
                }

                movie.ImageUrl = imageName;


            }


           


            if (ModelState.IsValid)
            {
                String[] actors = null;
                
                if(theActors != null)
                {
                    actors = theActors.Split(",");
                    movie.Actors = actors.ToList();
                }

                movie.Genre = _genreRepository.FindById(genreId);

                _movieRepository.Save(movie);
              
                return Redirect("/Movie/List");
            }

            return Create();

            
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return Redirect("/Movie/List");
            }

            _movieRepository.DeleteById(id.Value);

            return Redirect("/Movie/List");
        }

        public IActionResult Edit(int ? id)
        {
            if (id == null)
            {
                return Redirect("/Movie/List");
            }

            Movie movie = _movieRepository.FindById(id.Value);

            MovieGenresViewModel movieGenresViewModel = new MovieGenresViewModel();

            movieGenresViewModel.Genres = _genreRepository.FindAll();
            movieGenresViewModel.Movie = movie;

            return View("Create",movieGenresViewModel);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
