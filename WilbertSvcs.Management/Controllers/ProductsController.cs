using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WilbertVaultCompany.api.Models;

namespace WilbertSvcs.Management.Controllers
{
    public class ProductsController : Controller
    {
        private readonly wilbertdbContext _context;

        public ProductsController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: Products
        public async Task<IActionResult> Index()
        {
            return View(await _context.Product.ToListAsync());
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Details/5
        public async Task<IActionResult> AddToVaultOrder(int? id, int? VaultOrderId)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }
          //  product.VaultOrderId = (int?)TempData["VOid"];
            return View(product);
        }

        // POST: Products/AddToVaultOrder/int VaultOrderId
        [HttpPost]
        public async Task<IActionResult> AddToVaultOrder(int Id, [Bind("ProductId,Description,Ovation,Decoration,Legacy,Size,Price,ProductCode," +
            "AllowedToSelectId,UpChargeForLegacy,UpChargeAmount,ProductCategory," +
            "Color,Color1,Color2,Comments,PhotoImage,VaultOrderId")] Product product)
        {
            if (Id != 0)
            {
                // Find VaultOrder in VaultOrder table
                var VO = await _context.VaultOrder.FindAsync(Id);
                if (VO != null)
                {
                    var POVO = new ProductsOnVaultOrder();
                    POVO.VaultOrderId = VO.VaultOrderId;
                    POVO.ProductCode = product.ProductCode;
                    POVO.ProductCategory = product.ProductCategory;
                    POVO.VenetianCarapace = product.VenetianCarapace;
                    POVO.Description = product.Description;
                    POVO.Size = product.Size;
                    POVO.Price = product.Price;
                    POVO.AllowedToSelectId = product.AllowedToSelectId;
                    POVO.UpChargeForLegacy = product.UpChargeForLegacy;
                    POVO.UpChargeAmount = product.UpChargeAmount;
                    POVO.Legacy = product.Legacy;
                    POVO.Decoration = product.Decoration;
                    POVO.Ovation = product.Ovation;
                    POVO.Color = product.Color;
                    POVO.Color1 = product.Color1;
                    POVO.Color2 = product.Color2;
                    POVO.PhotoImage = product.PhotoImage;

                    try
                    {
                        _context.ProductsOnVaultOrder.Add(POVO);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ProductExists(product.ProductId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }

                }
                return RedirectToAction(nameof(Details),"VaultOrders", new { id = Id });
            
            }
            return View();
        }
        /********************************************************/
        // GET: Products/Create
        [HttpGet]
        public async Task<IActionResult> ShopVault(int Id)
        {
            List<Product> prods = await _context.Product.ToListAsync();

            TempData["VOid"] = Id;
            return View(prods);
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,Description,Ovation,Decoration,Legacy,Size,Price,ProductCode,AllowedToSelectId,UpChargeForLegacy,UpChargeAmount,ProductCategory,Color,Color1,Color2,Comments,PhotoImage")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        /**************************************************************/

        // GET: Products/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost("Create/{Id}")]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int Id, [Bind("ProductId,Description,Ovation,Decoration,Legacy,Size,Price,ProductCode,AllowedToSelectId,UpChargeForLegacy,UpChargeAmount,ProductCategory,Color,Color1,Color2,Comments,PhotoImage")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Description,Ovation,Decoration,Legacy,Size,Price,ProductCode,AllowedToSelectId,UpChargeForLegacy,UpChargeAmount,ProductCategory,Color,Color1,Color2,Comments,PhotoImage")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Product
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Product.FindAsync(id);
            _context.Product.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.ProductId == id);
        }
        private bool POVOExists(int id)
        {
            return _context.ProductsOnVaultOrder.Any(e => e.ProductsOnVaultOrderId == id);
        }
    }
}
