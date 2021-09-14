using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Services.Interfaces
{
    public interface IGenreService
    {
        List<Genre> GetAll();
        Genre GetById(int id);
        void Create(Genre entity);
    }
}
