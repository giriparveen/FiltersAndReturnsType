using FiltersAndReturnsType.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Repositories
{
    public interface IEmployeeReposotory
    {
        IEnumerable<Employee> GetEmployees();
    }
}
