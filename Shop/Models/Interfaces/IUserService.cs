using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Interfaces
{

   public interface IUserService
    {
        int AddUser(User user);
        User GetUserById(int id);
        bool EditUser(User user);
        bool CheckExistEmail(string email);
        ActiveEmailViewModel GetUserForForgotPassword(string email);
        User LoginUser( string email);
    }
}
