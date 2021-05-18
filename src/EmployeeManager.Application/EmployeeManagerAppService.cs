using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManager.Localization;
using Volo.Abp.Application.Services;

namespace EmployeeManager
{
    /* Inherit your application services from this class.
     */
    public abstract class EmployeeManagerAppService : ApplicationService
    {
        protected EmployeeManagerAppService()
        {
            LocalizationResource = typeof(EmployeeManagerResource);
        }
    }
}
