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
    public class InteractionsController : Controller
    {
        private readonly wilbertdbContext _context;

        public InteractionsController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: Interactions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Interactions.ToListAsync());
        }

        // GET: Interactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interaction = await _context.Interactions
                .FirstOrDefaultAsync(m => m.InteractionId == id);
            if (interaction == null)
            {
                return NotFound();
            }

            return View(interaction);
        }

        // GET: Interactions/Create
        public async Task<IActionResult> CreateAsync(int Id)
        {
            if (Id == 0)
            {
                return NotFound();
            }

            var funeralhome = await _context.FuneralHomes.FindAsync(Id);
            if (funeralhome == null)
                return NotFound();

            Interaction fhi = new Interaction();
            fhi.fhName = funeralhome.Name;
            fhi.Date = DateTime.Now;
            fhi.FollowUpDate = DateTime.Now;
            fhi.FuneralHomeId = Id;

            return View(fhi);
        }

        // POST: Interactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InteractionId,Date,Nature,Notes,FollowUpDate,Reason,Completed,Outcome,FuneralHomeId")] Interaction interaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(interaction);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "FuneralHomes", new { Id = interaction.FuneralHomeId });
            }
            return View(interaction);
        }

        // GET: Interactions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interaction = await _context.Interactions.FindAsync(id);
            if (interaction == null)
            {
                return NotFound();
            }
            return View(interaction);
        }

        // POST: Interactions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InteractionId,Date,Nature,Notes,FollowUpDate,Reason,Completed,Outcome,FuneralHomeId")] Interaction interaction)
        {
            if (id != interaction.InteractionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(interaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InteractionExists(interaction.InteractionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "FuneralHomes", new { Id = interaction.FuneralHomeId });
            }
            return View(interaction);
        }

        // GET: Interactions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var interaction = await _context.Interactions
                .FirstOrDefaultAsync(m => m.InteractionId == id);
            if (interaction == null)
            {
                return NotFound();
            }

            return View(interaction);
        }

        // POST: Interactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var interaction = await _context.Interactions.FindAsync(id);
            _context.Interactions.Remove(interaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InteractionExists(int id)
        {
            return _context.Interactions.Any(e => e.InteractionId == id);
        }
    }
}
