using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.DataAccess.Repositories
{
    public interface IGenreRepository : IRepository<Genre>
    {
        bool ExistsWithId(int id);
    }
}
