using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EmployeeManager.TimeOffRequests
{
    public interface ITimeOffRequestAppService :
        ICrudAppService< //Defines CRUD methods
            TimeOffRequestDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTimeOffRequestDto> //Used to create/update a book
    {
        //Task<ListResultDto<UserLookupDto>> GetUserLookupAsync();
    }
}
