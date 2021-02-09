using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WilbertVaultCompany.api.Enums;
using WilbertVaultCompany.api.Models;

namespace WilbertSvcs.Management.ViewComponents
{
    public class EmployeeViewComponent : ViewComponent
    {
        private readonly wilbertdbContext _context;

        public EmployeeViewComponent(wilbertdbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            List<Employee> pltEmp = new List<Employee>();

            pltEmp = (from emplist in _context.Employee
                      where emplist.PlantId == id
                      select emplist).ToList();

            foreach (var emp in pltEmp)
            {
                emp.Title = Enum.GetName(typeof(PlantRole), Int32.Parse(emp.Title));
                emp.PhoneType1 = Enum.GetName(typeof(PhoneType), Int32.Parse(emp.PhoneType1));
            }

            return View(pltEmp);
        }
    }
}
