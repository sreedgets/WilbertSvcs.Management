using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WilbertSvcs.Management.PageControls;
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
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber, string VOrdSearch)
        {
            int pageSize = 25;

            ViewData["GetVaultOrderSearched"] = VOrdSearch;
            ViewData["CurrentSort"] = sortOrder;

            var vaultOrderQuery = from x in _context.VaultOrder select x;
            if (!String.IsNullOrEmpty(VOrdSearch))
            {
                if (searchString != null)
                {
                    pageNumber = 1;
                }
                else
                {
                    searchString = currentFilter;
                }

                vaultOrderQuery = vaultOrderQuery.Where(n => n.funeralhome.Name.Contains(VOrdSearch));
                return View(await PaginatedList<VaultOrder>.CreateAsync(vaultOrderQuery, pageNumber ?? 1, pageSize));
            }


            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            var VOlist = await _context.VaultOrder.ToListAsync();

            return View(await PaginatedList<VaultOrder>.CreateAsync(vaultOrderQuery, pageNumber ?? 1, pageSize));
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
            var VO = new VaultOrder();

            VO.FuneralDate = DateTime.Now;
            VO.CemetaryTime = DateTime.Now;
            VO.theDeceased = new Deceased();
            VO.theDeceased.BornDate = DateTime.Now;
            VO.theDeceased.DiedDate = DateTime.Now;

            //Ordering plant
            List<Plant> lstPlants = _context.Plants.ToList();
            VO.OrderingPlant.Add(new Plant()
            {
                PlantName = "-Select-",
                PlantId = 0
            });
            foreach (var item in lstPlants)
            {
                VO.OrderingPlant.Add(new Plant()
                {
                    PlantName = item.PlantName,
                    PlantId = item.PlantId
                });
            }

            //Delivering plant            
            VO.DeliveringPlant.Add(new Plant()
            {
                PlantName = "-Select-",
                PlantId = 0
            });
            foreach (var item in lstPlants)
            {
                VO.DeliveringPlant.Add(new Plant()
                {
                    PlantName = item.PlantName,
                    PlantId = item.PlantId
                });
            }

            //Funeral Home
            List<FuneralHome> fhs = _context.FuneralHomes.ToList();
            VO.FuneralHomes.Add(new FuneralHome()
            {
                Name = "-Select-",
                FuneralHomeId = 0
            });
            foreach(var item in fhs)
            {
                VO.FuneralHomes.Add(new FuneralHome()
                {
                    Name = item.Name,
                    FuneralHomeId = item.FuneralHomeId
                });
            }

            //Funeral Home Contact (Funeral Director).  TODO: Take the id of the selected funeral home and look up the contacts who are funeral directors and put them
            //in the select list

            List<FuneralHomeContact> fhcts = _context.FuneralHomeContacts.ToList();
            VO.funeralhome.Contacts.Add(new FuneralHomeContact()
            {
                FullName = "-Select-",
                FuneralHomeContactId = 0
            });

            foreach(var item in fhcts)
            {
                VO.funeralhome.Contacts.Add(new FuneralHomeContact()
                {
                    FullName = item.FullName,
                    FuneralHomeContactId = item.FuneralHomeContactId
                });
            }

            //Cemetery
            List<Cemetary> cems = _context.Cemetary.ToList();
            VO.lstCemetaries.Add(new Cemetary()
            {
                Name = "-Select-",
                CemetaryId = 0
            }); 

            foreach(var item in cems)
            {
                VO.lstCemetaries.Add(new Cemetary
                {
                    Name = item.Name,
                    CemetaryId = item.CemetaryId
                });
            }
            return View(VO);
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
