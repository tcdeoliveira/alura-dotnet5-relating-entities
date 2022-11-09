using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MoviesAPI.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title could not be null")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Diretor could not be null")]
        public string Director { get; set; }
        [StringLength(30, ErrorMessage = "Max Length - 30 char")]
        public string Category { get; set; }
        [Range(1, 600, ErrorMessage = "Duration Range - min 1 and max 600")]
        public int Duration { get; set; }
    }
}
