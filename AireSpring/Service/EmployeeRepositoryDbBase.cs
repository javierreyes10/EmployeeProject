using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Web;
using AireSpring.Model;
using Dapper;

namespace AireSpring.Service.ExecuteStatementFactory
{
    public class EmployeeRepositoryDbBase
    {
        protected T Execute<T>(string statement, Employee employee)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed) db.Open();

                T TResult;

                try
                {
                    var executeStatement = ExecuteStatementFactory.Get<T>(statement);
                    TResult = executeStatement.ExecuteStatement(db, employee);
                }
                catch
                {
                    TResult = default(T);

                }

                return TResult;
            }
        }
    }
}