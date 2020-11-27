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
        public HomeController(UserManager<WilbertAppUser> userMgr)
        {
            userManager = userMgr;
        }

        [Authorize]
        public async Task<IActionResult> Index(Login login)
        {
            WilbertAppUser user = await userManager.GetUserAsync(HttpContext.User);
            login.userManager = userManager;
            login.wilbertAppUser = user;
            return View(login);
        }


    }
}