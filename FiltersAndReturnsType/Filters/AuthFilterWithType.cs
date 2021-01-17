using FiltersAndReturnsType.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Filters
{
    public class AuthFilterWithType : IAuthorizationFilter
    {
        private readonly IAuthStatusRepository _authStatusRepository;
        public string _filterStatus { get; set; }
        public AuthFilterWithType(IAuthStatusRepository authStatusRepository, string filterStatus)
        {
            _authStatusRepository = authStatusRepository;
            _filterStatus = filterStatus;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!_authStatusRepository.GetAuthStatus(_filterStatus))
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }
}
