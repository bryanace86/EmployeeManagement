using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EmployeeManager.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class EmployeeManagerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "EmployeeManager";
    }
}
