using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Filters
{
    public class AuthFilters : Attribute, IAuthorizationFilter
    {
        public string FilterName { get; set; }
        private Dictionary<string, bool> FilterStatus = new Dictionary<string, bool>
        {
            { "Loan", true },
            { "HomeLoan", false },
            { "Home", true }

        };
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // Autherization filter runs just after routing
            if (!FilterStatus[FilterName])
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }
}
