using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.MovieApp.DataAccess.Repositories;
using SEDC.MovieApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.MovieApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return userRepository.GetAll();
        }

        [HttpPost]
        public int Create(User model)
        {
            return userRepository.Create(model);
        }

        [HttpGet("byId")]
        public User GetById(int id)
        {
            return userRepository.GetById(id);
        }

        [HttpGet("byUsername")]
        public User GetByUsername(string username)
        {
            return userRepository.GetByUsername(username);
        }
    }
}
