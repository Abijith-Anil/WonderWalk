using System;
namespace SharedModels.Models;
/// Represents an image uploaded by a user, including URL, uploader, hunt, date, caption, and location data.
public class Image
{
    public int ImageId { get; set; }
    public string ImageUrl { get; set; }
    public int UserId { get; set; }
    public int HuntId { get; set; }
    public DateTime UploadDate { get; set; }
    public string Caption { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string Tags { get; set; }
}