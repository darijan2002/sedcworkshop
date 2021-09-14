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
        public void Create(Genre entity)
        {
            entity.Id = StaticDB.Genres.Count;
            StaticDB.Genres.Add(entity);
        }

        public List<Genre> GetAll()
        {
            return StaticDB.Genres;
        }

        public Genre GetById(int id)
        {
            return StaticDB.Genres.SingleOrDefault(x => x.Id == id);
        }
    }
}
