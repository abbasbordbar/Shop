using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{
  public  interface IProductDetail
    {
        ProductDetailViewModel GetProductDetail(int Productid);
       List< ProductPropertyViewModel> GetProperty(int Productid);

        

    }
}
