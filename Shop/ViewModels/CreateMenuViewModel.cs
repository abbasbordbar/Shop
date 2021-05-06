using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class CreateMenuViewModel
    {
        
        [Display(Name = "عنوان")]
        [MaxLength(50, ErrorMessage = " {0}نباید بیشتر از {1} باشد")]
        [Required]
        public string ParentMenuTitle { get; set; }
        
        [Display(Name = "لینک")]
        [MaxLength(250, ErrorMessage = " {0}نباید بیشتر از {1} باشد")]
        [Required]
        public string ParentMenuLink { get; set; }
        [Display(Name = "ترتیب")]
        public int ParentMenuSort { get; set; }
        public List<CreateSubMenuViewModel> SubMenuList { get; set; }


    }
    public class CreateSubMenuViewModel
    {

        [Display(Name = "عنوان")]
        [MaxLength(50, ErrorMessage = " {0}نباید بیشتر از {1} باشد")]
        [Required]
        public string SubMenuTitle { get; set; }

        [Display(Name = "لینک")]
        [MaxLength(250, ErrorMessage = " {0}نباید بیشتر از {1} باشد")]
        [Required]
        public string SubMenuLink { get; set; }
        [Display(Name = "ترتیب")]
        public int SubMenuSort { get; set; }
        public IFormFile Image { get; set; }
        public int Type { get; set; }
        public bool IsHidden { get; set; }

    }


    public class EditMenuViewModel
    {
        public int ParentMenuId { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(50, ErrorMessage = " {0}نباید بیشتر از {1} باشد")]
        [Required]
        public string ParentMenuTitle { get; set; }

        [Display(Name = "لینک")]
        [MaxLength(250, ErrorMessage = " {0}نباید بیشتر از {1} باشد")]
        [Required]
        public string ParentMenuLink { get; set; }
        [Display(Name = "ترتیب")]
        public int ParentMenuSort { get; set; }
        public List<EditSubMenuViewModel> SubMenuList { get; set; }


    }

    public class EditSubMenuViewModel
    {
        public int SubMenuId { get; set; }
        [Display(Name = "عنوان")]
        [MaxLength(50, ErrorMessage = " {0}نباید بیشتر از {1} باشد")]
        [Required]
        public string SubMenuTitle { get; set; }

        [Display(Name = "لینک")]
        [MaxLength(250, ErrorMessage = " {0}نباید بیشتر از {1} باشد")]
        [Required]
        public string SubMenuLink { get; set; }
        [Display(Name = "ترتیب")]
        public int SubMenuSort { get; set; }
        public IFormFile Image { get; set; }
        [Display(Name = "عکس فعلی")]
        public string CurrentImage { get; set; }
        public int Type { get; set; }
        public bool IsHidden { get; set; }

    }
}
