using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name ="نام دسته بندی")]
        public string CatName { get; set; }
        
        [Display(Name = "عکس دسته بندی")]
        public string ImgCat { get; set; }
        [Required]
        [Display(Name = "توضیحات")]
        public string Descrption { get; set; }
        public bool IsDelete { get; set; }




        public List<Product> products { get; set; }
        public List<BrandCategory> BrandCategories { get; set; }
        public List<CategoryAttribut> CategoryAttributs { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }

        public List<PropertyName> PropertyNames { get; set; }




        public List<SubCategory> ParentCa { get; set; }
        public List<SubCategory> SubCa { get; set; }


    }
}
