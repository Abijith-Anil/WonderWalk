using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WonderWalk.Models
{
    /* Represents a comment made by a user on a hunt.
       Stores text, user, associated hunt, date, and optional replies/ratings. */
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int HuntId { get; set; }

        [Required]
        [MaxLength(1000)]
        public string CommentText { get; set; }

        public DateTime CommentDate { get; set; } = DateTime.UtcNow;

        public int? ParentCommentId { get; set; }  // Nullable for root comments

        public int Likes { get; set; } = 0;

        public int Dislikes { get; set; } = 0;

        // Navigation properties for EF Core
        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("HuntId")]
        public virtual Hunt Hunt { get; set; }

        [ForeignKey("ParentCommentId")]
        public virtual Comment ParentComment { get; set; }

        public virtual ICollection<Comment> Replies { get; set; } = new List<Comment>();
    }
}
