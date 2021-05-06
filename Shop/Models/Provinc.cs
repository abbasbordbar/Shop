using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Provinc
    {
        [Key]
        public int ProvincId { get; set; }
        public string ProvinceName { get; set; }


        public List<UserAddress> UserAddresses { get; set; }
        public List<City> Cities { get; set; }
    }
}
