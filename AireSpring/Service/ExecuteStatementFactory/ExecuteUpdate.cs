using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using AireSpring.Model;
using Dapper;

namespace AireSpring.Service.ExecuteStatementFactory
{
    public class ExecuteUpdate : IExecuteStatement<int>
    {
        public int ExecuteStatement(IDbConnection db, Employee employee)
        {
            var sql =
             @"UPDATE EMPLOYEE 
                 SET FIRSTNAME = @FIRSTNAME, 
                     LASTNAME = @LASTNAME, 
                     ZIP = @ZIP, 
                     PHONE =  @PHONE, 
                    HIREDATE= @HIREDATE 
                WHERE ID = @EMPLOYEEID;";

            return db.Execute(sql, new
            {
                FIRSTNAME = employee.FirstName,
                LASTNAME = employee.LastName,
                ZIP = employee.Zip,
                HIREDATE = employee.HireDate,
                PHONE = employee.Phone,
                EMPLOYEEID = employee.Id
            });
        }
    }
}