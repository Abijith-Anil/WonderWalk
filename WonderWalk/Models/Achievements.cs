namespace WonderWalk.Models
{
    /*
        This class represents an achievement that a user can earn. It stores the achievement's title, description, image, points, and criteria for earning it.
        */
    public class Achievement
    {
        public int AchievementId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int Points { get; set; }
        public string Criteria { get; set; }
        public Achievement() { }
    }
}