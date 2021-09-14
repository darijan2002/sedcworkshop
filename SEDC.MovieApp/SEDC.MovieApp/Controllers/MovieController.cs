using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.MovieApp.Domain.Models;
using SEDC.MovieApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SEDC.MovieApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        // GET: api/<MovieController>
        [HttpGet("")]
        public ActionResult<IEnumerable<Movie>> Get()
        {
            return _movieService.GetAll();
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public ActionResult<Movie> GetById(int id)
        {
            return _movieService.GetById(id);
        }

        [HttpGet("genre/{genreId}")]
        public ActionResult<List<Movie>> GetByGenreId(int genreId)
        {
            var movies = _movieService.GetMoviesByGenreId(genreId);
            if (movies == null) return BadRequest();
            return movies;
        }

        // POST api/<MovieController>
        [HttpPost("")]
        public ActionResult Create([FromBody] Movie value)
        {
            int entityId = _movieService.Create(value);
            if (entityId == 0) return BadRequest();

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
