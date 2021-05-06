using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class CommentViewModel
    { 
        public int ProductId { get; set; }
        public int CommentId { get; set; }
        public int UserId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public DateTime CreateDate { get; set; }
        public string Positive { get; set; }
        public string Negative { get; set; }
        public int CommentLike { get; set; }
        public int DisLike { get; set; }
        public string UserName { get; set; }
        

    }
}
