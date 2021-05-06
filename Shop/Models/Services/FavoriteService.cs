using Shop.Data;
using Shop.Models.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class FavoriteService :IFavoriteService
    {
        DBShop dB;
        public FavoriteService(DBShop dBShop)
        {
            dB = dBShop;

        }

        public List<FavoriteListForProfileViewModel>GetUserProductFavorites(int userid)
        {
            return dB.UserProductFavorites.Where(u => u.UserId == userid).Select(u => new FavoriteListForProfileViewModel
            {
                FavoriteId = u.UserProductFavoriteId,
                ProductTitle = u.Product.ProductName,
                ProductId = u.ProductId,
                ImgName = u.Product.ImgName,
                Price = u.Product.Price.ToString()
            }).ToList(); 
        }

        public bool CeckExistProductFavoriteForUser(int userid,int productid)
        {
            return dB.UserProductFavorites.Any(u => u.UserId == userid && u.ProductId == productid);
        }

        public bool RemoveUserProductFavorite(UserProductFavorite userProductFavorite)
        {
            try
            {
                dB.Remove(userProductFavorite);
                dB.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }
    }
}
