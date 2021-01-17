using FiltersAndReturnsType.Models;
using FiltersAndReturnsType.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeReposotory _employeeReposotory;
        public EmployeeController(IEmployeeReposotory employeeReposotory)
        {
            _employeeReposotory = employeeReposotory;

        }
        public IActionResult Index()
        {
            var employee = _employeeReposotory.GetEmployees();
            return View(new EmployeeViewModel
            {
                Employees = employee,
                Title="IT Employee"
            });
        }
    }
}
