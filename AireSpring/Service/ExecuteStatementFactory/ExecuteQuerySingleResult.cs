using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AireSpring.Model;
using Dapper;

namespace AireSpring.Service.ExecuteStatementFactory
{
    public class ExecuteQuerySingleResult : IExecuteStatement<Employee>
    {
        public Employee ExecuteStatement(IDbConnection db, Employee employee)
        {
            var sql = "SELECT * FROM EMPLOYEE WHERE ID = @EMPLOYEEID;";
            return db.QueryFirst<Employee>(sql, new { EMPLOYEEID = employee.Id });
        }
    }
}