using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name ="نام عکس")]
        public string ProductName { get; set; }
        [Required]
        [Display(Name ="قیمت")]
        public int  Price { get; set; }
        public string ImgName { get; set; }
        
        [Display(Name = "توضیحات")]
        public string Text { get; set; }

        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        public int CategoryId { get; set; }
       
        public Category category { get; set; }
        public bool IsPublished { get; set; }

       
        public List<ProductImg> productImgs { get; set; }

        public List<ProductRating> ProductRatings { get; set; }
        public List<Comment> Comments { get; set; }
        public List<ProductProperty> ProductProperties { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<UserProductFavorite> UserProductFavorites { get; set; }






    }
}
