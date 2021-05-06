using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{
    public  interface IAddressService
    {
        List<AddressViewModel> GetUserAddresses(int id);
        List<ProvincViewModel> GetProvinc();
        List<CityViewModel> GetCityByProvincId(int id);
        bool AddAddress(UserAddress userAddress);
        UserAddress GetUserAddressForEdit(int userid, int addressid);
        bool EditUserAddress(UserAddress userAddress);
    }
}
