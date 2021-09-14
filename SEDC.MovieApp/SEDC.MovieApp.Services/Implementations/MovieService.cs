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
        private IGenreRepository _genreRepository;

        public MovieService(IMovieRepository movieRepository, IGenreRepository genreRepository)
        {
            _movieRepository = movieRepository;
            _genreRepository = genreRepository;
        }
        public int Create(Movie entity)
        {
            if (_movieRepository.ExistsWithMovieTitle(entity.Title))
                return 0;
            if (!_genreRepository.ExistsWithId(entity.MovieGenreId))
                return 0;
            return _movieRepository.Create(entity);
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }

        public Movie GetById(int id)
        {
            return _movieRepository.GetById(id);
        }

        public List<Movie> GetMoviesByGenreId(int genreId)
        {
            if (!_genreRepository.ExistsWithId(genreId))
                return null;
            return _movieRepository.GetMoviesByGenreId(genreId);
        }
    }
}
