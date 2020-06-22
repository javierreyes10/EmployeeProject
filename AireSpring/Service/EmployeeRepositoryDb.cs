using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AireSpring.Helper;
using AireSpring.Model;
using Dapper;

namespace AireSpring.Service
{
    public class EmployeeRepositoryDb : EmployeeRepositoryDbBase,  IEmployeeRepository
    {
        public Employee GetEmployeeById(int id)
        {
            var employee = new Employee {Id = id};
            return Execute<Employee>(ExecuteHelper.SINGLE_QUERY, employee);

        }

        public IEnumerable<Employee> GetEmployees()
        {
            return Execute<List<Employee>>(ExecuteHelper.QUERY, null);
        }

        public bool AddEmployee(Employee employee)
        {
            return (Execute<int>(ExecuteHelper.INSERT, employee) > 0);

        }

        public bool UpdateEmployee(Employee employee)
        {
            return (Execute<int>(ExecuteHelper.UPDATE, employee) > 0);
        }

        public EmployeeRepositoryDb(IDbHelperConnectionString connectionString) : base(connectionString)
        {
        }
    }
}