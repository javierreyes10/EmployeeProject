using System.Collections.Generic;
using AireSpring.Model;

namespace AireSpring.Repository
{
    public interface IEmployeeRepository
    {
        Employee GetEmployeeById(int id);
        IEnumerable<Employee> GetEmployees();
        bool AddEmployee(Employee employee);

        bool UpdateEmployee(Employee employee);
    }
}
