using EmployeeManager.Localization;
using Volo.Abp.AspNetCore.Components;

namespace EmployeeManager.Blazor
{
    public abstract class EmployeeManagerComponentBase : AbpComponentBase
    {
        protected EmployeeManagerComponentBase()
        {
            LocalizationResource = typeof(EmployeeManagerResource);
        }
    }
}
