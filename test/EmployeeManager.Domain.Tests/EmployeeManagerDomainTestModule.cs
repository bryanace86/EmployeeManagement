using EmployeeManager.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EmployeeManager
{
    [DependsOn(
        typeof(EmployeeManagerEntityFrameworkCoreTestModule)
        )]
    public class EmployeeManagerDomainTestModule : AbpModule
    {

    }
}