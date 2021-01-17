using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Filters
{
    public class ActionFilters : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
          // After Action execution
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
           // Before Action execution
        }
    }
}
