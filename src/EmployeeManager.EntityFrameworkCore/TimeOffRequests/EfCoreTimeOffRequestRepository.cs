using EmployeeManager.EntityFrameworkCore;
using EmployeeManager.TimeOffRequsts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Volo.Abp.Users;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManager.TimeOffRequests
{
    
    public class EfCoreTimeOffRequestRepository : EfCoreRepository<EmployeeManagerDbContext, TimeOffRequest, Guid>,
            ITimeOffRequestRepository
    {
        //private readonly ICurrentUser currentUser;
        public EfCoreTimeOffRequestRepository(
            //ICurrentUser currentUser,
            IDbContextProvider<EmployeeManagerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
            //this.currentUser = currentUser;
        }

        public async Task<List<TimeOffRequest>> GetListAsync(int skipCount, int maxResultCount, string sorting, Guid currentUserId)
        {
            
            var dbSet = await GetDbSetAsync();
            return await dbSet
                .WhereIf(
                    currentUserId != Guid.Empty,
                    x => x.CreatorId.Equals(currentUserId)
                 )
                .OrderBy(sorting)
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();
        }
    }
    
}
