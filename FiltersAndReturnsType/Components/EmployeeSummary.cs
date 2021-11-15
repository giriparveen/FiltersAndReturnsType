using FiltersAndReturnsType.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Components
{
    public class EmployeeSummary: ViewComponent
    {
        private readonly IEmployeeReposotory _employeeReposotory;
        public EmployeeSummary(IEmployeeReposotory employeeReposotory)
        {
            _employeeReposotory = employeeReposotory;
        }
        // Invoke method
        public IViewComponentResult Invoke()
        {
            var employeeCount = _employeeReposotory.GetEmployees().Count();
            ViewBag.EmployeeCount = employeeCount;
            return View(employeeCount);
        }
    }
}
