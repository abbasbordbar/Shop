using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.ExtensionMethods;
using Shop.Models;
using Shop.Models.Interfaces;
using Shop.Security;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CatalogController : Controller
    {
        readonly IProductService ProductService;
        readonly ICategoryService categoryService;
        readonly IBrandService brandService;
        readonly IPropertyService propertyService;
        readonly IGalleryService GalleryService;
        public CatalogController(IProductService service, ICategoryService category, IBrandService brand,
            IPropertyService property, IGalleryService gallery)

        {
            ProductService = service;
            categoryService = category;
            brandService = brand;
            propertyService = property;
            GalleryService = gallery;
        }
        #region Product
        public IActionResult ProductListContainer()
        {
            var content = ProductService.GetProductsForAdmin("", 1, 2);
            ViewBag.Count = content.Item1;
            ViewBag.searchtext = "";
            ViewBag.PageNumber = 1;
            return View();
        }
        public IActionResult ProductList(string searchtext = "", int Pagenumber = 1) 
        {
            var content = ProductService.GetProductsForAdmin(searchtext, Pagenumber, 2);
            ViewBag.Count = content.Item1;
            ViewBag.searchtext = searchtext;
            ViewBag.PageNumber = Pagenumber;
            return View(content.Item2);
        }

        public IActionResult CreateProduct()
        {
            ViewBag.CategoryList = categoryService.GetCategoryForAdd();
            ViewBag.BrandList = brandService.GetBrandsForAddProduct();
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(AddProductViewModel product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.CategoryList = categoryService.GetCategoryForAdd();
                ViewBag.BrandList = brandService.GetBrandsForAddProduct();
                return View(product);
            }
            string imgname = "";
            if (product.ImgName != null)
            {
                if (ImageSecurity.ImageValidator(product.ImgName))
                {
                    imgname = product.ImgName.SaveImage("", "wwwroot/Layout/img/MainImg");
                }
                else
                {
                    ModelState.AddModelError("ImageName", "فایل درست انتخاب کنید");
                    ViewBag.CategoryList = categoryService.GetCategoryForAdd();
                    ViewBag.BrandList = brandService.GetBrandsForAddProduct();
                    return View(product);
                }
            }
            Product p = new Product
            {
                ProductName = product.ProductName,
                ImgName = imgname,
                CategoryId = product.CategoryId,
                BrandId = product.BrandId,
                IsPublished = product.IsPublished,
            };
            int Productid = ProductService.AddProduct(p);
            List<int> ParentList = categoryService.GetParentCategory(product.CategoryId);
            List<ProductCategory> productCategory = new List<ProductCategory>();
            foreach (var item in ParentList)
            {
                productCategory.Add(new ProductCategory
                {
                    CategoryId = item,
                    ProductId = Productid
                });

            }
            bool res = categoryService.AddProductCategories(productCategory);

            TempData["res"] = res ? "success" : "faild";
            return RedirectToAction(nameof(ProductList));
        }
        #endregion
        #region peroperty
        public IActionResult PropertyGroupList(int pagenumber = 1)
        {
            ViewBag.PageCount = propertyService.GetPropertyGroupCount();
            ViewBag.PageNumber = pagenumber;

            return View(propertyService.GetPropertyGroup(pagenumber));

        }
        public IActionResult PropertyList()
        {
            return View(propertyService.GetPropertyNames());
        }
        public IActionResult CreatePropertyName()
        {
            ViewBag.Group = propertyService.GetPropertyGroupForAddNames();
            ViewBag.Catrgory = categoryService.GetCategoryForAdd();
            return View();
        }
        [HttpPost]
        public IActionResult CreatePropertyName(PropertyName name)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Group = propertyService.GetPropertyGroupForAddNames();
                ViewBag.Catrgory = categoryService.GetCategoryForAdd();
                return View(name);
            }
            bool res = propertyService.AddPropertyName(name);
            TempData["res"] = res ? "success" : "faild";
            return RedirectToAction(nameof(PropertyList));

        }
        public IActionResult EditPropertyName(int id)
        {
            PropertyName name = propertyService.GetPropertyNameForEdit(id);
            if (name == null)
            {
                TempData["res"] = "faild";
                RedirectToAction(nameof(PropertyList));
            }
            ViewBag.Group = propertyService.GetPropertyGroupForAddNames();
            ViewBag.Catrgory = categoryService.GetCategoryForAdd();
            return View(name);
        }
        [HttpPost]
        public IActionResult EditPropertyName(PropertyName name)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Group = propertyService.GetPropertyGroupForAddNames();
                ViewBag.Catrgory = categoryService.GetCategoryForAdd();
                return View(name);
            }
            name.PropertyNameId = int.Parse(TempData["id"].ToString());
            bool res = propertyService.EditPropertyName(name);
            TempData["res"] = res ? "success" : "faild";
            return RedirectToAction(nameof(PropertyList));

        }
        #region value
        public IActionResult PropertyValueList()
        {
            return View(propertyService.GetpropertyValues());
        }
        public IActionResult CreatePropertyValue()
        {
            ViewBag.names = propertyService.GetPropertyNames();
            return View();
        }
        [HttpPost]
        public IActionResult CreatePropertyValue(PropertyValue values)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.names = propertyService.GetPropertyNames();
                return View(values);
            }
            bool res = propertyService.AddPropertyValue(values);
            TempData["res"] = res ? "success" : "faild";
            return RedirectToAction(nameof(PropertyValueList));

        }
        #endregion




        
        #endregion

        #region Gallery
        public IActionResult GalleryList(int id)
        {
            ViewBag.productid = id;
            return View(GalleryService.GetProductImagesForAdmin(id));

        }
        public IActionResult CreatProductImage(IFormFile imagename)
        {
            string imgname = "";
            int id = int.Parse(TempData["ProductImage"].ToString());
            if (imagename != null)
            {
                if (ImageSecurity.ImageValidator(imagename))
                {
                    imgname = imagename.SaveImage("", "wwwroot/Layout/img/Gallery");
                    string olldpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Layout/img/Gallery", imgname);
                    string newpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Layout/img/Prodoctsubimg", imgname);
                    olldpath.Image_resize(newpath, 150, 150);
                    ProductImg productImg = new ProductImg
                    {
                        ProdoctImgName = imgname,
                        ProductId = id
                    };
                    GalleryService.AddProductImage(productImg);
                }
                else
                {
                    return RedirectToAction(nameof(GalleryList), new { id = id });

                }
            }
            return RedirectToAction(nameof(GalleryList), new { id = id });
        }
        #endregion

        #region Brand
        public IActionResult BrandList()
        {
            return View(brandService.GetBrandListForAdmin());
        }
        #endregion
    }
}
