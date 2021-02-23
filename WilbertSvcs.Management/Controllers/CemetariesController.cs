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
    public class CemetariesController : Controller
    {
        private readonly wilbertdbContext _context;

        public CemetariesController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: Cemetaries
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cemetary.ToListAsync());
        }

        // GET: Cemetaries/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cemetary = await _context.Cemetary
                .FirstOrDefaultAsync(m => m.CemetaryId == id);
            if (cemetary == null)
            {
                return NotFound();
            }

            return View(cemetary);
        }

        // GET: Cemetaries/Create
        public IActionResult Create()
        {
            var ct = new Cemetary();

            /////////////////////////////////////////////////////////////

            List<Plant> lstPlants = _context.Plants.ToList();
            ct.Plants.Add(new Plant()
            {
                PlantName = "-Select-",
                PlantId = 0
            });
            foreach (var item in lstPlants)
            {
                ct.Plants.Add(new Plant()
                {
                    PlantName = item.PlantName,
                    PlantId = item.PlantId
                });
            }

            return View(ct);
        }

        // POST: Cemetaries/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CemetaryId,Name,Address,City,State,ZipCode,County,Directions,Lattitude,Longitude,Map,UseCoordinates")] Cemetary cemetary)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cemetary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cemetary);
        }

        // GET: Cemetaries/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cemetary = await _context.Cemetary.FindAsync(id);
            if (cemetary == null)
            {
                return NotFound();
            }
            return View(cemetary);
        }

        // POST: Cemetaries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CemetaryId,Name,Address,City,State,ZipCode,County,Directions,Lattitude,Longitude,Map,UseCoordinates")] Cemetary cemetary)
        {
            if (id != cemetary.CemetaryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cemetary);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CemetaryExists(cemetary.CemetaryId))
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
            return View(cemetary);
        }

        // GET: Cemetaries/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cemetary = await _context.Cemetary
                .FirstOrDefaultAsync(m => m.CemetaryId == id);
            if (cemetary == null)
            {
                return NotFound();
            }

            return View(cemetary);
        }

        // POST: Cemetaries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cemetary = await _context.Cemetary.FindAsync(id);
            _context.Cemetary.Remove(cemetary);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CemetaryExists(int id)
        {
            return _context.Cemetary.Any(e => e.CemetaryId == id);
        }
    }
}
