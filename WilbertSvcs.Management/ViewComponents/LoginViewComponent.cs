using Microsoft.AspNetCore.Mvc;
using WilbertSvcs.Management.Models;

namespace WilbertSvcs.Management.ViewComponents
{
    public class LoginViewComponent : ViewComponent
    {
         public LoginViewComponent()
        {
            
        }

      
            
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
