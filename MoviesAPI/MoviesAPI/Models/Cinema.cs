using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MoviesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "The filed 'name' is required")]
        public string Name { get; set; }
        public int AddressFK { get; set; }
        public int ManagerFK { get; set; }
    }
}