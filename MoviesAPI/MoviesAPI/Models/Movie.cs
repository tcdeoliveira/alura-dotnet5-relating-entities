using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    public class Movie
    {
        [Required(ErrorMessage = "Title could not be null")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Diretor could not be null")]
        public string Director { get; set; }
        public string Category { get; set; }
        [Range(1, 600, ErrorMessage = "Duration Range - min 1 and max 600")]
        public int Duration { get; set; }
    }
}
