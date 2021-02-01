using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public class GenreRepository : IGenreRepository
    {

        private List<Genre> _genres = new List<Genre>();
        private int _idCounter = 0;

        public GenreRepository()
        {
            _genres.Add(new Genre { Name = "Komedi", Id = 1 });
            _genres.Add(new Genre { Name = "Korku", Id = 2 });
            _genres.Add(new Genre { Name = "Gerilim", Id = 3 });
            _genres.Add(new Genre { Name = "Bilim Kurgu", Id = 4 });
            _genres.Add(new Genre { Name = "Macera", Id = 5 });
            _genres.Add(new Genre { Name = "Aksiyon", Id = 6 });
        }

        public void Delete(Genre entity)
        {
            DeleteById(entity.Id);
        }

        public void DeleteById(int id)
        {
            _genres.Remove(FindById(id));
        }

        public List<Genre> FindAll()
        {
            return _genres;
        }

        public Genre FindById(int id)
        {
            Genre genre = _genres.Find(genre => genre.Id == id);

            if (genre == null)
                throw new NotFoundException("Genre not found!");

            return genre;
        }

        public Genre Save(Genre entity)
        {
            if (entity.Id == 0)
            {
                entity.Id = ++_idCounter;
                _genres.Add(entity);
            }
            else if (entity.Id > 0)
            {
                Genre genre = FindById(entity.Id);

                genre.Name = entity.Name;

                entity = genre;

            }

            return entity;
        }
    }

    class NotFoundException : Exception
    {
        public NotFoundException(String message):base(message)
        {

        }
    }
}
