using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Repository
{
    public class RepositoryFactory
    {
        private static IGenreRepository genreRepository = new GenreRepository();
        private static IMovieRepository movieRepository = new MovieRepository();
    
        public static IGenreRepository GetGenreRepository()
        {
            return genreRepository;
        }

        public static IMovieRepository GetMovieRepository()
        {
            return movieRepository;
        }
    
    }
}
