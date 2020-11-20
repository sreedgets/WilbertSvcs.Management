using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Controller;
using WilbertSvcs.Management.Models;

namespace WilbertSvcs.Management.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private UserManager<WilbertAppUser> userManager;
        private SignInManager<WilbertAppUser> signInManager;

        public AccountController(UserManager<WilbertAppUser> userMgr, SignInManager<WilbertAppUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            Login login = new Login();
            login.ReturnUrl = returnUrl;
            return View(login);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login login)
        {
            login.ReturnUrl = "dashboard";

            if (ModelState.IsValid)
            {
                WilbertAppUser WilbertAppUser = await userManager.FindByEmailAsync(login.Email);
                if (WilbertAppUser != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(WilbertAppUser, login.Password, false, false);
                    if (result.Succeeded)  // Pass to main dashboard
                    {
                        login.wilbertAppUser = WilbertAppUser;
                        login.userManager = userManager;
                        //return View(login.ReturnUrl, login);

                        return RedirectToAction("index", "home");
                    }
                }
                ModelState.AddModelError(nameof(login.Email), "Login Failed: Invalid Email or password");
            }
            return View(login);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}