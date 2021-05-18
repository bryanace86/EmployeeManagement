using EmployeeManager.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace EmployeeManager.TimeOffRequests
{
    public class TimeOffRequest : AuditedAggregateRoot<Guid>
    {
        //public AppUser AppUser { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string Note { get; set; }
        public TimeOffRequestStatus Status { get; set; }
    }
}
