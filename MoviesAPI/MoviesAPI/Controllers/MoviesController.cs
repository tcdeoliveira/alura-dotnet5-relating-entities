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
        public void Add([FromBody]Movie movie)
        {
            movie.Id = id++;
            movies.Add(movie);
        }

        [HttpGet]
        public IEnumerable<Movie> GetMovies()
        {
            return movies;
        }

        [HttpGet("{id}")]
        public Movie GetMovieById(int id)
        {
            return movies.FirstOrDefault(movie => movie.Id == id);
        }
    }
}
