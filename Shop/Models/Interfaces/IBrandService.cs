using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{
   public interface IBrandService
    {
        List<BrandForAddProductViewModel> GetBrandsForAddProduct();
        List<BrandAdminViewModel> GetBrandListForAdmin();
    }
}
