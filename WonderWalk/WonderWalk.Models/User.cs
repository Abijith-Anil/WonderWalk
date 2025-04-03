using System.Collections.Generic;
namespace SharedModels.Models;
/// Represents a user in the Wonder Walk app, including identification, contact info, profile details, and hunt lists.
public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string ProfilePictureUrl { get; set; }
    public List<int> CreatedHuntIds { get; set; }
    public List<int> CompletedHuntIds { get; set; }
    public List<int> FavoriteHuntIds { get; set; }
}