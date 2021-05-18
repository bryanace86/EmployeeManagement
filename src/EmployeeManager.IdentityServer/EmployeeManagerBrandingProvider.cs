using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace EmployeeManager
{
    [Dependency(ReplaceServices = true)]
    public class EmployeeManagerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "EmployeeManager";
    }
}
