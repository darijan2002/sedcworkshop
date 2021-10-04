using SEDC.MovieApp.DataAccess.Repositories;
using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.MovieApp.DataAccess.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        public int Create(Genre entity)
        {
            entity.Id = StaticDB.Genres.Count+1;
            StaticDB.Genres.Add(entity);
            return entity.Id;
        }

        public bool ExistsWithId(int id)
        {
            return StaticDB.Genres.Any(x => x.Id == id);
        }

        public IEnumerable<Genre> GetAll()
        {
            return StaticDB.Genres;
        }

        public Genre GetById(int id)
        {
            return StaticDB.Genres.SingleOrDefault(x => x.Id == id);
        }
    }
}
