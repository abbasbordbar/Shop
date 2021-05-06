using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class ProductDetailViewModel
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string ImgName { get; set; }
        public string Text { get; set; }
        public string CatName { get; set; }
        public string ImgCat { get; set; }
        public string SubName { get; set; }
        public List<ProductImgViewModel> productImgViewModels { get; set; }
        public List<RaitingViewModel> raitings  { get; set; }

    }
}
