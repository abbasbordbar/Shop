using Microsoft.AspNetCore.Mvc;
using Shop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        IBannerService bannerService;
        public BannerController(IBannerService banner)
        {
            bannerService = banner;

        }
       public IActionResult BannerList()
        {
            return View(bannerService.GetBannerForAdmin());
        }

        public IActionResult ChangeActive(int id)
        {
            TempData["res"] = bannerService.ChangeActiveBanner(id) ? "success" : "faild";
            return RedirectToAction("BannerList");
        }
    }
}
