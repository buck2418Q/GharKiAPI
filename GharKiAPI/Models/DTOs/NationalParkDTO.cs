using System.ComponentModel.DataAnnotations;

namespace GharKiAPI.Models.DTO
{
    public class NationalParkDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string State { get; set; }
        public Byte[]? Picture { get; set; }
        public DateTime Created { get; set; }
        public DateTime Established { get; set; }
    }
}
