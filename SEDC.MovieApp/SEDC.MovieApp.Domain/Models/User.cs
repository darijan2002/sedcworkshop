using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.MovieApp.Domain.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
