using System.Configuration;

namespace AireSpring.Helper
{
    public class DbHelperConnectionString : IDbHelperConnectionString
    {
        public string ConnectionString => ConfigurationManager.ConnectionStrings["EmployeeDB"].ConnectionString;
    }
}