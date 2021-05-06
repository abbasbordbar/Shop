using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class ProductListViewModel
    {
        [Display(Name ="کد محصول")]
        public int Id { get; set; }
        [Display(Name = "عنوان")]
        public string Title { get; set; }
        [Display(Name = "عکس")]
        public string Image { get; set; }
    }

    public class AddProductViewModel
    {
        [Display(Name ="نام محصول")]
        public string ProductName { get; set; }
        [Display(Name = "عکس")]
        public IFormFile ImgName { get; set; }
        
        [Display(Name = "توضیحات")]
        public string Text { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public bool IsPublished { get; set; }

    }
}
