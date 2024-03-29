﻿using System.ComponentModel.DataAnnotations.Schema;

namespace GharKiAPI.Models
{
    public class Trail
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public
            required string Distance
        { get; set; }

        public required string Elevation { get; set; }
        public DateTime DateCreated { get; set; }
        public enum DifficultyLevel { Easy, Medium, Hard }
        public DifficultyLevel Difficulty { get; set; }
        public int NationalParkID { get; set; }
        [ForeignKey("NationalParkId")]
        public NationalPark? NationalPark { get; set; }


    }
}
