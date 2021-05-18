using EmployeeManager.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace EmployeeManager.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(EmployeeManagerEntityFrameworkCoreDbMigrationsModule),
        typeof(EmployeeManagerApplicationContractsModule)
        )]
    public class EmployeeManagerDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
