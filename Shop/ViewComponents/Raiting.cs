using Microsoft.AspNetCore.Mvc;
using Shop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewComponents
{
    public class Raiting:ViewComponent
    {
        IProductDetail productDetail;
        public Raiting(IProductDetail product)
        {
            productDetail = product;    
        }
        public async Task<IViewComponentResult> InvokeAsync(int Productid)
        {
            return await Task.FromResult(View("Raiting", productDetail.GetProductDetail(Productid)));

        }
    }
}
