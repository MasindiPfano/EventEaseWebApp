using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEaseWebApp.Models
{
    public class Venue
    {
        public int VenueID { get; set; }
        public string VenueName { get; set; }
        public string Location { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be greater that 0")]
        public int Capacity { get; set; }
        public string? ImageUrl { get; set; }

        //Step3 
        [NotMapped]

        public IFormFile? ImageFile { get; set; }
    }
}
