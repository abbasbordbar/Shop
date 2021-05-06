using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{
   public interface IFavoriteService
    {
        List<FavoriteListForProfileViewModel> GetUserProductFavorites(int userid);
        bool CeckExistProductFavoriteForUser(int userid, int productid);
        bool RemoveUserProductFavorite(UserProductFavorite userProductFavorite);
    }
}
