namespace AireSpring.Service.StatementFactory
{
    public static class ExecuteStatementFactory
    {
        public static IExecuteStatement<T> Get<T>(string statement)
        {
            switch (statement)
            {
                case "QUERY": return new ExecuteQuery() as IExecuteStatement<T>;
                case "SINGLE": return new ExecuteQuerySingleResult() as IExecuteStatement<T>;
                case "UPDATE": return new ExecuteUpdate() as IExecuteStatement<T>;
                case "INSERT": return new ExecuteInsert() as IExecuteStatement<T>;
                default: return null;
            }
        }
    }
}