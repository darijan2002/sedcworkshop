using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.MovieApp.DataAccess.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public void Create(Movie entity)
        {
            entity.Id = StaticDB.Movies.Count;
            StaticDB.Movies.Add(entity);
        }

        public bool ExistsWithMovieTitle(string movieTitle)
        {
            return StaticDB.Movies.Any(x => x.Title == movieTitle);
        }

        public List<Movie> GetAll()
        {
            return StaticDB.Movies;
        }

        public Movie GetById(int id)
        {
            return StaticDB.Movies.SingleOrDefault(x => x.Id == id);
        }

        public Movie GetMovieByGenreId(int genreId)
        {
            return StaticDB.Movies.FirstOrDefault(x => x.MovieGenreId == genreId);
        }
    }
}
