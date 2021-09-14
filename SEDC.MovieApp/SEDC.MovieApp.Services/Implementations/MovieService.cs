using SEDC.MovieApp.DataAccess.Repositories;
using SEDC.MovieApp.Domain.Models;
using SEDC.MovieApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.Implementations
{
    public class MovieService : IMovieService
    {
        private IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public void Create(Movie entity)
        {
            if (!_movieRepository.ExistsWithMovieTitle(entity.Title))
                _movieRepository.Create(entity);
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }

        public Movie GetById(int id)
        {
            return _movieRepository.GetById(id);
        }

        public Movie GetMovieByGenreId(int genreId)
        {
            return _movieRepository.GetMovieByGenreId(genreId);
        }
    }
}
