using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Repository;

namespace WebApplication3.ViewComponents
{
    public class GenresViewComponent : ViewComponent
    {

        private IGenreRepository _genreRepository = RepositoryFactory.GetGenreRepository();

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedId = 0;
            if(RouteData.Values["id"] != null && RouteData.Values["action"].ToString() == "List")
                ViewBag.SelectedId = int.Parse(RouteData.Values["id"].ToString());

            List<Genre> genres = _genreRepository.FindAll();

            return View(genres);

        }

    }
}
