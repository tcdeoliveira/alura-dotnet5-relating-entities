using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Data.DTO
{
    public class ReadAddressDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }

    }
}
