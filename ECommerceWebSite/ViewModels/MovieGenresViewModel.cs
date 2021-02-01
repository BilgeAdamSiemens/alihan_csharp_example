using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class MovieGenresViewModel
    {
        public Movie Movie { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
