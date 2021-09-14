using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Domain.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int MovieGenreId { get; set; } // FK
        public Genre MovieGenre { get; set; }
    }
}
