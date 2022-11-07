using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Models;
using System.Collections.Generic;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private static List<Movie> movies = new List<Movie>();
        [HttpPost]
        public void Add([FromBody]Movie movie)
        {
            movies.Add(movie);
        }
    }
}
