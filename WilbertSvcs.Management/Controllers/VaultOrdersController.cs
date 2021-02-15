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
    public class VaultOrdersController : Controller
    {
        private readonly wilbertdbContext _context;

        public VaultOrdersController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: VaultOrders
        public async Task<IActionResult> Index()
        {
            return View(await _context.VaultOrder.ToListAsync());
        }

        // GET: VaultOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaultOrder = await _context.VaultOrder
                .FirstOrDefaultAsync(m => m.VaultOrderId == id);
            if (vaultOrder == null)
            {
                return NotFound();
            }

            return View(vaultOrder);
        }

        // GET: VaultOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VaultOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VaultOrderId,FuneralDate,FuneralTime,CemetaryTime,Location,OrderingPlant,DeliveringPlant,FuneralHome,NewFuneralHome,FuneralDirector,NewFuneralDirector,CemetaryId,Status,Category,VaultId,VenetianCarapace,TentWith6Chairs,ExtraChairs,RegisterStand,MilitarySetup,AwningOverCasket,Fdrequest,Notes,PlantId,DeceasedId")] VaultOrder vaultOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vaultOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaultOrder);
        }

        // GET: VaultOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaultOrder = await _context.VaultOrder.FindAsync(id);
            if (vaultOrder == null)
            {
                return NotFound();
            }
            return View(vaultOrder);
        }

        // POST: VaultOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VaultOrderId,FuneralDate,FuneralTime,CemetaryTime,Location,OrderingPlant,DeliveringPlant,FuneralHome,NewFuneralHome,FuneralDirector,NewFuneralDirector,CemetaryId,Status,Category,VaultId,VenetianCarapace,TentWith6Chairs,ExtraChairs,RegisterStand,MilitarySetup,AwningOverCasket,Fdrequest,Notes,PlantId,DeceasedId")] VaultOrder vaultOrder)
        {
            if (id != vaultOrder.VaultOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vaultOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VaultOrderExists(vaultOrder.VaultOrderId))
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
            return View(vaultOrder);
        }

        // GET: VaultOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaultOrder = await _context.VaultOrder
                .FirstOrDefaultAsync(m => m.VaultOrderId == id);
            if (vaultOrder == null)
            {
                return NotFound();
            }

            return View(vaultOrder);
        }

        // POST: VaultOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vaultOrder = await _context.VaultOrder.FindAsync(id);
            _context.VaultOrder.Remove(vaultOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VaultOrderExists(int id)
        {
            return _context.VaultOrder.Any(e => e.VaultOrderId == id);
        }
    }
}
