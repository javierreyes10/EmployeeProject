using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using AireSpring.Model;
using AireSpring.Service.StatementFactory;

namespace AireSpring.Service
{
    public class EmployeeRepositoryDbBase
    {
        protected T Execute<T>(string statement, Employee employee)
        {
            using (IDbConnection db =
                new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString))
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
                    TResult = default;
                }

                return TResult;
            }
        }
    }
}