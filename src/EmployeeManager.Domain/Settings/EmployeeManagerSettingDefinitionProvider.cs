using Volo.Abp.Settings;

namespace EmployeeManager.Settings
{
    public class EmployeeManagerSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(EmployeeManagerSettings.MySetting1));
        }
    }
}
