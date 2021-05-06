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
    public class ModulesController : Controller
    {
        IMainMenuService MainMenuService;
        public ModulesController(IMainMenuService mainMenu)
        {
            MainMenuService = mainMenu;

        }
       public IActionResult CreatMenu()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatMenu(CreateMenuViewModel mainMenu)
        {
            if (!ModelState.IsValid)
                return View(mainMenu);
            MainMenu ParentMenu = new MainMenu
            {
                MenuTitle = mainMenu.ParentMenuTitle,
                Link = mainMenu.ParentMenuLink,
                Sort = mainMenu.ParentMenuSort
            };
            int ParentId = MainMenuService.AddParentMenu(ParentMenu);
            if (ParentId <= 0)
                return View(mainMenu);
            if(mainMenu.SubMenuList !=null && mainMenu.SubMenuList.Count > 0)
            {
                //List<CreateSubMenuViewModel> hiddenlist = mainMenu.SubMenuList.Where(s => s.IsHidden == true).ToList();
                mainMenu.SubMenuList = mainMenu.SubMenuList.Where(s=>s.IsHidden==false).ToList();
                
                List<MainMenu> sublist = new List<MainMenu>();
                foreach (var item in mainMenu.SubMenuList)
                {
                    string imgname = "";
                    if(item.Image != null)
                    {
                        if (ImageSecurity.ImageValidator(item.Image))
                        {
                            imgname = item.Image.SaveImage("", "wwwroot/Layout/img/Menu");
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "لطفا فایل درست انتخاب کنید");
                            return View(mainMenu);
                        }
                    }
                    sublist.Add(new MainMenu
                    {
                        Link = item.SubMenuLink,
                        MenuTitle = item.SubMenuTitle,
                        Sort = item.SubMenuSort,
                        Type = (byte)item.Type,
                        ImageName=imgname,
                        ParentId=ParentId

                    }) ;

                }
                var res = MainMenuService.AddSubMenu(sublist);
                TempData["res"] = res ? "success" : "faild";
                return RedirectToAction("MenuList");
            
            }

            TempData["res"] = "success";
            return RedirectToAction("MenuList");
        }

        public IActionResult MenuList()
        {
            return View(MainMenuService.GetMenuListForAdmin());
        }

        public IActionResult DeleteMenu(int id)
        {
           MainMenu menu= MainMenuService.GetParentMenu(id);
            if (menu == null)
            {
                TempData["res"] = "faild";
                return RedirectToAction("MenuList");
            }
            bool res = MainMenuService.DeleteMenu(menu);
            TempData["res"] = res ? "success" : "faild";
            return RedirectToAction("MenuList");
        }
       //-----------------------------------------------------------EDIT-------------------------------------------------
        public IActionResult EditMenu(int id)
        {
            MainMenu menu = MainMenuService.GetParentMenu(id);
            if (menu == null)
            {
                TempData["res"] = "faild";
                return RedirectToAction("MenuList");
            }
            List<MainMenu> SubMenu = MainMenuService.GetSubMenuForEdit(id);
            List<EditSubMenuViewModel> submenuedit = new List<EditSubMenuViewModel>();
            foreach (var item in SubMenu)
            {
                submenuedit.Add(new EditSubMenuViewModel
                {
                    SubMenuTitle=item.MenuTitle,
                    SubMenuLink=item.Link,
                    SubMenuSort=item.Sort,
                    CurrentImage=item.ImageName,
                    Type=item.Type
                });
            }
            EditMenuViewModel edit = new EditMenuViewModel
            {
                ParentMenuId=menu.MenuId,
                ParentMenuTitle=menu.MenuTitle,
                ParentMenuLink=menu.Link,
                ParentMenuSort=menu.Sort,
                SubMenuList=submenuedit
            };
            return View(edit);
        }
       
        //---------------------------------------------------------------------------EDIT 2-------------------------
        [HttpPost]
        public IActionResult EditMenu(EditMenuViewModel edit)
        {
            if (!ModelState.IsValid)
                return View(edit);
            int menuid = int.Parse(TempData["ParentMenuId"].ToString());
            MainMenu Parentmenu = new MainMenu
            {
                MenuId=menuid,
                MenuTitle=edit.ParentMenuTitle,
                Link=edit.ParentMenuLink,
                Sort=edit.ParentMenuSort
            };
            if (!MainMenuService.EditParentMenu(Parentmenu))
                return View(edit);
            List<MainMenu> oldsubmenu = MainMenuService.GetSubMenuForEdit(menuid);
            for (int i = 0; i < oldsubmenu.Count; i++)
            {
                edit.SubMenuList[i].SubMenuId = oldsubmenu[i].MenuId;
                edit.SubMenuList[i].CurrentImage = oldsubmenu[i].ImageName;

            }
            List<MainMenu> NewList = new List<MainMenu>();
            #region Deletesubmenu
            List<EditSubMenuViewModel> HiddenList = edit.SubMenuList.Where(s => s.IsHidden == true).ToList();
            HiddenList = HiddenList.Where(s => s.SubMenuId > 0).ToList();
            if(HiddenList !=null && HiddenList.Count > 0)
            {
                foreach (var item in HiddenList)
                {
                    if (String.IsNullOrEmpty(item.CurrentImage)){
                        item.CurrentImage.DeleteImage("wwwroot/Layout/img/Menu");
                    }
                    NewList.Add(new MainMenu
                    {
                        MenuId = item.SubMenuId
                    });
                }
                if (!MainMenuService.DeleteSubMenu(NewList))
                    return View(edit);
            }
            #endregion
            #region AddNewSubMenu
               edit.SubMenuList = edit.SubMenuList.Where(s => s.IsHidden == false).ToList();
               List<EditSubMenuViewModel> templist = edit.SubMenuList.Where(s => s.SubMenuId <= 0).ToList();
            if(templist !=null && templist.Count > 0)
            {
                NewList.Clear();
                foreach (var item in templist)
                {
                    string imgname = "";
                    if (item.Image != null)
                    {
                        if (ImageSecurity.ImageValidator(item.Image))
                        {
                            imgname = item.Image.SaveImage("", "wwwroot/Layout/img/Menu");
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "لطفا فایل درست انتخاب کنید");
                            return View(edit);
                        }
                    }
                    NewList.Add(new MainMenu
                    {
                        Link = item.SubMenuLink,
                        MenuTitle = item.SubMenuTitle,
                        Sort = item.SubMenuSort,
                        Type = (byte)item.Type,
                        ImageName = imgname,
                        ParentId = menuid

                    });

                }
                if (!MainMenuService.AddSubMenu(NewList))
                    return View(edit);
            }
            #endregion
            #region UpdateSubMenu
             templist.Clear();
             templist = edit.SubMenuList.Where(s => s.SubMenuId > 0).ToList();
            if (templist != null && templist.Count > 0)
            {
                NewList.Clear();
                foreach (var item in templist)
                {
                    string imgname = item.CurrentImage;
                    if (item.Image != null)
                    {
                        if (ImageSecurity.ImageValidator(item.Image))
                        {
                            item.CurrentImage.DeleteImage("wwwroot/Layout/img/Menu");
                            imgname = item.Image.SaveImage("", "wwwroot/Layout/img/Menu");
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "لطفا فایل درست انتخاب کنید");
                            return View(edit);
                        }
                    }
                    NewList.Add(new MainMenu
                    {
                        MenuId=item.SubMenuId,
                        Link = item.SubMenuLink,
                        MenuTitle = item.SubMenuTitle,
                        Sort = item.SubMenuSort,
                        Type = (byte)item.Type,
                        ImageName = imgname,
                        ParentId = menuid

                    });
                }
                if (!MainMenuService.UpdatSubMenu(NewList))
                    return View(edit);
            }
            #endregion
            TempData["res"] = "success";
            return RedirectToAction("MenuList");

                
        }
    }
}
