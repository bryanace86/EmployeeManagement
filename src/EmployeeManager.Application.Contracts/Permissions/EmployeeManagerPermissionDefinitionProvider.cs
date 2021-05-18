using EmployeeManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EmployeeManager.Permissions
{
    public class EmployeeManagerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var employeeManager = context.AddGroup(EmployeeManagerPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(EmployeeManagmentPermissions.MyPermission1, L("Permission:MyPermission1"));

            var timeOffRequests = context.AddGroup(EmployeeManagerPermissions.TimeOffRequestPermissions, L("Permission:TimeOffRequestPermissions"));

            var timeOffRequestsPermission = timeOffRequests.AddPermission(EmployeeManagerPermissions.TimeOffRequests.Default, L("Permission:TimeOffRequests"));
            timeOffRequestsPermission.AddChild(EmployeeManagerPermissions.TimeOffRequests.Create, L("Permission:TimeOffRequests.Create"));
            timeOffRequestsPermission.AddChild(EmployeeManagerPermissions.TimeOffRequests.EditAny, L("Permission:TimeOffRequests.EditAny"));
            timeOffRequestsPermission.AddChild(EmployeeManagerPermissions.TimeOffRequests.EditOwn, L("Permission:TimeOffRequests.EditOwn"));
            timeOffRequestsPermission.AddChild(EmployeeManagerPermissions.TimeOffRequests.DeleteAny, L("Permission:TimeOffRequests.DeleteAny"));
            timeOffRequestsPermission.AddChild(EmployeeManagerPermissions.TimeOffRequests.DeleteOwn, L("Permission:TimeOffRequests.DeleteOwn"));
            timeOffRequestsPermission.AddChild(EmployeeManagerPermissions.TimeOffRequests.Approve, L("Permission:TimeOffRequests.Approve"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<EmployeeManagerResource>(name);
        }
    }
}
