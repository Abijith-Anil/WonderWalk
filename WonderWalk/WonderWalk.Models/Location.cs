namespace SharedModels.Models;
/// Represents a location relevant to the app, including coordinates, address, city, country, description, image, and tags.
public class Location
{
    public int LocationId { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string Tags { get; set; }
}