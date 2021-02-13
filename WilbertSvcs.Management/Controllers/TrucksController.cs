using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WilbertVaultCompany.api.Enums;
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
            var plants = _context.Plants.ToList();
            foreach (var plt in plants)
            {
                List<Truck> trklist = new List<Truck>();
                trklist = await (from p in _context.Truck
                                 where p.PlantId == plt.PlantId
                                 select p).ToListAsync();
                plt.Trucks = trklist;
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

            truck.AssignedPlant = await _context.Plants.FindAsync(truck.PlantId);            
            truck.LicPlateRenewal = Enum.GetName(typeof(LicDue), Int32.Parse(truck.LicPlateRenewal));

            return View(truck);
        }

        // GET: Trucks/Create
        public IActionResult Create()
        {
            var tr = new Truck();
            tr.AcquisitionDate = DateTime.Now;

            List<Plant> lstPlants = _context.Plants.ToList();
            tr.Plants = new List<Plant>();
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

            /********************************************************************************/

            List<Employee> lstEmp = (from e in _context.Employee
                                     where e.PlantId == tr.PlantId
                                     select e).ToList();

            tr.Drivers = new List<Employee>();
            tr.Drivers.Add(new Employee()
            {
                FirstName = "-Select-",
                EmployeeId = 0
            });
            foreach (var item in lstEmp)
            {
                tr.Drivers.Add(new Employee()
                {
                    FirstName = item.FirstName + " " + item.LastName,
                    EmployeeId = item.EmployeeId
                });
            }
            return View(tr);
        }

        // POST: Trucks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TruckId,AcquisitionDate,PlantId,DriverEmployeeId,DriverName,Make,Model,Year,Type,RegCounty,Vin,Tonnage,LicPlateRenewal,RegFee,TruckNumber,Inactive,InactiveReason")] Truck truck)
        {
            if (ModelState.IsValid)
            {
                var plant = new Plant();
                plant = await _context.Plants.FindAsync(truck.PlantId);
                truck.AssignedPlant = new Plant();
                truck.AssignedPlant = plant;

                Employee e = new Employee();
                e = await _context.Employee.FindAsync(truck.DriverEmployeeId);

                if (e.FirstName != null)
                    truck.DriverName = e.FirstName + " " + e.LastName;

                _context.Add(truck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Create));
        }

        // GET: Trucks/Edit/5
        public async Task<IActionResult> Edit(string id) // Id is license plate of Truck
        {
            if (id == null)
            {
                return NotFound();
            }

            var tr = await _context.Truck.FindAsync(id); // "BR 549" - Thank you Junior Samples!

            if (tr == null)
                return NotFound();

            List<Plant> lstPlants = _context.Plants.ToList();
            tr.Plants = new List<Plant>();
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

            /********************************************************************************/

            List<Employee> lstEmp = (from e in _context.Employee
                                     where e.PlantId == tr.PlantId  && e.Title == "3"
                                     select e).ToList();

            tr.Drivers = new List<Employee>();
            tr.Drivers.Add(new Employee()
            {
                FirstName = "-Select-",
                EmployeeId = 0
            });
            foreach (var item in lstEmp)
            {
                tr.Drivers.Add(new Employee()
                {
                    FirstName = item.FirstName + " " + item.LastName,
                    EmployeeId = item.EmployeeId
                });
            }

            return View(tr);
        }

        /// <summary>  
        /// This method will return PartialView with Employee Model  
        /// </summary>  
        /// <param name="PlantId"></param>  
        /// <returns></returns>  
        /// 
        // GetEmployeeRecord
        public PartialViewResult GetDriversForPlant(int PlantId)
        {
            Truck truck = new Truck();
            truck.Drivers = _context.Employee.Where(e => e.Title == "3" && e.PlantId == PlantId).ToList();
            
            return PartialView("_DriverListPartial", truck);
        }
        // POST: Trucks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TruckId,AcquisitionDate,PlantId,DriverEmployeeId,DriverName,Make,Model,Year,Type,RegCounty,Vin,Tonnage,LicPlateRenewal,RegFee,TruckNumber,Inactive,InactiveReason")] Truck truck)
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
                    truck.AssignedPlant = new Plant();
                    truck.AssignedPlant = plt;

                    Employee emp = new Employee();
                    emp = (from e in _context.Employee
                           where e.EmployeeId == truck.DriverEmployeeId && e.PlantId == truck.PlantId select e).FirstOrDefault();

                    if (emp != null)
                        truck.DriverName = emp.FirstName + " " + emp.LastName;
                    else
                    {
                        truck.DriverName = null;
                        _context.Update(truck);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("Edit", "Trucks", new { Id = truck.TruckId });
                    }
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

            truck.AssignedPlant = await _context.Plants.FindAsync(truck.PlantId);
            truck.LicPlateRenewal = Enum.GetName(typeof(LicDue), Int32.Parse(truck.LicPlateRenewal));

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
