using Microsoft.AspNetCore.Mvc;
using Shop.ExtensionMethods;
using Shop.Models;
using Shop.Models.Interfaces;
using Shop.Security;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        
        ICategoryService categoryService;
        public CategoryController(ICategoryService category)
        {
            categoryService = category;

        }
        public IActionResult CategoryList()
        {
            return View(categoryService.CategoryForAdmin());
        }
        public IActionResult DeleteCategory(int id)
        {
            Category category = categoryService.FindCategoryById(id);
            if (category == null)
            {
                TempData["res"] = "faild";
                return RedirectToAction(nameof(CategoryList));
            }
            category.IsDelete = true;
            bool res = categoryService.DeleteCategory(category);
            TempData["res"] = res ? "success" : "faild";
            return RedirectToAction(nameof(CategoryList));

        }
        public IActionResult CreateCategory()
        {
            ViewBag.CategoryList = categoryService.GetCategoryForAdd();
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryViewModel category)
        {
            if (!ModelState.IsValid) 
            {
                ViewBag.CategoryList = categoryService.GetCategoryForAdd();
                return View(category);
            }
            if (categoryService.IsExsitCategoryTitle(0, category.Title))
            {
                ModelState.AddModelError("Title", "این نام تکراری است");
                ViewBag.CategoryList = categoryService.GetCategoryForAdd();
                return View(category);
            }
            string imgname = "";
            if(category.Image != null)
            {
                if (ImageSecurity.ImageValidator(category.Image))
                {
                    imgname = category.Image.SaveImage("", "wwwroot/Layout/img/CategoryImg");
                }
                else
                {
                    ModelState.AddModelError("Image", "فایل را درست وارد کنید");
                    return View(category);
                }
            }
            Category Cat = new Category
            {
                Descrption = category.Descrption,
                CatName = category.Title,
                ImgCat = imgname

            };
            bool res = categoryService.AddCategory(Cat, category.ParentList);
            TempData["res"]=res ? "success" : "faild";


            return RedirectToAction(nameof(CategoryList));
        }
       
        public IActionResult EditCategory(int id)
        {
            
            Category category = categoryService.FindCategoryById(id);
            if (category == null)
            {
                TempData["res"] = "faild";
                return RedirectToAction(nameof(CategoryList));
            }
            EditCategoryViewModel Cat = new EditCategoryViewModel
            {
                Id = category.CategoryId,
                Descrption = category.Descrption,
                Title = category.CatName,
                CurrentImage = category.ImgCat
            };
            
            ViewBag.ParentList = categoryService.GetSubCategory(id);//حاوی پرنت هایی است که قبلا داشته

            ViewBag.CategoryList = categoryService.GetCategoryForAdd();//جدول کتگوری است برای نمایش دادن در سلکت برای انتخاب کتگوری توسط کاربرid ,titleحاوی فیلد های   
            
            
            return View(Cat);
            
        }
       
        [HttpPost]
        public IActionResult EditCategory(EditCategoryViewModel category)
        {
            if (!ModelState.IsValid)
            {
                category.CurrentImage = TempData["currentimg"].ToString();
                ViewBag.ParentList = category.ParentList;
                ViewBag.CategoryList = categoryService.GetCategoryForAdd();
                return View(category);
            }
            if (categoryService.IsExsitCategoryTitle(int.Parse(TempData["id"].ToString()), category.Title))
            {
                ModelState.AddModelError("Title", "این نام تکراری است");
                category.CurrentImage = TempData["currentimg"].ToString();
                ViewBag.ParentList = category.ParentList;
                ViewBag.CategoryList = categoryService.GetCategoryForAdd();
                return View(category);
            }
            string imgname = TempData["currentimg"]!= null ? TempData["currentimg"].ToString():"";
            if(category.Image != null)
            {
                if (ImageSecurity.ImageValidator(category.Image))
                {
                    imgname.DeleteImage("wwwroot/Layout/img/Imgcat");
                    imgname = category.Image.SaveImage(imgname, "wwwroot/Layout/img/Imgcat");
                }
                else
                {
                    ModelState.AddModelError("Image", "فایل را درست وارد کنید");
                    category.CurrentImage = TempData["currentimg"].ToString();
                    ViewBag.ParentList = category.ParentList;
                    ViewBag.CategoryList = categoryService.GetCategoryForAdd();
                    return View(category);
                }
            }
            Category cat = new Category
            {
                CategoryId = int.Parse(TempData["id"].ToString()),
                Descrption = category.Descrption,
                CatName = category.Title,
                ImgCat=imgname
            };
            bool res = categoryService.UpdateCategory(cat, category.ParentList);
            TempData["res"] = res ? "success" : "faild";


            return RedirectToAction(nameof(CategoryList));
        }
    }
}

