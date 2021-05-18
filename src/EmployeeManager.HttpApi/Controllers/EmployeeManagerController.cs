using EmployeeManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EmployeeManager.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class EmployeeManagerController : AbpController
    {
        protected EmployeeManagerController()
        {
            LocalizationResource = typeof(EmployeeManagerResource);
        }
    }
}