using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WilbertVaultCompany.api.Models;
using WilbertVaultCompany.api.Controllers;
using WilbertVaultCompany.api.Enums;

namespace WilbertSvcs.Management.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly wilbertdbContext _context;

        public EmployeesController(wilbertdbContext context)
        {
            _context = context;
        }


        // GET: Employees
        public async Task<IActionResult> Index()
        {
            var plants = _context.Plants.ToList();
            foreach (var plt in plants)
            {
                List<Employee> emplist = new List<Employee>();
                emplist = await (from e in _context.Employee
                                 where e.PlantId == plt.PlantId
                                 select e).ToListAsync();

                foreach (var emp in emplist)
                {
                    emp.Title = Enum.GetName(typeof(PlantRole), Int32.Parse(emp.Title));
                    emp.PhoneType1 = Enum.GetName(typeof(PhoneType), Int32.Parse(emp.PhoneType1));
                }
                plt.Employees = emplist;
            }
            return View(plants);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.PlantEmployee)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }

            employee.Answers = new List<AnswerVm>
                    {
                        new AnswerVm {Id = 1, Answer= "Yes"},
                        new AnswerVm {Id = 2, Answer= "No"}
                    };

            employee.State = Enum.GetName(typeof(States), Int32.Parse(employee.State));
            employee.Title = Enum.GetName(typeof(PlantRole), Int32.Parse(employee.Title));
            employee.PhoneType1 = Enum.GetName(typeof(PhoneType), Int32.Parse(employee.PhoneType1));

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            var emp = new Employee();
            emp.Answers = new List<AnswerVm>
                    {
                        new AnswerVm {Id = 1, Answer= "Yes"},
                        new AnswerVm {Id = 2, Answer= "No"}
                    };

            List<Plant> lstPlants = _context.Plants.ToList();
            emp.Plants = new List<Plant>();
            emp.Plants.Add(new Plant()
            {
                PlantName = "-Select-",
                PlantId = 0
            });
            foreach (var item in lstPlants)
            {
                emp.Plants.Add(new Plant()
                {
                    PlantName = item.PlantName,
                    PlantId = item.PlantId
                });
            }
            return View(emp);
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,CanDoFollowUps,Title,FirstName,LastName,MiddleName,Address,City,State,ZipCode,County,Email,Phone1,PhoneType1,Active,PhotoImage,PlantId,SelectedAnswer")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.Active = employee.SelectedAnswer == 1;
                var plant = new Plant();
                plant = await _context.Plants.FindAsync(employee.PlantId);
                employee.PlantEmployee = new Plant();
                employee.PlantEmployee = plant;
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Create));
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emp = await _context.Employee.FindAsync(id);
            emp.Answers = new List<AnswerVm>
                    {
                        new AnswerVm {Id = 1, Answer= "Yes"},
                        new AnswerVm {Id = 2, Answer= "No"}
                    };

            List<Plant> lstPlants = _context.Plants.ToList();
            emp.Plants = new List<Plant>();
            emp.Plants.Add(new Plant()
            {
                PlantName = "-Select-",
                PlantId = 0
            });
            foreach (var item in lstPlants)
            {
                emp.Plants.Add(new Plant()
                {
                    PlantName = item.PlantName,
                    PlantId = item.PlantId
                });
            }

            if (emp == null)
            {
                return NotFound();
            }


            return View(emp);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeId,CanDoFollowUps,Title,FirstName,LastName,MiddleName,Address,City,State,ZipCode,County,Email,Phone1,PhoneType1,Active,PhotoImage,PlantId,SelectedAnswer")] Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                employee.Active = employee.SelectedAnswer == 1;
                    
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeId))
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
            ViewData["PlantId"] = new SelectList(_context.Plants, "PlantId", "PlantId", employee.PlantId);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employee
                .Include(e => e.PlantEmployee)
                .FirstOrDefaultAsync(m => m.EmployeeId == id);

            employee.Answers = new List<AnswerVm>
                    {
                        new AnswerVm {Id = 1, Answer= "Yes"},
                        new AnswerVm {Id = 2, Answer= "No"}
                    };

            if (employee == null)
            {
                return NotFound();
            }
            employee.State = Enum.GetName(typeof(States), Int32.Parse(employee.State));
            employee.Title = Enum.GetName(typeof(PlantRole), Int32.Parse(employee.Title));
            employee.PhoneType1 = Enum.GetName(typeof(PhoneType), Int32.Parse(employee.PhoneType1));

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employee.FindAsync(id);
            _context.Employee.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.EmployeeId == id);
        }
    }
}
