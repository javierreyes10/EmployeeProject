using System.Data;
using AireSpring.Model;

namespace AireSpring.Repository.StatementFactory
{
    public interface IExecuteStatement<T>
    {
        T ExecuteStatement(IDbConnection db, Employee employee);
    }
}
