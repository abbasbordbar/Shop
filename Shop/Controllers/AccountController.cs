using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Shop.Helpers;
using Shop.Models;
using Shop.Models.Interfaces;
using Shop.Security;
using Shop.Sender;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Identity;

namespace Shop.Controllers
{
    
    public  class AccountController : Controller
    {
        IUserService userService;
        IConfiguration _config;
        IEmailSender emailSender;
        IRenderViewToString renderViewToString;
        
        public AccountController(IUserService user, IConfiguration configuration, IEmailSender email, IRenderViewToString viewToString)
        {
            userService = user;
            _config = configuration;
            emailSender = email;
            renderViewToString = viewToString;
           
        }
      
        #region Login
        
        public IActionResult Login()
        {
            //ViewData["returnUrl"] = ReturnUrl;

            return View();
         
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            //ViewData["returnUrl"] = ReturnUrl;
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = userService.LoginUser(model.Email);
            if (user != null)
            {
                if (user.IsActive)
                {
                    string[] tempstring = user.Password.Split("-");
                    byte[] hashpassword = new byte[tempstring.Length];
                    for (int i = 0; i < tempstring.Length; i++)
                        hashpassword[i] = Convert.ToByte(tempstring[i]);
                    if (PasswordHash.VerifyHashedPasswordV2(hashpassword, model.Password))
                    {
                        var claims = new List<Claim>
                        {
                            new Claim("userid",user.UserId.ToString()),
                            new Claim("name",String.IsNullOrEmpty(user.UserName) ? user.Phone: user.UserName),
                            new Claim("avatar",user.Avatar.ToString())

                        };
                        var properties = new AuthenticationProperties()
                        {
                            IsPersistent = model.IsPersistent
                        };
                        HttpContext.SignInAsync(new ClaimsPrincipal(new ClaimsIdentity(claims, "Cookies")), properties);

                        //return IsLocalUrl(ReturnUrl);
                    }
                    else
                    {
                        ModelState.AddModelError("", "کاربری با این مشخصات پیدا نشد");
                    }


                }
                else
                {
                    ModelState.AddModelError("", "حساب کاربری شما فعال نیست");
                }

            }
            else
            {
                ModelState.AddModelError("", "کاربری با این مشخصات پیدا نشد");
            }
            return Redirect("/");

         
        }
       
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
       
        public IActionResult ChangePassword()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            var user = userService.GetUserById(int.Parse(User.FindFirst("userid").Value));
            string[] tempstring = user.Password.Split("-");
            byte[] hashpassword = new byte[tempstring.Length];
            for (int i = 0; i < tempstring.Length; i++)
                hashpassword[i] = Convert.ToByte(tempstring[i]);
            if (PasswordHash.VerifyHashedPasswordV2(hashpassword, model.OldPassword))
            {
                user.Password = string.Join("-", PasswordHash.HashPasswordV2(model.Password));
                var res = userService.EditUser(user);
                if (res)
                {
                    return RedirectToAction("Profile");
                }
                else
                {
                    ModelState.AddModelError("", "در ثبت اطلاعات مشکلی بوجود امده است");
                }
                    
            }
            else
            {
                ModelState.AddModelError("", "رمز عبور قبلی اشتباه است");
            }

            return View(model);
        }
        #endregion



        #region Register
        
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)//اگر کاربر لاگین کرده اون را به صفحه خانه ببر
            {
                return View("/");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (!await GoogleRecaptchaHelper.IsReCaptchaPassedAsync(Request.Form["g-recaptcha-response"],
        _config["GoogleReCaptcha:secret"]))
            {
                ModelState.AddModelError(string.Empty, "احراز هویت را انجام دهید");
                return View(model);
            }


            string activecode = Guid.NewGuid().ToString().Replace("-", "");
            User user = new User
            {
                Email = model.Email,
                Password = string.Join("-", PasswordHash.HashPasswordV2(model.Password)),
                EmailActiveCode = activecode

            };
            int userid = userService.AddUser(user);
            if (userid > 0)
            {
                ActiveEmailViewModel emailViewModel = new ActiveEmailViewModel
                {
                    ActiveCode = activecode,
                    UserId = userid
                };
                emailSender.SendEmail(model.Email, "ارسال ایمیل فعال سازی", renderViewToString.Render("_ActiveEmail", emailViewModel));

            }
            ModelState.AddModelError(string.Empty, "در ثبت اطلاعات مشکلی به وجود امده است");

            return View(model);
        }
        [HttpPost]
        public IActionResult ConfirmEmail(int id, string activecode)
        {
            var user = userService.GetUserById(id);
            if (user != null && user.EmailActiveCode == activecode)
            {
                user.IsActive = true;
                user.EmailActiveCode = Guid.NewGuid().ToString().Replace("-", "");

                if (userService.EditUser(user))
                {
                    return RedirectToAction("welcome");
                }
            }

            return RedirectToAction("error");
        }

        public IActionResult CheckExistEmail(string Email)
        {
            return Json(!userService.CheckExistEmail(Email));

        }
        #endregion

        #region Forgotpassword
        
        public IActionResult Forgotpassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Forgotpassword(ForgotPassword model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var user = userService.GetUserForForgotPassword(model.Email);
            if (user != null)
            {
                ActiveEmailViewModel emailViewModel = new ActiveEmailViewModel
                {
                    ActiveCode = user.ActiveCode,
                    UserId = user.UserId
                };
                emailSender.SendEmail(model.Email, "بازیابی کلمه عبور", renderViewToString.Render("_ResetPasswordEmail", emailViewModel));
                return RedirectToAction("ResetConfirm");
            }

            ModelState.AddModelError("Email", "ایمیل معتبر نیست");
            return View(model);


        }
       
        public IActionResult ResetPassword(int id, string activecode)
        {
            return View(new ResetPasswordViewModel
            {
                UserId = id,
                ActiveCode = activecode,

            });

        }
        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel model)
        {
            var user = userService.GetUserById(model.UserId);
            if (user != null && user.EmailActiveCode == model.ActiveCode)
            {
                user.Password = string.Join("-", PasswordHash.HashPasswordV2(model.Password));
                user.EmailActiveCode = Guid.NewGuid().ToString().Replace("-", "");
                if (userService.EditUser(user))
                {
                    return RedirectToAction("welcome");
                }
            }
            return RedirectToAction("error");

        }
        #endregion
        //public IActionResult IsLocalUrl(string ReturnUrl)
        //{
        //    return Redirect(Url.IsLocalUrl(ReturnUrl) ? ReturnUrl : "/");
        //}
    }
}
