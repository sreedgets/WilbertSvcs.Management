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

        [Authorize(Roles = "Superuser")]
        public async Task<IActionResult> Index()
        {
            WilbertAppUser user = await userManager.GetUserAsync(HttpContext.User);
            //string message = "Hello";
            return View();
        }


    }
}