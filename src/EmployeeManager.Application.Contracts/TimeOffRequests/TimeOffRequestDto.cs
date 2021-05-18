using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace EmployeeManager.TimeOffRequests
{
    public class TimeOffRequestDto : AuditedEntityDto<Guid>
    {
        public string UserName { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Note { get; set; }
        public TimeOffRequestStatus Status { get; set; }
    }
}
