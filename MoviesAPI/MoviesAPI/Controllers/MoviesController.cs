using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Data.DTO;
using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private MovieContext _context;
        private Mapper _mapper;

        public MoviesController(MovieContext context, Mapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        private static List<Movie> movies = new List<Movie>();
        [HttpPost]
        public IActionResult Add([FromBody]CreateMovieDTO movieDTO)
        {
            
            Movie movie = _mapper.Map<Movie>(movieDTO);
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
                ReadMovieDTO movieDTO = _mapper.Map<ReadMovieDTO>(movie);
                return Ok(movieDTO);
            }
            return NotFound();

        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]UpdateMovieDTO movieDTO)
        {
            
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            _mapper.Map(movieDTO, movie);
            movie.Title = movieDTO.Title;
            movie.Category = movieDTO.Category;
            movie.Duration = movieDTO.Duration;
            movie.Director = movieDTO.Director;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            _context.Remove(movie);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
