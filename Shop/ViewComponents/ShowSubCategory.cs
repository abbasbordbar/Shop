using Microsoft.AspNetCore.Mvc;
using Shop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewComponents
{
    public class ShowSubCategory:ViewComponent
    {
        ICategoryService categoryService;
        public ShowSubCategory(ICategoryService category)
        {
            categoryService = category;

        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            return await Task.FromResult(View("ShowSubCategory", categoryService.GetSubCategoryById(id)));

        }
    }
}
