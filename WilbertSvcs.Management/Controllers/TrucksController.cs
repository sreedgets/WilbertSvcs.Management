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
    public class TrucksController : Controller
    {
        private readonly wilbertdbContext _context;

        public TrucksController(wilbertdbContext context)
        {
            _context = context;
        }

        // GET: Trucks
        public async Task<IActionResult> Index()
        {
            var plants =  _context.Plants.ToList();
            foreach (var plt in plants)
            {
                List<Truck> trklist = new List<Truck>();
                trklist = await (from p in _context.Truck
                           where p.PlantId == plt.PlantId
                           select p).ToListAsync();
                plt.PlantTrucks = trklist;
            }
            return View(plants);
        }

        // GET: Trucks/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truck = await _context.Truck
                .FirstOrDefaultAsync(m => m.TruckId == id);
            if (truck == null)
            {
                return NotFound();
            }

            return View(truck);
        }

        // GET: Trucks/Create
        public IActionResult Create()
        {
            var tr = new Truck();
            tr.AcquisitionDate = DateTime.Now;

            List<Plant> lstPlants = _context.Plants.ToList();
            tr.Plants.Add(new Plant()
            {
                PlantName = "-Select-",
                PlantId = 0
            });
            foreach (var item in lstPlants)
            {
                tr.Plants.Add(new Plant()
                {
                    PlantName = item.PlantName,
                    PlantId = item.PlantId
                });
            }

            return View(tr);
        }

        // POST: Trucks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TruckId,AcquisitionDate,PlantId,DriverEmployeeId,Make,Model,Year,Type,RegCounty,Vin,Tonnage,LicPlateRenewal,RegFee,TruckNumber,Inactive,InactiveReason")] Truck truck)
        {
            if (ModelState.IsValid)
            {
                var plant = new Plant();
                plant = await _context.Plants.FindAsync(truck.PlantId);
                truck.PlantName = plant.PlantName;
                _context.Add(truck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(truck);
        }

        // GET: Trucks/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truck = await _context.Truck.FindAsync(id);

            List<Plant> lstPlants = _context.Plants.ToList();
            truck.Plants.Add(new Plant()
            {
                PlantName = "-Select-",
                PlantId = 0
            });
            foreach (var item in lstPlants)
            {
                truck.Plants.Add(new Plant()
                {
                    PlantName = item.PlantName,
                    PlantId = item.PlantId
                });
            }

            if (truck == null)
            {
                return NotFound();
            }

           
            return View(truck);
        }

        // POST: Trucks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TruckId,AcquisitionDate,PlantId,DriverEmployeeId,Make,Model,Year,Type,RegCounty,Vin,Tonnage,LicPlateRenewal,RegFee,TruckNumber,Inactive,InactiveReason")] Truck truck)
        {
            if (id != truck.TruckId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    Plant plt = new Plant();
                    plt = await _context.Plants.FindAsync(truck.PlantId);
                    truck.PlantName = plt.PlantName;
                    _context.Update(truck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TruckExists(truck.TruckId))
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
            return View(truck);
        }

        // GET: Trucks/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var truck = await _context.Truck
                .FirstOrDefaultAsync(m => m.TruckId == id);
            if (truck == null)
            {
                return NotFound();
            }

            return View(truck);
        }

        // POST: Trucks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var truck = await _context.Truck.FindAsync(id);
            _context.Truck.Remove(truck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TruckExists(string id)
        {
            return _context.Truck.Any(e => e.TruckId == id);
        }
    }
}
