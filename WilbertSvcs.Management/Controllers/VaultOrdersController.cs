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

                vaultOrderQuery = vaultOrderQuery.Where(n => n.funeralhome.Contains(VOrdSearch));
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
            foreach (var item in VOlist)
            {
                item.Status = Enum.GetName(typeof(OrderStatus), Int32.Parse(item.Status));
            }
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

            vaultOrder.Status = Enum.GetName(typeof(OrderStatus), Int32.Parse(vaultOrder.Status));
            vaultOrder.Location = Enum.GetName(typeof(FuneralLocation), Int32.Parse(vaultOrder.Location));
            vaultOrder.Salutation = Enum.GetName(typeof(Salutations), Int32.Parse(vaultOrder.Salutation));
            vaultOrder.Suffix = Enum.GetName(typeof(Suffix), Int32.Parse(vaultOrder.Suffix));

            return View(vaultOrder);
        }

        // GET: VaultOrders/Create    // GET: VaultOrders/Create
        public IActionResult Create()
        {
            var VO = new VaultOrder();
            var dateNow = DateTime.Now;
            VO.FuneralDate = DateTime.Now;
            VO.CemetaryTime = DateTime.Now;
            
            VO.BornDate = DateTime.Now;
            VO.DiedDate = DateTime.Now;

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
            var fhs = _context.FuneralHomes.ToList().OrderBy(fh => fh.Name);
            VO.FuneralHomes.Add(new FuneralHome()
            {
                Name = "-Select-",
                FuneralHomeId = 0
            });
            foreach (var item in fhs)
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
            VO.Contacts.Add(new FuneralHomeContact()
            {
                FullName = "-Select-",
                FuneralHomeContactId = 0
            });

            foreach (var item in fhcts)
            {
                VO.Contacts.Add(new FuneralHomeContact()
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

            foreach (var item in cems)
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
        public async Task<IActionResult> Create([Bind("VaultOrderId,strFuneralDate,FuneralDate," +
            "CemetaryTime,strCemeteryTime,Location,GraveLocationSection,OrderingPlantId," +
            "OrderingPlantName,DeliveringPlantId,DeliveringPlantName,ZipCode,FuneralHomeId," +
            "NewFuneralHome,FuneralDirector,NewFuneralDirector,CemetaryId,Status,Category,VaultId," +
            "VenetianCarapace,TentWith6Chairs,ExtraChairs,RegisterStand,MilitarySetup,AwningOverCasket," +
            "Fdrequest,VaultOrderNotes,PlantId,ContactId," +
            "Salutation,FirstName,MiddleName,LastName,FullName,Suffix,BornDate,DiedDate")] VaultOrder vaultOrder)
        {
            if (ModelState.IsValid)
            {
                if (vaultOrder.OrderingPlantId != 0)
                {
                    var ordPlant = new Plant();
                    ordPlant = await _context.Plants.FindAsync(vaultOrder.OrderingPlantId);
                    vaultOrder.OrderingPlantName = ordPlant.PlantName;
                }
                if (vaultOrder.DeliveringPlantId != 0)
                {
                    var delPlant = new Plant();
                    delPlant = await _context.Plants.FindAsync(vaultOrder.DeliveringPlantId);
                    vaultOrder.DeliveringPlantName = delPlant.PlantName;
                }

                if(vaultOrder.FuneralHomeId != 0)
                {
                    vaultOrder.funeralhome = (from f in _context.FuneralHomes.Where(i => i.FuneralHomeId == vaultOrder.FuneralHomeId)
                                              select f.Name).FirstOrDefault();                    
                }

                if(vaultOrder.FuneralHomeContactId != 0)
                {
                    vaultOrder.FuneralDirector = (from f in _context.FuneralHomeContacts.Where(i => i.FuneralHomeContactId == vaultOrder.FuneralHomeContactId)
                                                  select f.FullName).FirstOrDefault();
                }

                _context.Add(vaultOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaultOrder);
        }

        // GET: VaultOrders/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var VO = await _context.VaultOrder.FindAsync(id);
            if (VO == null)
            {
                return NotFound();
            }

       
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
            var fhs = _context.FuneralHomes.ToList().OrderBy(fh => fh.Name);
            VO.FuneralHomes.Add(new FuneralHome()
            {
                Name = "-Select-",
                FuneralHomeId = 0
            });
            foreach (var item in fhs)
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
            VO.Contacts.Add(new FuneralHomeContact()
            {
                FullName = "-Select-",
                FuneralHomeContactId = 0
            });

            foreach (var item in fhcts)
            {
                VO.Contacts.Add(new FuneralHomeContact()
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

            foreach (var item in cems)
            {
                VO.lstCemetaries.Add(new Cemetary
                {
                    Name = item.Name,
                    CemetaryId = item.CemetaryId
                });
            }

            ViewData["FuneralHomeId"] = new SelectList(_context.FuneralHomes, "FuneralHomeId", "FuneralHomeId", VO.FuneralHomeId);
            return View(VO);
        }

        // POST: VaultO rders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VaultOrderId,strFuneralDate,FuneralDate," +
            "CemetaryTime,strCemeteryTime,Location,GraveLocationSection,OrderingPlantId," +
            "OrderingPlantName,DeliveringPlantId,DeliveringPlantName,ZipCode,FuneralHomeId," +
            "FuneralHomeContactId,FuneralDirector,NewFuneralDirector,CemetaryId,Status,Category,VaultId," +
            "VenetianCarapace,TentWith6Chairs,ExtraChairs,RegisterStand,MilitarySetup,AwningOverCasket," +
            "Fdrequest,VaultOrderNotes,PlantId,ContactId," +
            "Salutation,FirstName,MiddleName,LastName,FullName,Suffix,BornDate,DiedDate")] VaultOrder vaultOrder)
        {
            if (id != vaultOrder.VaultOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (vaultOrder.OrderingPlantId != 0)
                {
                    var ordPlant = new Plant();
                    ordPlant = await _context.Plants.FindAsync(vaultOrder.OrderingPlantId);
                    vaultOrder.OrderingPlantName = ordPlant.PlantName;
                }
                if (vaultOrder.DeliveringPlantId != 0)
                {
                    var delPlant = new Plant();
                    delPlant = await _context.Plants.FindAsync(vaultOrder.DeliveringPlantId);
                    vaultOrder.DeliveringPlantName = delPlant.PlantName;
                }

                if (vaultOrder.FuneralHomeId != 0)
                {
                    vaultOrder.funeralhome = (from f in _context.FuneralHomes.Where(i => i.FuneralHomeId == vaultOrder.FuneralHomeId)
                                              select f.Name).FirstOrDefault();
                }

                if (vaultOrder.FuneralHomeContactId != 0)
                {
                    vaultOrder.FuneralDirector = (from f in _context.FuneralHomeContacts.Where(i => i.FuneralHomeContactId == vaultOrder.FuneralHomeContactId)
                                                  select f.FullName).FirstOrDefault();
                }

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
            ViewData["FuneralHomeId"] = new SelectList(_context.FuneralHomes, "FuneralHomeId", "FuneralHomeId", vaultOrder.FuneralHomeId);
            
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

            vaultOrder.Status = Enum.GetName(typeof(OrderStatus), Int32.Parse(vaultOrder.Status));
            vaultOrder.Location = Enum.GetName(typeof(FuneralLocation), Int32.Parse(vaultOrder.Location));
            vaultOrder.Salutation = Enum.GetName(typeof(Salutations), Int32.Parse(vaultOrder.Salutation));
            vaultOrder.Suffix = Enum.GetName(typeof(Suffix), Int32.Parse(vaultOrder.Suffix));

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
