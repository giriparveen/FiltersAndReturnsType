using FiltersAndReturnsType.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Controllers
{
    [AuthFilters(FilterName = "Loan")]
    public class LoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
