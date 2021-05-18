using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace EmployeeManager.Data
{
    /* This is used if database provider does't define
     * IEmployeeManagerDbSchemaMigrator implementation.
     */
    public class NullEmployeeManagerDbSchemaMigrator : IEmployeeManagerDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}