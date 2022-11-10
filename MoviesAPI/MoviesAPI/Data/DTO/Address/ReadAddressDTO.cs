using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.DTO
{
    public class ReadAddressDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int Number { get; set; }

    }
}
