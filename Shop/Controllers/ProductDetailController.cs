using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Models.Interfaces;
using Shop.Models.Services;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class ProductDetailController : Controller
    {
        IProductDetail productDetail;
        ICommentService CommentService;
        public ProductDetailController(IProductDetail detail,ICommentService comment)
        {
            productDetail = detail;
            CommentService = comment;
        }
        
        [Route("Product/{Productid}")]
        
        public IActionResult GetProductDetail(int Productid)
        {
            ProductDetailViewModel product = productDetail.GetProductDetail(Productid);
            if (product == null)

                return NotFound();




            return View(product);


        }
       
        [HttpPost]
        public IActionResult GetComment(int Productid)
        {
            Tuple<List<CommentViewModel>, int> Comment = CommentService.GetComment(Productid, 3);
            ViewBag.CommentCount = Comment.Item2;
            ViewBag.Productid = Productid;
            ViewBag.CommentPageNumber = 1;
            ViewBag.CommentSort = 1;
            return View(Comment);
        }

        public IActionResult CommentList(int Productid,int Pagenumber,int Sort,int Take,int CommentCount)
        {
            ViewBag.CommentCount = CommentCount;
            ViewBag.Productid = Productid;
            ViewBag.CommentPageNumber = Pagenumber;
            ViewBag.CommentSort = Sort;
            return View(CommentService.GetCommentByFilter(Productid,Pagenumber, Sort, 3));
        }
      

       
    }
}
