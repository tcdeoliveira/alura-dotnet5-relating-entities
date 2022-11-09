using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MoviesAPI.Data.DTO
{
    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "'Name' is required")]
        public string Name { get; set; }
        public object Address { get; set; }
    }
}
