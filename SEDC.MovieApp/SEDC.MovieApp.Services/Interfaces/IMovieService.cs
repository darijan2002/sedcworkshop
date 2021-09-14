using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetMoviesByGenreId(int genreId);
        List<Movie> GetAll();
        Movie GetById(int id);
        int Create(Movie entity);
    }
}
