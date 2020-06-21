using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AireSpring.Model;

namespace AireSpring.Service.ExecuteStatementFactory
{
    public interface IExecuteStatement<T>
    {
        T ExecuteStatement(IDbConnection db, Employee employee);
    }
}
