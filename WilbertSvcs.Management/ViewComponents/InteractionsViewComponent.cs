using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilbertVaultCompany.api.Models;

namespace WilbertSvcs.Management.ViewComponents
{
    public class InteractionsViewComponent :ViewComponent
    {
        private readonly wilbertdbContext _context;
        public InteractionsViewComponent(wilbertdbContext context)
        {
            context = _context;
        }

        public IViewComponentResult Invoke(int id)
        {
            Interaction fhi = new Interaction();

            return View(fhi);
        }
    }
}
