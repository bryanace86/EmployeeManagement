using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManager.TimeOffRequests
{
    public class CreateUpdateTimeOffRequestDto
    {
        public string UserName { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Note { get; set; }
        public TimeOffRequestStatus Status { get; set; } = TimeOffRequestStatus.Submited;
    }
}
