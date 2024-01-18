using System.ComponentModel.DataAnnotations;

namespace GharKiAPI.Models
{
    public class NationalPark
    {
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public required string State { get; set; }
        public Byte[]? Picture { get; set; }
        public DateTime Created { get; set; }
        public DateTime Established { get; set; }
    }
}
