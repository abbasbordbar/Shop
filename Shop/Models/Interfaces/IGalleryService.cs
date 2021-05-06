using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{
   public interface IGalleryService
    {
        List<ProductImg> GetProductImagesForAdmin(int id);
        bool AddProductImage(ProductImg productImg);
    }
}
