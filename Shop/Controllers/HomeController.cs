using Microsoft.AspNetCore.Mvc;
using Shop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        ICategoryService CategoryService;
        public HomeController(ICategoryService category)
        {
            CategoryService = category;    
        }
        [Route("main/{Catname}")]
        public IActionResult Index(string CatName)
        {
            var Cat = CategoryService.GetSubCategoryByName( CatName);
            if (Cat == null )
                return null;
            return View(Cat);
        }
        
        public IActionResult Contact()
        {
            return View();
        }
    }
}
