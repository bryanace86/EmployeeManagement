using AutoMapper;
using EmployeeManager.TimeOffRequests;

namespace EmployeeManager.Blazor
{
    public class EmployeeManagerBlazorAutoMapperProfile : Profile
    {
        public EmployeeManagerBlazorAutoMapperProfile()
        {
            //Define your AutoMapper configuration here for the Blazor project.
            CreateMap<TimeOffRequestDto, CreateUpdateTimeOffRequestDto>();
        }
    }
}
