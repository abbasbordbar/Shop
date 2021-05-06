using Shop.Data;
using Shop.Models.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class ProductDetailService : IProductDetail
    {
        DBShop dB;
        public ProductDetailService(DBShop dBShop)
        {
            dB = dBShop;
        }

       

        public ProductDetailViewModel GetProductDetail(int Productid)
        {

           ProductDetailViewModel productDetails = (from p in dB.Products
                                                    join c in dB.categories on p.CategoryId equals c.CategoryId
                                                    where p.ProductId == Productid            
                                                                 

                                                   
                                                    select new ProductDetailViewModel
                                                    {
                                                                     ProductId = p.ProductId,
                                                                     ProductName = p.ProductName,
                                                                     Price = p.Price,
                                                                     ImgName = p.ImgName,
                                                                     CatName = c.CatName,
                                                                     ImgCat = c.ImgCat,
                                                                     Text = p.Text,
                                                                     CategoryId=c.CategoryId
                                                                    
                                                                     


                                                    }).SingleOrDefault();


            if (productDetails != null)
            {
                List<ProductImgViewModel> products = (from i in dB.productImgs
                                                      join pro in dB.Products on i.ProductId equals pro.ProductId
                                                      where i.ProductId == Productid
                                                      select new ProductImgViewModel
                                                      {
                                                          ProductImgName = i.ProdoctImgName

                                                      }).ToList();
                productDetails.productImgViewModels = products;

                List<RaitingViewModel> raitings = (from praiting in dB.ProductRatings
                                                   join Attribut in dB.ProductAttributes
                                                   on praiting.ProductAttributeId equals Attribut.ProductAttributeId
                                                   where praiting.ProductId == Productid
                                                   select new RaitingViewModel
                                                   {

                                                       Attribute = Attribut.Attribute,
                                                       Value = praiting.Value

                                                   }).ToList();
                productDetails.raitings = raitings;
            }

            return productDetails ;
        }

        public List< ProductPropertyViewModel> GetProperty(int Productid)
        {
            List<ProductPropertyViewModel> Properties = (from p in dB.ProductProperties
                                                                join v in dB.PropertyValues
                                                                on p.PropertyValueId equals v.PropertyValueId
                                                                join n in dB.PropertyNames
                                                                on v.PropertyNameId equals n.PropertyNameId
                                                                join g in dB.PropertyGroups
                                                                on n.PropertyGroupId equals g.PropertyGroupId
                                                                where p.ProductId == Productid
                                                                select new ProductPropertyViewModel
                                                                {
                                                                    PropertyName=n.Title,
                                                                    PropertyValue=v.Value,
                                                                    GroupName=g.Title

                                                                }).ToList();
            return Properties;
        }
    }
}
