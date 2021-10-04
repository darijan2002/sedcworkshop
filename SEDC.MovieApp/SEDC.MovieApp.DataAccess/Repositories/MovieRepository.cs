using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.MovieApp.DataAccess.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public int Create(Movie entity)
        {
            entity.MovieId = StaticDB.Movies.Count + 1;
            StaticDB.Movies.Add(entity);
            return entity.MovieId;
        }

        public bool ExistsWithMovieTitle(string movieTitle)
        {
            return StaticDB.Movies.Any(x => x.Title == movieTitle);
        }

        public IEnumerable<Movie> GetAll()
        {
            return StaticDB.Movies.Select(x =>
            {
                x.MovieGenre = StaticDB.Genres.SingleOrDefault(y => y.Id == x.MovieGenreId);
                return x;
            }).ToList();
        }

        public Movie GetById(int id)
        {
            Movie movie = StaticDB.Movies.SingleOrDefault(x => x.MovieId == id);
            movie.MovieGenre = StaticDB.Genres.SingleOrDefault(y => y.Id == movie.MovieGenreId);
            return movie;
        }

        public List<Movie> GetMoviesByGenreId(int genreId)
        {
            var movies = StaticDB.Movies
                .Where(x => x.MovieGenreId == genreId)
                .Select(x =>
            {
                x.MovieGenre = StaticDB.Genres.SingleOrDefault(y => y.Id == x.MovieGenreId);
                return x;
            }).ToList();

            return movies;
        }
    }
}
