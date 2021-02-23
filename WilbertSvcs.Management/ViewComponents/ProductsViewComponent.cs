﻿using Microsoft.AspNetCore.Mvc;
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
            List<Product> lstProd = new List<Product>();


            lstProd = (from prods in _context.Product
                       where prods.ProductId == id
                       select prods).ToList();

            foreach(var item in lstProd)
                item.Color = Enum.GetName(typeof(VaultColor), Int32.Parse(item.Color));

            return View(lstProd);
        }
    }
}
