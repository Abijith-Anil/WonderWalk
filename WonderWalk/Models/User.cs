using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WonderWalk.Models
{
    /* Represents a user in the Wonder Walk app.
       Stores user ID, contact info, profile details, and lists of hunts they created, completed, or favorited. */
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; } // Should use Identity for security

        public string ProfilePictureUrl { get; set; }

        // Hunts created by the user
        public virtual ICollection<Hunt> CreatedHunts { get; set; } = new List<Hunt>();

        // Many-to-Many: Hunts the user has completed
        public virtual ICollection<UserHunt> CompletedHunts { get; set; } = new List<UserHunt>();

        // Many-to-Many: Favorite hunts
        public virtual ICollection<UserFavoriteHunt> FavoriteHunts { get; set; } = new List<UserFavoriteHunt>();
    }
}
