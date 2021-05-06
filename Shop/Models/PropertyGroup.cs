using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class PropertyGroup
    {
        public int PropertyGroupId { get; set; }
        public string Title { get; set; }
        public int Priority { get; set; }
        public List<PropertyName> PropertyNames { get; set; }
    }
}
