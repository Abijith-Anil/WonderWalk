namespace SharedModels.Models; 
/// Represents an achievement that a user can earn, including its ID, title, description, image URL, points, and criteria.
public class Achievement
{
    public int AchievementId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public int Points { get; set; }
    public string Criteria { get; set; }
}