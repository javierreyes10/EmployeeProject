using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AireSpring.Model;
using AireSpring.Service.ExecuteStatementFactory;
using Dapper;

namespace AireSpring.Service
{
    public class EmployeeRepositoryDb : EmployeeRepositoryDbBase,  IEmployeeRepository
    {
        public Employee GetEmployeeById(int id)
        {
            var employee = new Employee {Id = id};
            return Execute<Employee>("SINGLE", employee);

        }

        public IEnumerable<Employee> GetEmployees()
        {
            return Execute<List<Employee>>("QUERY", null);
        }

        public bool AddEmployee(Employee employee)
        {
            return (Execute<int>("INSERT", employee) > 0);

        }

        public bool UpdateEmployee(Employee employee)
        {
            return (Execute<int>("UPDATE", employee) > 0);
        }
    }
}