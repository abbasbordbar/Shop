using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class BannerImage
    {
        [Key]
        public int BannerImageId { get; set; }
        [Display(Name ="عنوان")]
        public string Title { get; set; }
        public string ImageName { get; set; }
        [Display(Name = "لینک")]
        public string Link { get; set; }
        public byte Discount { get; set; }
        public int? Sort { get; set; }
        public int BannerId { get; set; }
        public Banner Banner { get; set; }
    }
}
