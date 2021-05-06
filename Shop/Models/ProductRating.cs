using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class ProductRating
    {
        [Key]
        public int ProductRatingId { get; set; }
        public int Value { get; set; }

        public int ProductId { get; set; }


        public Product Product { get; set; }

        public int ProductAttributeId { get; set; }

        
        public ProductAttribute ProductAttribute { get; set; }



    }
}
