using Shop.Data;
using Shop.Models.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class PropertyService: IPropertyService
    {
        DBShop dB;
        public PropertyService(DBShop dBShop)
        {
            dB = dBShop;
        }
        #region Groups

       
        public List<PropertyGroup> GetPropertyGroup(int pagenumber)
        {
            int Skip = (pagenumber - 1) * 2;
            return dB.PropertyGroups.Skip(Skip).Take(2).ToList();
        }

        public int GetPropertyGroupCount()
        {
            return dB.PropertyGroups.Count();
        }
        public List<PropertyGroup> GetPropertyGroupForAddNames()
        {
            return dB.PropertyGroups.ToList();
           
        }
        #endregion
        #region Name
        public List<PropertyName> GetPropertyNames()
        {
            return dB.PropertyNames.ToList();
        }
         public bool AddPropertyName(PropertyName name)
        {
            dB.Add(name);
            var res = dB.SaveChanges();
            if (res > 0)
                return true;
            return false;
        }

        public PropertyName GetPropertyNameForEdit(int id)
        {
            return dB.Find<PropertyName>(id); 
        }
        public bool EditPropertyName(PropertyName name)
        {
            dB.Update(name);
            var res = dB.SaveChanges();
            if (res > 0)
                return true;
            return false;

        }

       
        #endregion

        #region value
        public List<PropertyValue> GetpropertyValues()
        {
            return dB.PropertyValues.ToList();
        }
        public bool AddPropertyValue(PropertyValue values)
        {
            dB.Add(values);
            var res = dB.SaveChanges();
            if (res > 0)
                return true;
            return false;
        }
        #endregion
    }
}
