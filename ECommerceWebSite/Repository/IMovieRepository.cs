using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public interface IMovieRepository : IRepository<Movie, int>
    {
        List<Movie> GetPopularMovies(int? amount);
        List<Movie> FindAllByGenreId(int id);
    }
}
