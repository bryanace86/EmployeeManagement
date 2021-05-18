using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EmployeeManager.TimeOffRequests
{
    public interface ITimeOffRequestAppServiceTest :
        IApplicationService
    {
        Task<TimeOffRequestDto> GetAsync(Guid id);

        Task<PagedResultDto<TimeOffRequestDto>> GetListAsync(int skipCount,
            int maxResultCount,
            string sorting,
            Guid currentUserId);

        Task<TimeOffRequestDto> CreateAsync(CreateUpdateTimeOffRequestDto input);

        Task UpdateAsync(Guid id, CreateUpdateTimeOffRequestDto input);

        Task DeleteAsync(Guid id);
    }
}
