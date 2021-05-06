using Shop.Data;
using Shop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class GalleryService:IGalleryService
    {
        DBShop dB;
        public GalleryService(DBShop dBShop)
        {
            dB = dBShop;

        }

        public List<ProductImg> GetProductImagesForAdmin(int id)
        {
            return dB.productImgs.Where(pi => pi.ProductId == id).ToList();
        }
        public bool AddProductImage(ProductImg productImg)
        {
            try
            {
                dB.Add(productImg);
                dB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
