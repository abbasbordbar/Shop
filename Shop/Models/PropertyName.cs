using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class PropertyName
    {
        public int PropertyNameId { get; set; }
        public string Title { get; set; }
        public int  Priority { get; set; }
        public bool  UseSearch { get; set; }
        public int PropertyGroupId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public PropertyGroup PropertyGroup { get; set; }
        public List<PropertyValue> PropertyValues { get; set; }

    }
}
