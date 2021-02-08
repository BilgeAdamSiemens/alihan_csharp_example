using System;

namespace Entity
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public Post Post { get; set; }
        public int PostId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}