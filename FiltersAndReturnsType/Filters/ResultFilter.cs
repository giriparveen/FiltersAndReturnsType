using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Filters
{
    public class ResultFilter : Attribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext context)
        {
           // After render the result on View
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
           // After execute the action method and before render the result
        }
    }
}
