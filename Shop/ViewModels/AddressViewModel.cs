using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class AddressViewModel
    {
        public int UserAddressId { get; set; }
        
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string PostCode { get; set; }
        public string ProvincName { get; set; }
        public string CityName { get; set; }
        public int ProvincId { get; set; }
        public int CityId { get; set; }
        public string PostalAddress { get; set; }
        public string PostalCode { get; set; }

    }

    public class AddressListViewModel
    {
        public List<AddressViewModel> AddressList { get; set; }
        public AddressViewModel Address { get; set; }
    }

    public class CityViewModel
    {
        public int CityId { get; set; }
        public string  CityName { get; set; }

    }
    public class ProvincViewModel
    {
        public int ProvincId { get; set; }
        public string ProvincName { get; set; }

    }
}
