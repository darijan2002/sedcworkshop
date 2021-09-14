using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.Interfaces
{
    public interface IMovieService
    {
        Movie GetMovieByGenreId(int genreId);
        List<Movie> GetAll();
        Movie GetById(int id);
        void Create(Movie entity);
    }
}
