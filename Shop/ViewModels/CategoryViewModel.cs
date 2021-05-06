using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class CategoryViewModel
    {
        public string CatName { get; set; }

        public List<Category> Categories { get; set; }
    }
}
