using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{
   public interface IProductService
    {
        List<ProductViewModel> GetProduct(int CategoryId);
        Tuple<int, List<ProductListViewModel>> GetProductsForAdmin(string searchtext,int PageNumber,int Take);
        int AddProduct(Product product);
    }
}
