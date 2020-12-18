using Microsoft.AspNetCore.Mvc;
using WilbertSvcs.Management.Models;

namespace WilbertSvcs.Management.ViewComponents
{
    public class LoginViewComponent : ViewComponent
    {
        private readonly WilbertAppUser wau;
        public LoginViewComponent()
        {
            
        }

      
            
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
