using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class PropertyValue
    {
        public int PropertyValueId { get; set; }
        public string Value { get; set; }
        public int PropertyNameId { get; set; }
        public PropertyName PropertyName { get; set; }
        public List<ProductProperty> ProductProperties { get; set; }
    }
}
