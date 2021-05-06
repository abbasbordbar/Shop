using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{
   public interface IMainMenuService
    {
        int AddParentMenu(MainMenu mainMenu);
        bool AddSubMenu(List<MainMenu> submenu);
        List<MainMenu> GetMenuListForAdmin();
        bool DeleteSubMenu(List<MainMenu> submenu);
        bool DeleteMenu(MainMenu menu);
        MainMenu GetParentMenu(int id);
        List<MainMenu> GetSubMenuForEdit(int id);
        bool EditParentMenu(MainMenu menu);
        bool UpdatSubMenu(List<MainMenu> menulist);
    }
}
