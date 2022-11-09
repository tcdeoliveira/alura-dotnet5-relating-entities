using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.DTO
{
    public class UpdateCinemaDTO
    {
        [Required(ErrorMessage = "'Name' is required")]
        public string Name { get; set; }
    }
}
