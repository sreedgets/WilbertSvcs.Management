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
    public class FuneralHomesController : Controller
    {
        private readonly wilbertdbContext _context;

        public FuneralHomesController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: FuneralHomes
        public async Task<IActionResult> Index()
        {

            var fhl = await _context.FuneralHomes.ToListAsync();

            foreach (var item in fhl)
            {
                var pfh = new ParentFuneralHome();
                pfh = await _context.ParentFuneralHomes.FindAsync(item.ParentFuneralHomeId);

                if (item.ParentName != null)
                    item.ParentName = pfh.ParentFuneralhomeName.Trim();
            }
            return View(await _context.FuneralHomes.ToListAsync());
        }

        // GET: FuneralHomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funeralHome = await _context.FuneralHomes
                //.Include(f => f.PlantId)
                .FirstOrDefaultAsync(m => m.FuneralHomeId == id);
            if (funeralHome == null)
            {
                return NotFound();
            }

            return View(funeralHome);
        }

        // GET: FuneralHomes/Create
        public IActionResult Create()
        {
            var fh = new FuneralHome();
            fh.ParentFuneralHomes = _context.ParentFuneralHomes.ToList();
            ViewData["PlantId"] = new SelectList(_context.Plants, "PlantId", "PlantId");
            return View(fh);
        }

        // POST: FuneralHomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuneralHomeId,ParentFuneralHomeId,Name,Address,City,State,ZipCode,County,Email,Website,Phone1,Phone2,PhoneType1,PhoneType2,IsParent,ParentName")] FuneralHome funeralHome)
        {
            if (ModelState.IsValid)
            {
                if (_context.ParentFuneralHomes.Count() == 0)
                {
                    if (funeralHome.IsParent)
                    {
                        initParentList(funeralHome);
                        addParent(funeralHome);
                    }
                    else
                        initParentList(funeralHome);
                }
                else
                {
                    if (funeralHome.IsParent)
                    {
                        addParent(funeralHome);
                    }
                }

                if (funeralHome.ParentFuneralHomeId != null)
                {
                    var pfh = new ParentFuneralHome();
                    pfh = await _context.ParentFuneralHomes.FindAsync(funeralHome.ParentFuneralHomeId);
                    funeralHome.ParentName = pfh.ParentFuneralhomeName;
                }

                _context.FuneralHomes.Add(funeralHome);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            //   ViewData["PlantId"] = new SelectList(_context.Plants, "PlantId", "PlantId", funeralHome.PlantId);
            return View(funeralHome);
        }

        // GET: FuneralHomes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funeralHome = await _context.FuneralHomes.FindAsync(id);
            if (funeralHome == null)
            {
                return NotFound();
            }
            //ViewData["PlantId"] = new SelectList(_context.Plants, "PlantId", "PlantId", funeralHome.PlantId);
            return View(funeralHome);
        }

        // POST: FuneralHomes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuneralHomeId,ParentFuneralHomeId,Name,Address,City,State,ZipCode,County,Email,Website,Phone1,Phone2,PhoneType1,PhoneType2,IsParent,ParentName")] FuneralHome funeralHome)
        {
            if (id != funeralHome.FuneralHomeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funeralHome);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuneralHomeExists(funeralHome.FuneralHomeId))
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
            //ViewData["PlantId"] = new SelectList(_context.Plants, "PlantId", "PlantId", funeralHome.PlantId);
            return View(funeralHome);
        }


        // GET: FuneralHomes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funeralHome = await _context.FuneralHomes
                //.Include(f => f.PlantId)
                .FirstOrDefaultAsync(m => m.FuneralHomeId == id);
            if (funeralHome == null)
            {
                return NotFound();
            }

            return View(funeralHome);
        }

        // POST: FuneralHomes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funeralHome = await _context.FuneralHomes.FindAsync(id);
            _context.FuneralHomes.Remove(funeralHome);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuneralHomeExists(int id)
        {
            return _context.FuneralHomes.Any(e => e.FuneralHomeId == id);
        }

        private void addParent(FuneralHome fh)
        {
            ParentFuneralHome pfh = new ParentFuneralHome();
            pfh.ParentFuneralhomeName = fh.Name;
            fh.ParentFuneralHomes = new List<ParentFuneralHome>();
            fh.ParentFuneralHomes.Add(pfh);
            _context.ParentFuneralHomes.Add(pfh);
        }

        private void initParentList(FuneralHome fh)
        {
            ParentFuneralHome pfh = new ParentFuneralHome();
            pfh.ParentFuneralhomeName = "";
            fh.ParentFuneralHomes = new List<ParentFuneralHome>();
            fh.ParentFuneralHomes.Add(pfh);
            _context.ParentFuneralHomes.Add(pfh);
        }
    }
}
