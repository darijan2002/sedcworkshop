using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.DataAccess.Repositories
{
    public interface IMovieRepository : IRepository<Movie>
    {
        List<Movie> GetMoviesByGenreId(int genreId);
        bool ExistsWithMovieTitle(string movieTitle);
    }
}
