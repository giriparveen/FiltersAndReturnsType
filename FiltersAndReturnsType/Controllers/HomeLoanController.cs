using FiltersAndReturnsType.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Controllers
{
   [TypeFilter(typeof(AuthFilterWithType), Arguments=new object[] { "HomeLoan"})]
    public class HomeLoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
