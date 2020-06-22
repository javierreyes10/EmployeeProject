using AireSpring.Helper;

namespace AireSpring.Service.StatementFactory
{
    public static class ExecuteStatementFactory
    {
        public static IExecuteStatement<T> Get<T>(string statement)
        {
            switch (statement)
            {
                case ExecuteHelper.QUERY: return new ExecuteQuery() as IExecuteStatement<T>;
                case ExecuteHelper.SINGLE_QUERY: return new ExecuteQuerySingleResult() as IExecuteStatement<T>;
                case ExecuteHelper.UPDATE: return new ExecuteUpdate() as IExecuteStatement<T>;
                case ExecuteHelper.INSERT: return new ExecuteInsert() as IExecuteStatement<T>;
                default: return null;
            }
        }
    }
}