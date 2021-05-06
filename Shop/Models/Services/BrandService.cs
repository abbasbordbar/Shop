using Shop.Data;
using Shop.Models.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class BrandService: IBrandService
    {
        DBShop dB;
        public BrandService(DBShop dBShop)
        {
            dB = dBShop;

        }

        public List<BrandForAddProductViewModel> GetBrandsForAddProduct()
        {
            return dB.Brands.Select(b => new BrandForAddProductViewModel
            {
                Id = b.BrandId,
                Title = b.BrandName
            }).ToList();

        }

        public List<BrandAdminViewModel> GetBrandListForAdmin()
        {
            return dB.Brands.Select(b=>new BrandAdminViewModel
            {
                BrandId=b.BrandId,
                Title=b.BrandName
            }).ToList();

        }
    }
}
