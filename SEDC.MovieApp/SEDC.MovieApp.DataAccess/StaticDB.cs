using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;

namespace SEDC.MovieApp.DataAccess
{
    public static class StaticDB
    {
        public static List<Movie> Movies = new List<Movie> { };
        public static List<Genre> Genres = new List<Genre> { };
    }
}
