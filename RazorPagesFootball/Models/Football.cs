using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesFootball.Models
{
    public class Football
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string TeamName { get; set; }
 

        [DataType(DataType.Date)]
        public DateTime EstablishedDate { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Country { get; set; }
        public int WinningTimes { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string BestPlayer { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CoachName { get; set; }

        [Range(1, 100, ErrorMessage = "Can not be null, please add a value")]
        public int BestPlayerShirtNumber { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string CoachCountry { get; set; }



    }
}
