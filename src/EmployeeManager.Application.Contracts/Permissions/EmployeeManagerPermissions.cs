namespace EmployeeManager.Permissions
{
    public static class EmployeeManagerPermissions
    {
        public const string GroupName = "EmployeeManager";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";
        public const string TimeOffRequestPermissions = "TimeOffRequestPermissions";
        public static class TimeOffRequests
        {
            public const string Default = GroupName + ".TimeOffRequests";
            public const string Create = Default + ".Create";
            public const string EditAny = Default + ".EditAny";
            public const string EditOwn = Default + ".EditOwn";
            public const string DeleteAny = Default + ".DeleteAny";
            public const string DeleteOwn = Default + ".DeleteOwn";
            public const string Approve = Default + ".Approve";

        }

    }
}