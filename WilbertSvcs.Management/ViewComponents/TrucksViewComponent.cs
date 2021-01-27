using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilbertVaultCompany.api.Models;

namespace WilbertSvcs.Management.ViewComponents
{
    public class TrucksViewComponent : ViewComponent
    {
        private readonly wilbertdbContext _context;

        public TrucksViewComponent(wilbertdbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            List<Truck> fhtrkl = new List<Truck>();

            fhtrkl = (from fhtList in _context.Truck
                      where fhtList.PlantId == id
                      select fhtList).ToList();

            return View(fhtrkl);
        }
    }
}
