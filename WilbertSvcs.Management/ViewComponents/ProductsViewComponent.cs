using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilbertVaultCompany.api.Enums;
using WilbertVaultCompany.api.Models;

namespace WilbertSvcs.Management.ViewComponents
{
    public class ProductsViewComponent : ViewComponent
    {
        private readonly wilbertdbContext _context;

        public ProductsViewComponent(wilbertdbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            List<ProductsOnVaultOrder> lstProd = new List<ProductsOnVaultOrder>();


            lstProd = (from prods in _context.ProductsOnVaultOrder
                       where prods.VaultOrderId == id
                       select prods).ToList();

            foreach(var item in lstProd)
                item.Color = Enum.GetName(typeof(VaultColor), Int32.Parse(item.Color)) == "Choose" ? "Not Selected" : Enum.GetName(typeof(VaultColor), Int32.Parse(item.Color));
            
            return View(lstProd);
        }
    }
}
