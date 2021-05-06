using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class ProductService:IProductService
    {
        DBShop dB;
        public ProductService(DBShop dBShop)
        {
            dB = dBShop;  
        }

        public List<ProductViewModel> GetProduct(int CategoryId)
        {
            List<ProductViewModel> products = (from p in dB.Products
                                               join c in dB.categories on p.CategoryId equals c.CategoryId
                                               where p.CategoryId == CategoryId
                                               select new ProductViewModel
                                               {
                                                   ProductId=p.ProductId,
                                                   ProductName = p.ProductName,
                                                   Price = p.Price,
                                                   ImgName=p.ImgName,
                                                   Text=p.Text

                                               }).ToList();
            return products;
        }

        public Tuple<int,List<ProductListViewModel>>  GetProductsForAdmin(string searchtext, int PageNumber, int Take)
        {
            int Skip = (PageNumber - 1) * Take;

            IQueryable<ProductListViewModel> query= dB.Products.Where(p=> EF.Functions.Like(p.ProductName,"%"+ searchtext +"%") || EF.Functions.Like(p.Text,"%"+ searchtext +"%")).Select(p => new ProductListViewModel
            {
                Id = p.ProductId,
                Title = p.ProductName,
                Image = p.ImgName
            });
            return Tuple.Create(query.Count(), query.Skip(Skip).Take(Take).ToList());
        }
        public int AddProduct(Product product)
        {
            dB.Add(product);
            dB.SaveChanges();
            return product.ProductId;

        }
    }
}
