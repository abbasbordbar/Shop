using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{
   public interface IBannerService
    {
        List<Banner> GetBannerForAdmin();
        bool ChangeActiveBanner(int id);
    }
}
