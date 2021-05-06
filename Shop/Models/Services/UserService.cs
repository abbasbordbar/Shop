using Shop.Data;
using Shop.Models.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models.Services
{
    public class UserService : IUserService
    {
        DBShop dB;
        public UserService(DBShop dBShop)
        {
            dB = dBShop;

        }
        public int AddUser(User user)
        {
            try
            {
                dB.Add(user);
                dB.SaveChanges();
                return user.UserId;

            }
            catch 
            {

                return 0;
            }
        }

        public User GetUserById(int id)
        {
            return dB.users.Find(id);
        }

        public bool EditUser(User user)
        {
            try
            {
                dB.Update(user);
                dB.SaveChanges();
                return true;
            }
            catch 
            {

                return false;
            }
        }

        public bool CheckExistEmail(string email)
        {
            return dB.users.Any(e => e.Email == email);//اگر وجود داشت یا ایا وجود دارد این ایمیل در جدول یا نه


        }

        public ActiveEmailViewModel GetUserForForgotPassword(string email)
        {
            return dB.users.Where(u => u.Email == email).Select(u => new ActiveEmailViewModel { 
            UserId=u.UserId,
            ActiveCode=u.EmailActiveCode
            }).SingleOrDefault();

        }

        public User LoginUser(string email)
        {
            return dB.users.Where(u => u.Email == email ).SingleOrDefault();

        }
    }
}
