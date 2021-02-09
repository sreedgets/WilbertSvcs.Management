﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WilbertSvcs.Management.PageControls;
using WilbertVaultCompany.api.Enums;
using WilbertVaultCompany.api.Models;
using WilbertVaultCompany.api.Controllers;
using Microsoft.AspNetCore.Authorization;

namespace WilbertSvcs.Management.Controllers
{
    [Authorize(Roles = "Franchise Owner, Office / Admin, Sales, Franchise Manager, Owner / Funeral Director, Admin, Funeral Director, Superuser, Owner, Driver, Plant Manager")]
    public class FuneralHomesController : Controller
    {
        private readonly wilbertdbContext _context;

        public FuneralHomesController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: FuneralHomes
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber, string Fhsearch)
        {

            int pageSize = 25;

            ViewData["GetFuneralHomeSearched"] = Fhsearch;
            ViewData["CurrentSort"] = sortOrder;

            var funeralHomeQuery = from x in _context.FuneralHomes select x;
            if (!String.IsNullOrEmpty(Fhsearch))
            {
                if (searchString != null)
                {
                    pageNumber = 1;
                }
                else
                {
                    searchString = currentFilter;
                }

                funeralHomeQuery = funeralHomeQuery.Where(n => n.Name.Contains(Fhsearch));
                return View(await PaginatedList<FuneralHome>.CreateAsync(funeralHomeQuery, pageNumber ?? 1, pageSize));
            }


            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            FuneralHomesAPIController fhctrl = new FuneralHomesAPIController(_context);
            var fhList = await fhctrl.GetFuneralHomes();
            return View(await PaginatedList<FuneralHome>.CreateAsync(fhList, pageNumber ?? 1, pageSize));
        }



        // GET: FuneralHomes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FuneralHomesAPIController fhctrl = new FuneralHomesAPIController(_context);

            var funeralHome = await fhctrl.GetFuneralHome((int)id);

            if (funeralHome == null)
            {
                return NotFound();
            }

            return View(funeralHome);
        }

        // GET: FuneralHomes/Create
        [Authorize(Roles = "ADMIN, Superuser")]
        public IActionResult Create()
        {
            var fh = new FuneralHome();
            fh.ParentFuneralHomes = _context.ParentFuneralHomes.ToList();

            /////////////////////////////////////////////////////////////

            List<Plant> lstPlants = _context.Plants.ToList();
            fh.Plants.Add(new Plant()
            {
                PlantName = "-Select-",
                PlantId = 0
            });
            foreach (var item in lstPlants)
            {
                fh.Plants.Add(new Plant()
                {
                    PlantName = item.PlantName,
                    PlantId = item.PlantId
                });
            }

            return View(fh);
        }

        // POST: FuneralHomes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "ADMIN, Superuser")]
        public async Task<IActionResult> Create([Bind("FuneralHomeId,ParentFuneralHomeId,PlantId,Name,Address,Address2,City,State,ZipCode,County,Email,Website,Phone1,Phone2,Phone3,PhoneType1,PhoneType2,PhoneType3,IsParent,ParentName,PlantName")] FuneralHome funeralHome)
        {
            if (ModelState.IsValid)
            {
                // If no parent funeralhomes exist...
                if (_context.ParentFuneralHomes.Count() == 0)
                {
                    // if this funeralhome is a parent funeral home...
                    if (funeralHome.IsParent)
                    {
                        // 1) initialize a list of funeral homes.
                        initParentList(funeralHome);
                        // 2) add to list of funeral homes.
                        addParent(funeralHome);
                    }
                    else
                        // if this funeralhome is a parent funeral home...
                        initParentList(funeralHome);
                }
                else
                {
                    if (funeralHome.IsParent)
                    {
                        // add to list of funeral homes.
                        addParent(funeralHome);
                    }
                }

                if (funeralHome.ParentFuneralHomeId != null)
                {
                    var pfh = new ParentFuneralHome();
                    pfh = await _context.ParentFuneralHomes.FindAsync(funeralHome.ParentFuneralHomeId);
                    funeralHome.ParentName = pfh.ParentFuneralhomeName;
                }

                if (funeralHome.PlantId != 0)
                {
                    Plant plt = await _context.Plants.FindAsync(funeralHome.PlantId);
                    funeralHome.PlantName = plt.PlantName;
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

            var fh = await _context.FuneralHomes.FindAsync(id);
            if (fh == null)
            {
                return NotFound();
            }

            fh.ParentFuneralHomes = _context.ParentFuneralHomes.ToList();

            List<Plant> lstPlants = _context.Plants.ToList();
            fh.Plants.Add(new Plant()
            {
                PlantName = "-Select-",
                PlantId = 0
            });
            foreach (var item in lstPlants)
            {
                fh.Plants.Add(new Plant()
                {
                    PlantName = item.PlantName,
                    PlantId = item.PlantId
                });
            }


            return View(fh);
        }

        // POST: FuneralHomes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost, ActionName("SaveFuneralHome")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuneralHomeId,ParentFuneralHomeId,PlantId,Name,Address,Address2,City,State,ZipCode,County,Email,Website,Phone1,Phone2,Phone3,PhoneType1,PhoneType2,PhoneType3,IsParent,ParentName,PlantName")] FuneralHome funeralHome)
        {
            //if (id != funeralHome.FuneralHomeId)
            if (id == 0)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                if (_context.ParentFuneralHomes.Count() > 1)
                {

                    ParentFuneralHome parentFuneralHome = await _context.ParentFuneralHomes.FindAsync(funeralHome.ParentFuneralHomeId);
                    if (funeralHome.IsParent && parentFuneralHome == null)
                    {
                        initParentList(funeralHome);
                        addParent(funeralHome);
                    }
                    else
                        initParentList(funeralHome);

                    funeralHome.ParentName = parentFuneralHome.ParentFuneralhomeName;
                }
                else
                {
                    ParentFuneralHome parentFuneralHome = await _context.ParentFuneralHomes.FindAsync(funeralHome.ParentFuneralHomeId);
                    if (funeralHome.IsParent && parentFuneralHome == null)
                    {
                        addParent(funeralHome);
                    }
                    if (parentFuneralHome != null)
                        funeralHome.ParentName = parentFuneralHome.ParentFuneralhomeName;
                }

                if (funeralHome.PlantId != 0)
                {
                    Plant plt = await _context.Plants.FindAsync(funeralHome.PlantId);
                    funeralHome.PlantName = plt.PlantName;
                }

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
            return View(funeralHome);
        }

        // GET: FuneralHomes/Delete/5
        [Authorize(Roles = "ADMIN, Superuser")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funeralHome = await _context.FuneralHomes
                .FirstOrDefaultAsync(m => m.FuneralHomeId == id);


            if (funeralHome == null)
            {
                return NotFound();
            }
            funeralHome.State = Enum.GetName(typeof(States), Int32.Parse(funeralHome.State));

            funeralHome.PhoneType1 = Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType1)) == "Choose" ? "" : Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType1));
            funeralHome.PhoneType2 = Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType2)) == "Choose" ? "" : Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType2));
            funeralHome.PhoneType3 = Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType3)) == "Choose" ? "" : Enum.GetName(typeof(PhoneType), Int32.Parse(funeralHome.PhoneType3));

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
            fh.ParentFuneralHomes = _context.ParentFuneralHomes.ToList();
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
