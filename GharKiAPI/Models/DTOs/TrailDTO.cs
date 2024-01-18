using System.ComponentModel.DataAnnotations.Schema;
using static GharKiAPI.Models.Trail;

namespace GharKiAPI.Models.DTO
{
    public class TrailDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public required string Distance { get; set; }

        public required string Elevation { get; set; }
        public DateTime DateCreated { get; set; }
        public DifficultyLevel Difficulty { get; set; }
        public int NationalParkID { get; set; }
        [ForeignKey("NationalParkId")]
        public NationalPark? NationalPark { get; set; }
    }
}
