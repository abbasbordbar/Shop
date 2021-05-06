using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class UserAddress
    {
        [Key]
        public int UserAddressId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string PostCode { get; set; }
        public int ProvincId { get; set; }
        public int CityId { get; set; }
        public string PostalAddress { get; set; }
        public string PostalCode { get; set; }


        public User User { get; set; }
        public Provinc Provinc { get; set; }
        public City City { get; set; }
    }
}
