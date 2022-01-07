using System.Data.Entity;
using System.Data.Entity.SqlServer;
using Hogwarts.DAL;
using System.Data.Entity.Infrastructure.Interception;

namespace Hogwarts.DAL
{
    public class SchoolConfiguration : DbConfiguration
    {
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
            DbInterception.Add(new SchoolInterceptorTransientErrors());
            DbInterception.Add(new SchoolInterceptorLogging());
        }
    }
}