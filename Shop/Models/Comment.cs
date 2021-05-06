using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public DateTime CreateDate { get; set; }
        public string Positive { get; set; }
        public string Negative { get; set; }
        public int CommentLike { get; set; }
        public int DisLike { get; set; }
        public bool IsConfirm { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
        public List<CommentLike> CommentLikes { get; set; }

    }
}
