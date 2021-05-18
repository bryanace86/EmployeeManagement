using EmployeeManager.Permissions;
using EmployeeManager.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;
using Volo.Abp.Users;

namespace EmployeeManager.TimeOffRequests
{
    public class TimeOffRequestService :
        CrudAppService<
            TimeOffRequest, //The Book entity
            TimeOffRequestDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateTimeOffRequestDto>, //Used to create/update a book
        ITimeOffRequestAppService //implement the IBookAppService
    {
        protected IIdentityUserRepository userManager { get; }
        private readonly ICurrentUser currentUser;
        //private bool canUpdateAny;
        public string UpdateAnyPolicyName { get; }
        public string UpdateOwnPolicyName { get; }
        public string DeleteAnyPolicyName { get; }
        public string DeleteOwnPolicyName { get; }
        public string ApprovePolicyName { get; }

        public TimeOffRequestService(IRepository<TimeOffRequest, Guid> repository,
            //IUserLookupService<AppUser> userManager
            IIdentityUserRepository userManager,
            ICurrentUser currentUser
            )
            : base(repository)
        {
            this.userManager = userManager;
            this.currentUser = currentUser;
            GetPolicyName = EmployeeManagerPermissions.TimeOffRequests.Default;
            GetListPolicyName = EmployeeManagerPermissions.TimeOffRequests.Default;
            CreatePolicyName = EmployeeManagerPermissions.TimeOffRequests.Create;
            UpdateAnyPolicyName = EmployeeManagerPermissions.TimeOffRequests.EditAny;
            UpdateOwnPolicyName = EmployeeManagerPermissions.TimeOffRequests.EditOwn;
            DeleteAnyPolicyName = EmployeeManagerPermissions.TimeOffRequests.DeleteAny;
            DeleteOwnPolicyName = EmployeeManagerPermissions.TimeOffRequests.DeleteOwn;
            ApprovePolicyName = EmployeeManagerPermissions.TimeOffRequests.Approve;
            //canUpdateAny =
        }

        
        public override async Task<PagedResultDto<TimeOffRequestDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            

            var outputs = await base.GetListAsync(input);

            bool canUpdateAny = await AuthorizationService
                .IsGrantedAsync(ApprovePolicyName);
            /*
            outputs.Items = outputs.Items.WhereIf(
                !canUpdateAny,
                x => x.CreatorId == currentUser.Id
                );
            
            foreach (var result in results)
            {
                var user = await userManager.FindAsync((Guid)result.CreatorId);
                result.UserName = user.UserName;
            }
            return (PagedResultDto<TimeOffRequestDto>)results;
            */

            foreach (var output in outputs.Items)
            {
                var user = await userManager.FindAsync((Guid)output.CreatorId);
                output.UserName = user.UserName;
                
            }
            return outputs;
            
        }
        
    }
}
