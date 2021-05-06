using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.ExtensionMethods;
using Shop.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FileManagerController : Controller
    {
       public IActionResult ImageUpload(IFormFile upload)
        {
            string imgname = "";
            if(upload != null)
            {
                if (ImageSecurity.ImageValidator(upload))
                {
                    imgname = upload.SaveImage("", "wwwroot/Layout/img/Test");
                }
            }
            return Json(new { uploaded = true, Url = "/Layout/img/Test/" + imgname });
        }

        #region CkEDITOR
        public IActionResult CkEditorFileMavager()
        {
            return View();
        }

        public IActionResult CkEditorImageViewer(string directory)
        {
            ViewBag.directory = directory;
            return View();
        }
        [HttpPost]
        public IActionResult DeleteImage(string directory,string name)
        {
            name.DeleteImage("wwwroot/Layout/img/" + directory);
            ViewBag.directory = directory;
            return View("CkEditorImageViewer");
        }

        [HttpPost]
        public IActionResult CkEditorCreateFolder(string directory , string FolderName)
        {
            ("/wwwroot/Layout/img"+directory+"/"+FolderName).CreateDirectory();
            ViewBag.directory = directory;
            return View("CkEditorImageViewer");
        }
        
        [HttpPost]
        public IActionResult CkEditorDeleteFolder(string directory, string foldername)
        {
            ("/wwwroot/Layout/img" + directory + "/" + foldername).DeleteDirectory();
            ViewBag.directory = directory;
            return View("CkEditorImageViewer");
        }

        public IActionResult CkEditorImageUpload(string directory, IFormFile upload)
        {
            
            if (upload != null)
            {
                if (ImageSecurity.ImageValidator(upload))
                {
                     upload.SaveImage("", "wwwroot/Layout/img"+directory);
                }
            }
            ViewBag.directory = directory;
            return View("CkEditorImageViewer");
        }
        #endregion


        #region MainFileManager
        
        public IActionResult MainFileManager(string directory="")
        {
            ViewBag.directory = directory;
            return View();
        }

        public IActionResult MainImageViewer(string directory="")
        {
            ViewBag.directory = directory;
            return View();
        }
        [HttpPost]
        public IActionResult MainDeleteImage(string directory, string name)
        {
            name.DeleteImage("wwwroot/Layout/img/" + directory);
            ViewBag.directory = directory;
            return View("MainImageViewer");
        }

        [HttpPost]
        public IActionResult MainCreateFolder(string directory, string FolderName)
        {
            ("/wwwroot/Layout/img" + directory + "/" + FolderName).CreateDirectory();
            ViewBag.directory = directory;
            return View("MainImageViewer");
        }

        [HttpPost]
        public IActionResult MainDeleteFolder(string directory, string foldername)
        {
            ("/wwwroot/Layout/img" + directory + "/" + foldername).DeleteDirectory();
            ViewBag.directory = directory;
            return View("MainImageViewer");
        }

        public IActionResult MainImageUpload(string directory, IFormFile upload)
        {

            if (upload != null)
            {
                if (ImageSecurity.ImageValidator(upload))
                {
                    upload.SaveImage("", "wwwroot/Layout/img" + directory);
                }
            }
            ViewBag.directory = directory;
            return View("MainImageViewer");
        }
        #endregion





        
    }
}
