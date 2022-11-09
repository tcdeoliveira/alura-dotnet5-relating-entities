using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.DTO
{
    public class ReadCinemaDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "'Name' is required")]
        public string Name { get; set; }
        public object Address { get; set; }
    }
}
