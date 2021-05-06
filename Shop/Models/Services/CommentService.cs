using Shop.Data;
using Shop.Models.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class CommentService : ICommentService
    {
        DBShop dB;
        public CommentService(DBShop dBShop)
        {
            dB = dBShop;

        }

        public Tuple<List<CommentViewModel>, int> GetComment(int Productid, int Take)
        {
            IQueryable<CommentViewModel> comments = (from c in dB.Comments
                                                     join u in dB.users on c.UserId equals u.UserId
                                                     where c.ProductId == Productid
                                                     select new CommentViewModel
                                                     {
                                                         CommentId = c.CommentId,
                                                         CommentText = c.CommentText,
                                                         CommentTitle = c.CommentTitle,
                                                         CommentLike = c.CommentLike,
                                                         CreateDate = c.CreateDate,
                                                         DisLike = c.DisLike,
                                                         Positive = c.Positive,
                                                         Negative = c.Negative,
                                                         UserName = c.User.UserName

                                                     });
            var Count = comments.Count();
            return Tuple.Create(comments.Take(Take).ToList(), Count);
        }

        public List<CommentViewModel> GetCommentByFilter(int Productid, int Pagenumber, int Sort, int Take)
        {
            int Skip = (Pagenumber - 1) * Take;
            IQueryable<Comment> Getcomment = dB.Comments.Where(c => c.ProductId == Productid);
            if (Sort == 2)
                Getcomment = Getcomment.OrderByDescending(b => b.CommentLike);

            if (Sort == 3)
                Getcomment = Getcomment.OrderByDescending(c => c.CreateDate);

            List<CommentViewModel> CommentList = Getcomment.Select(c => new CommentViewModel
            {
                CommentId = c.CommentId,
                CommentText = c.CommentText,
                CommentTitle = c.CommentTitle,
                CommentLike = c.CommentLike,
                CreateDate = c.CreateDate,
                DisLike = c.DisLike,
                Positive = c.Positive,
                Negative = c.Negative,
                UserName = c.User.UserName

            }).Skip(Skip).Take(Take).ToList();

            return CommentList;
        }
    }
}
