using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AireSpring.Model;
using Dapper;

namespace AireSpring.Service
{
    public class EmployeeRepositoryDb : IEmployeeRepository
    {
        public Employee GetEmployeeById(int id)
        {
            var sql = "SELECT * FROM EMPLOYEE WHERE ID = @EMPLOYEEID;";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed) db.Open();
                Employee employee;

                try
                {
                    employee = db.QueryFirst<Employee>(sql, new {EMPLOYEEID = id});
                }
                catch
                {
                    employee = null;

                }

                return employee;
            }

        }

        public IEnumerable<Employee> GetEmployees()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString))
            {
                if(db.State == ConnectionState.Closed) db.Open();
                IEnumerable<Employee> employees;
                try
                {
                    employees =  db.Query<Employee>("select * from employee").ToList();
                }
                catch (Exception e)
                {
                    employees = new List<Employee>();
                }

                return employees;
            }
        }

        public bool AddEmployee(Employee employee)
        {
            var sql =
                "INSERT INTO EMPLOYEE(FIRSTNAME, LASTNAME, ZIP, PHONE, HIREDATE) VALUES (@FIRSTNAME, @LASTNAME, @ZIP, @PHONE, @HIREDATE);";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed) db.Open();

                int affectedRows;

                try
                {
                    affectedRows = db.Execute(sql, new { FIRSTNAME = employee.FirstName, 
                                            LASTNAME = employee.LastName, 
                                            ZIP = employee.Zip,
                                            HIREDATE = employee.HireDate,
                                            PHONE = employee.Phone
                    });
                }
                catch
                {
                    affectedRows = 0;
                }

                return (affectedRows > 0);
            }

        }

        public bool UpdateEmployee(Employee employee)
        {
            var sql =
                @"UPDATE EMPLOYEE 
                 SET FIRSTNAME = @FIRSTNAME, 
                     LASTNAME = @LASTNAME, 
                     ZIP = @ZIP, 
                     PHONE =  @PHONE, 
                    HIREDATE= @HIREDATE 
                WHERE ID = @EMPLOYEEID;";

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed) db.Open();

                int affectedRows;

                try
                {
                    affectedRows = db.Execute(sql, new
                    {
                        FIRSTNAME = employee.FirstName,
                        LASTNAME = employee.LastName,
                        ZIP = employee.Zip,
                        HIREDATE = employee.HireDate,
                        PHONE = employee.Phone,
                        EMPLOYEEID = employee.Id
                    });
                }
                catch(Exception e)
                {
                    affectedRows = 0;
                }

                return (affectedRows > 0);
            }
        }
    }
}