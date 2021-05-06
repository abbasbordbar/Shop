using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class ProductProperty
    {
        public int ProductPropertyId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int PropertyValueId { get; set; }
        public PropertyValue PropertyValue { get; set; }
    }
}
