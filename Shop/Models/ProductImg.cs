using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class ProductImg
    {
        [Key]
        public int ProductImgId { get; set; }
        [Required]
        [Display(Name ="نام عکس")]
        public string ProdoctImgName { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
