using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AireSpring.Model;

namespace AireSpring.Service
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee GetEmployeeById(int id)
        {
            return new Employee {Id = 1, FirstName = "Javier", LastName = "Reyes"};
        }

        public void SaveEmployee(Employee employee)
        {
            
        }
    }
}