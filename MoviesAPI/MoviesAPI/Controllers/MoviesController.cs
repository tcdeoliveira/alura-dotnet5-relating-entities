using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }

        private static List<Movie> movies = new List<Movie>();
        [HttpPost]
        public IActionResult Add([FromBody]Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMovieById), new {Id = movie.Id}, movie);
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(_context.Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            if (movie != null)
            {
                return Ok(movie);
            }
            return NotFound();

        }
    }
}
