 /*This class represents an image uploaded by a user. It stores the image's URL, the user who uploaded it, the hunt it's associated with, the upload date, caption, and optional location data.*/
public class Image
{
    public int ImageId;
    public string ImageUrl;
    public int UserId;
    public int HuntId;
    public DateTme UploadDate;
    public String Caption;
    public double Latitude;
    public double Longitude;
    public String Tags;
}