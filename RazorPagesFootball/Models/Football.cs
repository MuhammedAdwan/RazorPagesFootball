using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesFootball.Models
{
    public class Football
    {
        public int ID { get; set; }
        public string TeamName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EstablishedDate { get; set; }
        public string Country { get; set; }
        public int WinningTimes { get; set; }
        public string BestPlayer { get; set; }

        public string CoachName { get; set; }

    }
}
