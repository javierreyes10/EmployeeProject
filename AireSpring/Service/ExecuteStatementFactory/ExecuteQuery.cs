using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AireSpring.Model;
using Dapper;

namespace AireSpring.Service.ExecuteStatementFactory
{
    public class ExecuteQuery : IExecuteStatement<List<Employee>>
    {
        public List<Employee> ExecuteStatement(IDbConnection db, Employee employee)
        {
            var sql = "select * from employee";
            return db.Query<Employee>(sql).ToList();
        }
    }
}