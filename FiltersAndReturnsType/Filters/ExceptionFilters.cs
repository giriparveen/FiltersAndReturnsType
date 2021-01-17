using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Filters
{
    public class ExceptionFilters : Attribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // OnException
            if (context.Exception is TimeoutException)
            {
                context.Result = new StatusCodeResult(504);
            }
        }
    }

    public class ExceptionFiltersAnotherWay : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            // This is another way to use the filter
            if(context.Exception is TimeoutException)
            {
                context.Result = new StatusCodeResult(504);
            }
        }
    }
}
