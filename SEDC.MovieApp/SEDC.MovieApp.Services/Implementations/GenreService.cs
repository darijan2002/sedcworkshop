using SEDC.MovieApp.DataAccess.Repositories;
using SEDC.MovieApp.Domain.Models;
using SEDC.MovieApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.Implementations
{
    public class GenreService : IGenreService
    {
        private IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public void Create(Genre entity)
        {
            _genreRepository.Create(entity);
        }

        public List<Genre> GetAll()
        {
            return _genreRepository.GetAll();
        }

        public Genre GetById(int id)
        {
            return _genreRepository.GetById(id);
        }
    }
}
