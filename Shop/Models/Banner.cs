using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Banner
    {
        [Key]
        public int BannerId { get; set; }
        [Display(Name ="عنوان")]
        public string Title { get; set; }
        [Display(Name = "وضعیت")]
        public bool IsActive { get; set; }
        public List<BannerImage> BannerImages { get; set; }
    }
}
