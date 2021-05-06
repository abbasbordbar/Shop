using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{
   public interface ICommentService
    {
        Tuple<List<CommentViewModel>, int> GetComment(int Productid, int Take);
        List<CommentViewModel> GetCommentByFilter(int Productid, int Pagenumber, int Sort, int Take);
    }
}
