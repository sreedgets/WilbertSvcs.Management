using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WilbertSvcs.Management.Models;

namespace WilbertSvcs.Management.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<WilbertAppUser> userManager;
        private IPasswordHasher<WilbertAppUser> passwordHasher;

        public AdminController(UserManager<WilbertAppUser> usrMgr, IPasswordHasher<WilbertAppUser> pwHash)
        {
            userManager = usrMgr;
            passwordHasher = pwHash;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}