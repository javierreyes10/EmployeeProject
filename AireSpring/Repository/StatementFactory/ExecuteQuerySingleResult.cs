using System.Data;
using AireSpring.Model;
using Dapper;

namespace AireSpring.Repository.StatementFactory
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