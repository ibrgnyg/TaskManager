using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _sigInManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> sigInManager)
        {
            _userManager = userManager;
            _sigInManager = sigInManager;

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register register)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser()
                {
                    UserName = register.Email,
                    Email = register.Email,
                };
               
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
             
                   ViewBag.Succes = "Üye Olma işlemi başarılı ";

                }

                else
                {
                    string mes = $"{register.Email} Böyle bir Kullanıcı mevcut ";
                    ViewBag.Error = mes;
                }

            }
            return View();


           
        }



        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(login.Email);

                if (user != null)
                {
                    var lgn = await _sigInManager.PasswordSignInAsync(user, login.Password, false, true);

                    if (lgn.Succeeded)
                    {
                        return RedirectToAction("Index", "mission");
                    }

                    else
                    {

                        string mes = "E-posta Veya Şifre Hatalı!";
                        ViewBag.ErrorPassword = mes;

                    }

                }
                else
                {

                    string noUser = $"{login.Email} Böyle Bir Kullanıcı Bulunmamaktadır!";
                    ViewBag.NoUser = noUser;

                }


            }
            return View(login);

            
        }

        public async Task<IActionResult> LogOut()
        {
            await _sigInManager.SignOutAsync();
            return RedirectToAction("Login","Account");
        }

        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.GetUserAsync(User);
            return View(user);
        }
    }
}