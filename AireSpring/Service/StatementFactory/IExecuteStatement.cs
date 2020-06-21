using System.Data;
using AireSpring.Model;

namespace AireSpring.Service.StatementFactory
{
    public interface IExecuteStatement<T>
    {
        T ExecuteStatement(IDbConnection db, Employee employee);
    }
}
