using System.Collections.Generic;
namespace SharedModels.Models;
/// Represents a "Hunt" in the Wonder Walk app, storing location-based challenge information.
public class Hunt
{
    public int HuntId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string ImageUrl { get; set; }
    public int CreatorUserId { get; set; }
    public string Hints { get; set; }
    public List<int> CompletedUserIds { get; set; }
    public List<string> Comments { get; set; }
}