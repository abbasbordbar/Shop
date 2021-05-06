using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shop.Models;
using Shop.Models.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Areas.Users.Controllers
{
    [Area("Users")]
    //[Authorize]
    public class ProfileController : Controller
    {
        IAddressService addressService;
        IFavoriteService favoriteService;
        public ProfileController(IAddressService address,IFavoriteService favorite)
        {
            addressService = address;
            favoriteService = favorite;
        }
        public IActionResult Index()
        {
            return View();
        }
       
        #region Address
        public IActionResult Addresses()
        {
            return View();
        }
         public IActionResult AddressContent()
        {
            ViewBag.ProvinceList = addressService.GetProvinc();
            //var userid = User.FindFirst("userid").Value;
            AddressListViewModel model = new AddressListViewModel
            {
                
                //AddressList = addressService.GetUserAddresses(int.Parse(userid))
                AddressList = addressService.GetUserAddresses(27)
            };
            return View(model);
        }

        public IActionResult GetCity(int id)
        {
            return Json(addressService.GetCityByProvincId(id));
        }
        [HttpPost]
        public IActionResult CreateAddress(AddressListViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserAddress address = new UserAddress
                {
                    CityId = model.Address.CityId,
                    ProvincId = model.Address.ProvincId,
                    FullName = model.Address.FullName,
                    PostCode = model.Address.PostCode,
                    PostalAddress = model.Address.PostalAddress,
                    Phone = model.Address.Phone,
                    UserId=27
                };
                if (addressService.AddAddress(address))
                    return Json(true);
            }
            return Json(false);
        } 
        
        [HttpPost]
        public IActionResult EditAddress(AddressListViewModel model)
        {
            if (ModelState.IsValid)
            {
                //var userid = User.FindFirst("userid").Value;
                var address = addressService.GetUserAddressForEdit(27, model.Address.UserAddressId);


                address.CityId = model.Address.CityId;
                address.ProvincId = model.Address.ProvincId;
                address.FullName = model.Address.FullName;
                address.PostCode = model.Address.PostCode;
                address.PostalAddress = model.Address.PostalAddress;
                address.Phone = model.Address.Phone;
                address.UserId = 27;
               
                if (addressService.EditUserAddress(address))
                    return Json(true);
            }
            return Json(false);
        }
        #endregion

        #region Favorite
        public IActionResult FavoriteList()
        {
            //var userid = int.Parse(User.FindFirst("userid").Value);
            return View(favoriteService.GetUserProductFavorites(27));
        }

        public IActionResult FavoriteListContent()
        {
            //var userid = int.Parse(User.FindFirst("userid").Value);
            return View(favoriteService.GetUserProductFavorites(27));
        }
        #endregion
    }
}
