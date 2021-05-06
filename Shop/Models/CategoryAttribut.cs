using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class CategoryAttribut
    {
        [Key]
        public int CategoryAttributId { get; set; }
        public int CategoryId { get; set; }
       
        public Category category { get; set; }

        public int ProductAttributeId { get; set; }

        public ProductAttribute ProductAttribute { get; set; }
    }
}
