using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class UserProductFavorite
    {
        public int UserProductFavoriteId { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        public User User { get; set; }
        public Product Product { get; set; }
    }
}
