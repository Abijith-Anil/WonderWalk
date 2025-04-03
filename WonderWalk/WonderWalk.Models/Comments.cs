using System;
namespace SharedModels.Models;
/// Represents a comment made by a user on a hunt, including its text, user, hunt, date, replies, and ratings.
public class Comment
{
    public int CommentId { get; set; }
    public int UserId { get; set; }
    public int HuntId { get; set; }
    public string CommentText { get; set; }
    public DateTime CommentDate { get; set; }
    public int? ParentCommentId { get; set; } 
    public int Likes { get; set; }
    public int Dislikes { get; set; }
}