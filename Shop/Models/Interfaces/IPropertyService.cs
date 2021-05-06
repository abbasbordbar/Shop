using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{
   public interface IPropertyService
    {
        List<PropertyGroup> GetPropertyGroup(int pagenumber);
        int GetPropertyGroupCount();
        List<PropertyGroup> GetPropertyGroupForAddNames();
        bool AddPropertyName(PropertyName name);
        List<PropertyName> GetPropertyNames();
        PropertyName GetPropertyNameForEdit(int id);
        bool EditPropertyName(PropertyName name);
        List<PropertyValue> GetpropertyValues();
        bool AddPropertyValue(PropertyValue values);
    }
}
