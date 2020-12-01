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
        private readonly WilbertFSDatabaseContext _context;

        public FuneralHomesController(WilbertFSDatabaseContext context)
        {
            _context = context;
        }

        // GET: FuneralHomes
        public async Task<IActionResult> Index()
        {
            var wilbertFSDatabaseContext = _context.FuneralHomes.Include(f => f.Plant);
            return View(await wilbertFSDatabaseContext.ToListAsync());
        }

        // GET: FuneralHomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funeralHome = await _context.FuneralHomes
                .Include(f => f.Plant)
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
            using (_context)
            {
                var fromDatabaseEF = new SelectList(_context.FuneralHomes.ToList(), "ParentFuneralHomeId", "Name");
                ViewData["DBParentFuneralHome"] = fromDatabaseEF;
            }
            return View();
        }

        // POST: FuneralHomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuneralHomeId,ParentFuneralHomeId,Name,PlantId,Address,City,State,ZipCode,County,Email,Website,Phone1,PhoneType1,Phone2,PhoneType2")] FuneralHome funeralHome)
        {
            if (ModelState.IsValid)
            {
              
                _context.Add(funeralHome);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlantId"] = new SelectList(_context.Plants, "PlantId", "PlantId", funeralHome.PlantId);
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
            using (_context)
            {
                var fromDatabaseEF = new SelectList(_context.FuneralHomes.ToList(), "ParentFuneralHomeId", "Name");
                ViewData["DBParentFuneralHome"] = fromDatabaseEF;
            }
            return View(funeralHome);
        }

        // POST: FuneralHomes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuneralHomeId,ParentFuneralHomeId,Name,PlantId,Address,City,State,ZipCode,County,Email,Website,Phone1,PhoneType1,Phone2,PhoneType2")] FuneralHome funeralHome)
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
            ViewData["PlantId"] = new SelectList(_context.Plants, "PlantId", "PlantId", funeralHome.PlantId);
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
                .Include(f => f.Plant)
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
    }
}
