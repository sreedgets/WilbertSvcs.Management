using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilbertVaultCompany.api.Models;

namespace WilbertSvcs.Management.ViewComponents
{
    public class ContactsViewComponent : ViewComponent
    {
        private readonly wilbertdbContext _context;

        public ContactsViewComponent(wilbertdbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            //List<FuneralHomeContact> fhcl = new List<FuneralHomeContact>();

            //return View((from fhcList in _context.FuneralHomeContacts
            //             where fhcList.FuneralHomeId == id
            //             select fhcList).ToList());

            FuneralHomeContact fhc = new FuneralHomeContact();
            
            return View(fhc);
        }
    }
}
