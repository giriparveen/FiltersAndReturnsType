using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Repositories
{
    public class AuthStatusRepository : IAuthStatusRepository
    {
        public bool GetAuthStatus(string filterName)
        {
            if (filterName == "HomeLoan")
            {
                return false;
            }
            return true;
        }
    }
}
