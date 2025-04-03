namespace WonderWalkApi.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty; // Default value
        public string Email { get; set; } = string.Empty;    // Default value
        public string PasswordHash { get; set; } = string.Empty; // Default value
    }
}