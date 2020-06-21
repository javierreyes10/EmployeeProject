using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AireSpring.Model;

namespace AireSpring.Service
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);

        IEnumerable<Employee> GetEmployees();
        bool SaveEmployee(Employee employee);
    }
}
