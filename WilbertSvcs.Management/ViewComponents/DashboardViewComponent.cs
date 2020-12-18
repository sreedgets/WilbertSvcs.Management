using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilbertSvcs.Management.Models;

namespace WilbertSvcs.Management.ViewComponents
{
    public class DashboardViewComponent : ViewComponent
    {
        private readonly WilbertAppUser wau;

        public DashboardViewComponent()
        {
           
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
