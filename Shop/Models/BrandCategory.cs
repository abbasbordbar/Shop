using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class BrandCategory
    {
        [Key]
        public int BrandCategoryId { get; set; }

        public int BrandId { get; set; }
       
        public Brand Brand { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

    }
}
