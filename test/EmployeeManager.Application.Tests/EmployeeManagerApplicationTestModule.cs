using Volo.Abp.Modularity;

namespace EmployeeManager
{
    [DependsOn(
        typeof(EmployeeManagerApplicationModule),
        typeof(EmployeeManagerDomainTestModule)
        )]
    public class EmployeeManagerApplicationTestModule : AbpModule
    {

    }
}