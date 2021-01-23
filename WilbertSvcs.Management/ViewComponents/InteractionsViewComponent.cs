using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilbertVaultCompany.api.Enums;
using WilbertVaultCompany.api.Models;

namespace WilbertSvcs.Management.ViewComponents
{
    public class InteractionsViewComponent : ViewComponent
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

            foreach (var item in fhil)
            {
                item.Reason = Enum.GetName(typeof(FollowUpReason), Int32.Parse(item.Reason));
                item.Nature = Enum.GetName(typeof(InteractionNature), Int32.Parse(item.Nature));
            }


            return View(fhil);

        }
    }
}
