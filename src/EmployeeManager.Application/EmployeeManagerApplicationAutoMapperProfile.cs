using AutoMapper;
using EmployeeManager.TimeOffRequests;

namespace EmployeeManager
{
    public class EmployeeManagerApplicationAutoMapperProfile : Profile
    {
        public EmployeeManagerApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<TimeOffRequest, TimeOffRequestDto>();
            CreateMap<CreateUpdateTimeOffRequestDto, TimeOffRequest>();
        }
    }
}
