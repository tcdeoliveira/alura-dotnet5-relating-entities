using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.DTO
{
    public class CreateCinemaDTO
    {
        [Required(ErrorMessage = "'Name' is required")]
        public string Name { get; set; }
        public int AddressFK { get; set; }
        public int ManagerFK { get; set; }
    }
}
