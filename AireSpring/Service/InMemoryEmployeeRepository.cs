using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AireSpring.Model;

namespace AireSpring.Service
{
    public class InMemoryEmployeeRepository : IEmployeeRepository
    {
        private readonly IEnumerable<Employee> _employees;
        public InMemoryEmployeeRepository()
        {
            _employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1, FirstName = "Javier", LastName = "Reyes", Phone = "7854 6325 8745", Zip = "503",
                    HireDate = DateTime.UtcNow
                },
                new Employee
                {
                    Id = 2, FirstName = "Bill", LastName = "Gates", Phone = "78 63 8745", Zip = "90201",
                    HireDate = DateTime.UtcNow
                },
                new Employee
                {
                    Id = 3, FirstName = "Bill", LastName = "Evans", Phone = "1234 5678 9012", Zip = "90201",
                    HireDate = DateTime.UtcNow
                },
                new Employee
                {
                    Id = 4, FirstName = "Jordan", LastName = "Rudess", Phone = "7854 6325 0000", Zip = "90203",
                    HireDate = DateTime.UtcNow
                },
                new Employee
                {
                    Id = 5, FirstName = "Michael", LastName = "Jackson", Phone = "7854 6325 111", Zip = "90203",
                    HireDate = DateTime.UtcNow
                },
                new Employee
                {
                    Id = 6, FirstName = "Steve", LastName = "Jobs", Phone = "7854 6325 2222", Zip = "90204",
                    HireDate = DateTime.UtcNow
                },
            };

        }
        public Employee GetEmployeeById(int id)
        {

            return _employees.FirstOrDefault(e => e.Id == id);
        }

        public void SaveEmployee(Employee employee)
        {
            
        }
    }
}