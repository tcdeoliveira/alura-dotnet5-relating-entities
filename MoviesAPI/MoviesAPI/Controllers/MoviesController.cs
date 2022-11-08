using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private static int id = 1;

        private static List<Movie> movies = new List<Movie>();
        [HttpPost]
        public IActionResult Add([FromBody]Movie movie)
        {
            movie.Id = id++;
            movies.Add(movie);
            return CreatedAtAction(nameof(GetMovieById), new {Id = movie.Id}, movie);
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            Movie movie = movies.FirstOrDefault(movie => movie.Id == id);
            if (movie != null)
            {
                return Ok(movie);
            }
            return NotFound();

        }
    }
}
