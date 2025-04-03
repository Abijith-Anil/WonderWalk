using System.ComponentModel.DataAnnotations;

namespace WonderWalk.Models
{
    /* Represents a location relevant to the app.
       Stores latitude, longitude, address, city, country, and optional details. */
    public class Location
    {
        [Key]
        public int LocationId { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        [Required]
        [MaxLength(255)]
        public string Address { get; set; }

        [Required]
        [MaxLength(100)]
        public required string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string Country { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        [MaxLength(500)]
        public string Tags { get; set; } // Consider using a List<string> with serialization
    }
}
