using Shop.Data;
using Shop.Models.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class AddressService: IAddressService
    {
        DBShop dB;
        public AddressService(DBShop dBShop)
        {
            dB = dBShop;      
        }

        public List<CityViewModel> GetCityByProvincId(int id)
        {
            return dB.Cities.Where(c => c.ProvincId == id).Select(c => new CityViewModel
            {
                CityId = c.CityId,
                CityName = c.CityName
            }).ToList();
        }

        public List<ProvincViewModel> GetProvinc()
        {
            return dB.Provincs.Select(p => new ProvincViewModel
            {
                ProvincId = p.ProvincId,
                ProvincName = p.ProvinceName
            }).ToList();
        }

        public List<AddressViewModel> GetUserAddresses(int id)
        {
            return dB.UserAddresses.Where(a => a.UserId == id).Select(a => new AddressViewModel
            {
                UserAddressId=a.UserAddressId,
                FullName=a.FullName,
                PostCode=a.PostCode,
                PostalAddress=a.PostalAddress,
                Phone=a.Phone,
                CityId=a.CityId,
                ProvincId=a.ProvincId,
                CityName=a.City.CityName,
                ProvincName=a.Provinc.ProvinceName

            }).ToList();
        }

        public bool AddAddress(UserAddress userAddress)
        {
            try
            {
                dB.Add(userAddress);
                dB.SaveChanges();
                return true;

            }
            catch 
            {

                return false;
            }
        }

        public UserAddress GetUserAddressForEdit(int userid,int addressid)
        {
            return dB.UserAddresses.Where(ua => ua.UserId == userid && ua.UserAddressId == addressid).SingleOrDefault();
        }

        public bool EditUserAddress(UserAddress userAddress)
        {
            try
            {
                dB.Update(userAddress);
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
