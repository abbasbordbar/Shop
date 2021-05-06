using Microsoft.AspNetCore.Mvc;
using Shop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewComponents
{
    public class ProductPropertyComp:ViewComponent
    {
        IProductDetail ProductDetail;
        public ProductPropertyComp(IProductDetail detail)
        {
            ProductDetail = detail;

        }
        public async Task<IViewComponentResult> InvokeAsync(int Productid)
        {
            return await Task.FromResult(View("ProductPropertyComp", ProductDetail.GetProperty(Productid)));
        }
    }
}
