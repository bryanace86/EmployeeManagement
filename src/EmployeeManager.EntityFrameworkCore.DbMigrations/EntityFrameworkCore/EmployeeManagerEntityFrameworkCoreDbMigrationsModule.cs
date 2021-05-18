using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace EmployeeManager.EntityFrameworkCore
{
    [DependsOn(
        typeof(EmployeeManagerEntityFrameworkCoreModule)
        )]
    public class EmployeeManagerEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<EmployeeManagerMigrationsDbContext>();
        }
    }
}
