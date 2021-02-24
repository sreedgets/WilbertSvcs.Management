using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WilbertSvcs.Management.PageControls;
using WilbertVaultCompany.api.Enums;
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
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber, string CtrySearch)
        {
            int pageSize = 25;

            ViewData["GetCemeterySearched"] = CtrySearch;
            ViewData["CurrentSort"] = sortOrder;

            var cemeteryQuery = from x in _context.Cemetary select x;
            if (!String.IsNullOrEmpty(CtrySearch))
            {
                if (searchString != null)
                {
                    pageNumber = 1;
                }
                else
                {
                    searchString = currentFilter;
                }

                cemeteryQuery = cemeteryQuery.Where(n => n.Name.Contains(CtrySearch));
                return View(await PaginatedList<Cemetary>.CreateAsync(cemeteryQuery, pageNumber ?? 1, pageSize));
            }


            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var ctlist = await _context.Cemetary.ToListAsync();
            foreach(var item in ctlist)
                    item.State = Enum.GetName(typeof(States), Int32.Parse(item.State));
            return View(ctlist);
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

            cemetary.State = Enum.GetName(typeof(States), Int32.Parse(cemetary.State));

            cemetary.PhoneType1 = Enum.GetName(typeof(PhoneType), Int32.Parse(cemetary.PhoneType1)) == "Choose" ? "" : Enum.GetName(typeof(PhoneType), Int32.Parse(cemetary.PhoneType1));
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
        public async Task<IActionResult> Create([Bind("CemetaryId,Name,Address,City,State,ZipCode,County," +
            "Phone1,PhoneType1,PlantId,PlantName,Directions,Lattitude,Longitude,Map,UseCoordinates")] Cemetary cemetary)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cemetary);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            if (cemetary.PlantId != 0)
            {
                Plant plt = await _context.Plants.FindAsync(cemetary.PlantId);
                cemetary.PlantName = plt.PlantName;
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

            List<Plant> lstPlants = _context.Plants.ToList();
            cemetary.Plants.Add(new Plant()
            {
                PlantName = "-Select-",
                PlantId = 0
            });
            foreach (var item in lstPlants)
            {
                cemetary.Plants.Add(new Plant()
                {
                    PlantName = item.PlantName,
                    PlantId = item.PlantId
                });
            }

            return View(cemetary);
        }

        // POST: Cemetaries/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CemetaryId,Name,Address,City,State,ZipCode,County," +
            "Phone1,PhoneType1,PlantId,PlantName,Directions,Lattitude,Longitude,Map,UseCoordinates")] Cemetary cemetary)
        {
            if (id != cemetary.CemetaryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (cemetary.PlantId != 0)
                {
                    Plant plt = await _context.Plants.FindAsync(cemetary.PlantId);
                    cemetary.PlantName = plt.PlantName;
                }
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
            cemetary.State = Enum.GetName(typeof(States), Int32.Parse(cemetary.State));
            cemetary.PhoneType1 = Enum.GetName(typeof(PhoneType), Int32.Parse(cemetary.PhoneType1)) == "Choose" ? "" : Enum.GetName(typeof(PhoneType), Int32.Parse(cemetary.PhoneType1));
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
