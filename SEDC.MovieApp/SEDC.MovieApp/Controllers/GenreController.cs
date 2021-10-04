using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.MovieApp.Domain.Models;
using SEDC.MovieApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.GenreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private IGenreService _genreService;
        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        // GET: api/<GenreController>
        [HttpGet("")]
        public ActionResult<IEnumerable<Genre>> Get()
        {
            return Ok(_genreService.GetAll());
        }

        // GET api/<GenreController>/5
        [HttpGet("{id}")]
        public ActionResult<Genre> GetById(int id)
        {
            return _genreService.GetById(id);
        }

        // POST api/<GenreController>
        [HttpPost("")]
        public ActionResult Create([FromBody] Genre value)
        {
            _genreService.Create(value);
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
