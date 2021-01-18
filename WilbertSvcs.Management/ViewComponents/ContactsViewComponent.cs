using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilbertVaultCompany.api.Enums;
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
            List<FuneralHomeContact> fhcl = new List<FuneralHomeContact>();

            fhcl = (from fhcList in _context.FuneralHomeContacts
                    where fhcList.FuneralHomeId == id
                    select fhcList).ToList();

            foreach(var item in fhcl)
                item.ContactRole = Enum.GetName(typeof(FuneralHomeRole), Int32.Parse(item.ContactRole));

            return View(fhcl);
            //TODO: Format details page
            
            //return View(fhcl);
        }
    }
}
