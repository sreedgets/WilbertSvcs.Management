using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilbertVaultCompany.api.Models;

namespace WilbertSvcs.Management.ViewComponents
{
    public class ContactDetailsViewComponent : ViewComponent
    {
        private readonly wilbertdbContext _context;
        public ContactDetailsViewComponent(wilbertdbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            return View();
        }
    
    }
}
