using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }

        public int ProvincId { get; set; }

        public Provinc Provinc { get; set; }

        public List<UserAddress> UserAddresses { get; set; }

    }
}
