using FiltersAndReturnsType.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiltersAndReturnsType.Repositories
{
    public class EmployeeRepository : IEmployeeReposotory
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee{ Id=1, Name="Praveen"},
             new Employee{ Id=2, Name="Sumit"},
              new Employee{ Id=3, Name="Tanya"}
        };
        public IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
