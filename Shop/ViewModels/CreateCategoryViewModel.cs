using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class CreateCategoryViewModel
    {
        [Display(Name = "نام دسته بندی")]
        public string Title { get; set; }
        [Display(Name = "توضیحات")]
        public string Descrption { get; set; }
        [Display(Name = "عکس")]
        public IFormFile Image { get; set; }

        public List<int> ParentList { get; set; }

    }
    public class GetCategoryForAddViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class EditCategoryViewModel
    {
        public int Id { get; set; }
        [Display(Name = "نام دسته بندی")]
        public string Title { get; set; }
        [Display(Name = "توضیحات")]
        public String Descrption { get; set; }
        public string CurrentImage { get; set; }
        [Display(Name = "عکس")]
        public IFormFile Image { get; set; }
        public List<int> ParentList { get; set; }
    }
}
