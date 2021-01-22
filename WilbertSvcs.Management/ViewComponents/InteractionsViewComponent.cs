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
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            List<Interaction> fhil = new List<Interaction>();

            fhil = (from fhiList in _context.Interactions
                    where fhiList.FuneralHomeId == id
                    select fhiList).ToList();

            
            return View(fhil);

        }
    }
}
