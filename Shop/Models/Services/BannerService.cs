using Shop.Data;
using Shop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class BannerService : IBannerService
    {
        DBShop dB;
        public BannerService(DBShop dBShop)
        {
            dB = dBShop;

        }
        public List<Banner> GetBannerForAdmin()
        {
            return dB.Banners.ToList();
        }

        public bool ChangeActiveBanner(int id)
        {
            Banner banner = dB.Find<Banner>(id);
            banner.IsActive = banner.IsActive == true ? false : true;
            dB.Update(banner);
            var res = dB.SaveChanges();
            if (res > 0)
                return true;
            return false;

        }
    }
}
