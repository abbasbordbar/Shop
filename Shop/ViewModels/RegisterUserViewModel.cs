using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class RegisterUserViewModel
    {
        [EmailAddress(ErrorMessage = "ایمیل را به درستی وارد کنید")]
        [Remote("CheckExistEmail", "Account", ErrorMessage = "ایمیل تکراری است")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public class ActiveEmailViewModel
    {
        public int UserId { get; set; }
        public string ActiveCode { get; set; }
    }

    public class ForgotPassword
    {
        [EmailAddress(ErrorMessage = "ایمیل را به درستی وارد کنید")]
        public string Email { get; set; }
    }

    public class ResetPasswordViewModel
    {
        public int UserId { get; set; }
        public string ActiveCode { get; set; }
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "تکرار کلمه عبور همخوانی ندارد")]
        public string RePassword { get; set; }
    }

    public class LoginViewModel
    {
        [Display(Name = "ایمیل")]
        public string Email { get; set; }
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        public bool IsPersistent { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Display(Name = "رمز عبور قبلی")]
        public string OldPassword { get; set; }
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }
        [Display(Name = "تکرار رمز عبور")]
        [Compare("Password", ErrorMessage = "تکرار کلمه عبور همخوانی ندارد")]
        public string RePassword { get; set; }

    }
}
