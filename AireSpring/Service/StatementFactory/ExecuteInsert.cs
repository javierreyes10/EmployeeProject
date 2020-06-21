using System.Data;
using AireSpring.Model;
using Dapper;

namespace AireSpring.Service.StatementFactory
{
    public class ExecuteInsert : IExecuteStatement<int>
    {
        public int ExecuteStatement(IDbConnection db, Employee employee)
        {
            var sql = "INSERT INTO EMPLOYEE(FIRSTNAME, LASTNAME, ZIP, PHONE, HIREDATE) VALUES (@FIRSTNAME, @LASTNAME, @ZIP, @PHONE, @HIREDATE);";

            return db.Execute(sql, new
            {
                FIRSTNAME = employee.FirstName,
                LASTNAME = employee.LastName,
                ZIP = employee.Zip,
                HIREDATE = employee.HireDate,
                PHONE = employee.Phone
            });
        }
    }
}