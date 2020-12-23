using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WilbertSvcs.Management.Models;

namespace WilbertSvcs.Management.Controllers
{
    public class HomeController : Controller
    {
        private UserManager<WilbertAppUser> userManager;
        private SignInManager<WilbertAppUser> signInManager;

        private WilbertAppUser waUser;
        private Dashboarddata dd;

        public HomeController(UserManager<WilbertAppUser> userMgr, SignInManager<WilbertAppUser> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
            waUser = new WilbertAppUser();
            dd = new Dashboarddata();
        }

        public async Task<IActionResult> IndexAsync()
        {
            await signInManager.SignOutAsync();
            return View();
        }
    
        [Authorize]
        public async Task<IActionResult> Dashboard()
        {   
            dd.wilbertAppUser = waUser;
            dd.wilbertAppUser = await userManager.FindByNameAsync(User.Identity.Name.ToString());
            dd.userManager = userManager;
            dd.activePage = "Dashboard";
            
            return View(dd);
        }
        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            Login login = new Login();
            login.ReturnUrl = returnUrl;
            return View(login);
        }

        //TODO: Add Forgot password functionality
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login login, string returnUrl)
        {
            login.ReturnUrl = returnUrl;

            if (ModelState.IsValid)
            {
                waUser = await userManager.FindByEmailAsync(login.Email);
                if (waUser != null)
                {
                    await signInManager.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(waUser, login.Password, false, false);
                    if (result.Succeeded)  // Pass to main dashboard
                    {
                        TempData["Email"] = login.Email;
                        return RedirectToAction(login.ReturnUrl ?? "Dashboard");
                    }
                }
                ModelState.AddModelError(nameof(login.Email), "Login Failed: Invalid Email or password");
            }   
            return View(login);
        }

        [HttpPost]
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
