using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WonderWalk.Models
{
    /* Represents a "Hunt" in the Wonder Walk app.
       Stores information about a location-based challenge, 
       including title, description, location, image, creator, hints, and completion status. */
    public class Hunt
    {
        [Key]
        public int HuntId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public int CreatorUserId { get; set; }

        [MaxLength(500)]
        public string Hints { get; set; }

        // Navigation property for the creator
        [ForeignKey("CreatorUserId")]
        public virtual User Creator { get; set; }

        // Many-to-Many: Users who completed this hunt
        public virtual ICollection<UserHunt> CompletedUsers { get; set; } = new List<UserHunt>();

        // Comments related to this hunt
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
