using System.Collections.Generic;
using WebApplication3.Models;
using System.Linq;

namespace WebApplication3.Repository
{
    public class MovieRepository : IMovieRepository
    {

        private List<Movie> _movies = new List<Movie>();
        private int _idCounter = 0;
        private IGenreRepository genreRepository = RepositoryFactory.GetGenreRepository();

        public MovieRepository()
        {
            Movie movie = new Movie
            {
                Id = ++_idCounter,
                Title = "The Shawshank Redemption",
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                Director = "Frank Darabont",
                Actors = new List<string> { "Tim Robbins", "Morgan Freeman", "Bob Gunton" },
                ImageUrl = "film1.jpg",
                Popularity = 4.8,
                Genre = genreRepository.FindById(1)

            };
            _movies.Add(movie);

            movie = new Movie
            {
                Id = ++_idCounter,
                Title = "The Godfather",
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                Director = "Francis Ford Coppola",
                Actors = new List<string> { "Marlon Brando", "Al Pacino", "James Caan" },
                ImageUrl = "film2.jpg",
                Popularity = 4.7,
                Genre = genreRepository.FindById(1)
            };
            _movies.Add(movie);

            movie = new Movie
            {
                Id = ++_idCounter,
                Title = "The Dark Knight",
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                Director = "Christopher Nolan",
                Actors = new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart" },
                ImageUrl = "film3.jpg",
                Popularity = 4.6,
                Genre = genreRepository.FindById(2)
            };
            _movies.Add(movie);

            movie = new Movie
            {
                Id = ++_idCounter,
                Title = "The Godfather: Part II",
                Description = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                Director = "Francis Ford Coppola",
                Actors = new List<string> { "Al Pacino", "Robert De Niro", "Robert Duvall" },
                ImageUrl = "film4.jpg",
                Popularity = 4.5,
                Genre = genreRepository.FindById(1)
            };
            _movies.Add(movie);

            movie = new Movie
            {
                Id = ++_idCounter,
                Title = "Inception",
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.",
                Director = "Christopher Nolan",
                Actors = new List<string> { "Leonardo DiCaprio", "Joseph Gordon-Levitt", "Elliot Page" },
                ImageUrl = "film5.jpg",
                Popularity = 4.4,
                Genre = genreRepository.FindById(3)
            };
            _movies.Add(movie);
        }

        public void Delete(Movie entity)
        {
            DeleteById(entity.Id);
        }

        public void DeleteById(int id)
        {
            Movie movie = FindById(id);
            _movies.Remove(movie);
        }

        public List<Movie> FindAll()
        {
            return _movies;
        }

        public List<Movie> FindAllByGenreId(int id)
        {
            return _movies.Where(movie => movie.Genre.Id == id).ToList();
        }

        public Movie FindById(int id)
        {
            Movie movie =  _movies.Find(movie => movie.Id == id);

            if (movie == null)
                throw new NotFoundException("Movie not found!");

            return movie;
        }

        public List<Movie> GetPopularMovies(int? amount)
        {
            return _movies.OrderByDescending(movie => movie.Popularity).Take(amount.Value).ToList();
        }

        public Movie Save(Movie entity)
        {
            if(entity.Id == 0)
            {
                entity.Id = ++_idCounter;
                _movies.Add(entity);
            } else if(entity.Id > 0)
            {
                Movie movie = FindById(entity.Id);

                movie.Director = entity.Director;
                movie.Actors = entity.Actors;
                movie.Description = entity.Description;
                movie.ImageUrl = entity.ImageUrl;
                movie.Title = entity.Title;

                entity = movie;
            }
            return entity;
        }
    }
}
