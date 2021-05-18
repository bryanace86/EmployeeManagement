using EmployeeManager.TimeOffRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace EmployeeManager.TimeOffRequsts
{
    public interface ITimeOffRequestRepository : IRepository<TimeOffRequest, Guid>
    {
        Task<List<TimeOffRequest>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            Guid currentUserId
        );
    }
}
