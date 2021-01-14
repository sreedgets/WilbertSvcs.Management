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
    public class FuneralHomeContactsController : Controller
    {
        private readonly wilbertdbContext _context;

        public FuneralHomeContactsController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: FuneralHomeContacts
        public async Task<IActionResult> Index()
        {
            return View(await _context.FuneralHomeContacts.ToListAsync());
        }

        // GET: FuneralHomeContacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funeralHomeContact = await _context.FuneralHomeContacts
                .FirstOrDefaultAsync(m => m.FuneralHomeContactId == id);
            if (funeralHomeContact == null)
            {
                return NotFound();
            }

            return View(funeralHomeContact);
        }

        // GET: FuneralHomeContacts/Create
        public async Task<IActionResult> CreateAsync(int Id)
        {
            if (Id == 0)
            {
                return NotFound();
            }
            
            var funeralhome = await _context.FuneralHomes.FindAsync(Id);
            if (funeralhome == null)
                return NotFound();

            FuneralHomeContact fhc = new FuneralHomeContact();
            fhc.fhName = funeralhome.Name;
            fhc.FuneralHomeId = Id;
            return View(fhc);
        }

        // POST: FuneralHomeContacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int Id, [Bind("FuneralHomeContactId,FuneralHomeId,FirstName,LastName,NickName,Phone1,Phone2,Phone3,PhoneType1,PhoneType2,PhoneType3,Spouse,ShowPrices,ContactRole,Interests,Photo")] FuneralHomeContact funeralHomeContact)
        {
            if (Id == 0)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                funeralHomeContact.FuneralHomeId = Id;
                _context.Add(funeralHomeContact);
                await _context.SaveChangesAsync();
                return RedirectToAction("Edit", "FuneralHomes", new { Id = funeralHomeContact.FuneralHomeId });
            }
            return View(funeralHomeContact);
        }

        // GET: FuneralHomeContacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funeralHomeContact = await _context.FuneralHomeContacts.FindAsync(id);
            if (funeralHomeContact == null)
            {
                return NotFound();
            }
            return View(funeralHomeContact);
        }

        // POST: FuneralHomeContacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuneralHomeContactId,FuneralHomeId,FirstName,LastName,NickName,Phone1,Phone2,Phone3,PhoneType1,PhoneType2,PhoneType3,Spouse,ShowPrices,ContactRole,Interests,Photo")] FuneralHomeContact funeralHomeContact)
        {
            if (id != funeralHomeContact.FuneralHomeContactId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funeralHomeContact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FuneralHomeContactExists(funeralHomeContact.FuneralHomeContactId))
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
            return View(funeralHomeContact);
        }

        // GET: FuneralHomeContacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funeralHomeContact = await _context.FuneralHomeContacts
                .FirstOrDefaultAsync(m => m.FuneralHomeContactId == id);
            if (funeralHomeContact == null)
            {
                return NotFound();
            }

            return View(funeralHomeContact);
        }

        // POST: FuneralHomeContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funeralHomeContact = await _context.FuneralHomeContacts.FindAsync(id);
            _context.FuneralHomeContacts.Remove(funeralHomeContact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FuneralHomeContactExists(int id)
        {
            return _context.FuneralHomeContacts.Any(e => e.FuneralHomeContactId == id);
        }
        public IActionResult SwitchToTabs(string tabname, int id)
        {
            var fhc = new FuneralHomeContact();
            switch (tabname)
            {
                case "Details":
                    fhc.ActiveTab = FuneralHomeContact.Tab.Details;
                    break;
                case "Preferences":
                    fhc.ActiveTab = FuneralHomeContact.Tab.Preferences;
                    break;
                
            }
            return RedirectToAction("Create");
        }

    }
}
