using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.DTO
{
    public class CreateCinemaDTO
    {
        [Required(ErrorMessage = "'Name' is required")]
        public string Name { get; set; }
        public int AddressId { get; set; }
    }
}
