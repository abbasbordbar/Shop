using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class ProductAttribute
    {
        [Key]
        public int ProductAttributeId { get; set; }
        public string Attribute { get; set; }

        public List<CategoryAttribut> CategoryAttributs { get; set; }



    }
}
