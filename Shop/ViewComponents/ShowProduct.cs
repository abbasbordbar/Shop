using Microsoft.AspNetCore.Mvc;
using Shop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewComponents
{
    public class ShowProduct:ViewComponent
    {
        IProductService productService;
        public ShowProduct(IProductService product)
        {
            productService = product;  
        }
        public async Task<IViewComponentResult> InvokeAsync(int CategoryId )
        {
            return await Task.FromResult(View("ShowProduct", productService.GetProduct(CategoryId)));

        }
    }
}
