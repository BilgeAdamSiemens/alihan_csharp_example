using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class GenresMoviesViewModel
    {
        public List<Genre> Genres { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
