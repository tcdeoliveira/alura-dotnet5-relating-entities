using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesAPI.Data.DTO
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "'Name' is required")]
        public string Name { get; set; }
        public int AddressFK { get; set; }
        public int ManagerFK { get; set; }
    }
}
