using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Repositories
{
    public interface IAuthStatusRepository
    {
        bool GetAuthStatus(string filterName);
    }
}
