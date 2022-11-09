using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MoviesAPI.Models
{
    public class Address
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "'Street' is required")]
        public string Street { get; set; }
        public int Number { get; set; }
        public string City { get; set; }
        public Cinema Cinema { get; set; }
    }
}