using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class FavoriteListForProfileViewModel
    {
        public int FavoriteId { get; set; }
        public int ProductId { get; set; }
        public string ProductTitle { get; set; }
        public string ImgName { get; set; }
        public string Price { get; set; }
        public byte Star { get; set; }
    }
}
