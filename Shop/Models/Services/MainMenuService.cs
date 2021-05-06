using Microsoft.EntityFrameworkCore;
using Shop.Data;
using Shop.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class MainMenuService: IMainMenuService
    {
        DBShop dB;
        public MainMenuService(DBShop dBShop)
        {
            dB = dBShop;

        }
        public int AddParentMenu(MainMenu mainMenu)
        {
            dB.MainMenus.Add(mainMenu);
            dB.SaveChanges();
            return mainMenu.MenuId;

        }

        public bool AddSubMenu(List<MainMenu> submenu)
        {
            dB.AddRange(submenu);
            int res = dB.SaveChanges();
            if (res > 0)
                return true;
            return false;
        }

        public bool DeleteMenu(MainMenu menu)
        {
            bool res = true;
           List<MainMenu> sublist= dB.MainMenus.Where(s => s.ParentId == menu.MenuId).ToList();
            if(sublist !=null && sublist.Count > 0)
            {
                res = DeleteSubMenu(sublist);

            }
             
            if (res)
            {
                dB.Remove(menu);
                int result = dB.SaveChanges();
                if (result > 0)
                    return true;
                return false;

            }
            return false;
        }

        public bool DeleteSubMenu(List<MainMenu> submenu)
        {
            dB.RemoveRange(submenu);
            int res = dB.SaveChanges();
            if (res > 0)
                return true;
            return false;
        }
        public MainMenu GetParentMenu(int id)
        {
            return dB.MainMenus.Where(s => s.ParentId == null && s.MenuId == id).SingleOrDefault();
        }

        public List<MainMenu> GetMenuListForAdmin()
        {
            return dB.MainMenus.Where(s => s.ParentId == null).ToList();
        }

        public List<MainMenu> GetSubMenuForEdit(int id)
        {
            return dB.MainMenus.AsNoTracking().Where(s => s.ParentId == id).ToList();

        }

        public bool EditParentMenu(MainMenu menu)
        {
            dB.Update(menu);
            int res = dB.SaveChanges();
            if (res > 0)
                return true;
            return false;
        }
        public bool UpdatSubMenu(List<MainMenu> menulist)
        {
            dB.UpdateRange(menulist);
            int res = dB.SaveChanges();
            if (res > 0)
                return true;
            return false;


        }
    }
}
