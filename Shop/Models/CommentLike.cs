using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class CommentLike
    {
        public int CommentLikeId { get; set; }
        public bool Type { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int CommentId { get; set; }

        public Comment Comment { get; set; }
    }
}
