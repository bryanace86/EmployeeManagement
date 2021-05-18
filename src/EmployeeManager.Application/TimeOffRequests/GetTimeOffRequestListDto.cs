using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace EmployeeManager.TimeOffRequests
{
    public class GetTimeOffRequestListDto : PagedAndSortedResultRequestDto
    {
        public Guid CurrentUserId { get; set; }
    }
}
