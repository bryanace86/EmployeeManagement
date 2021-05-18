using System;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Validation;
using Xunit;

namespace EmployeeManager.TimeOffRequests
{
    public class TimeOffRequestService_Tests : EmployeeManagerApplicationTestBase
    {
        private readonly ITimeOffRequestAppService timeOffRequestAppService;

        public TimeOffRequestService_Tests()
        {
            timeOffRequestAppService = GetRequiredService<ITimeOffRequestAppService>();
        }

        [Fact]
        public async Task Should_Get_List_Of_Books()
        {
            //Act
            var result = await timeOffRequestAppService.GetListAsync(
                new PagedAndSortedResultRequestDto()
            );

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(b => b.CreatorId == Guid.Parse("48b06a93-9185-7519-cd41-39fc8a1672fd"));
        }

    }
}
