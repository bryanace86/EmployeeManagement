using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EmployeeManager.Data;
using Volo.Abp.DependencyInjection;

namespace EmployeeManager.EntityFrameworkCore
{
    public class EntityFrameworkCoreEmployeeManagerDbSchemaMigrator
        : IEmployeeManagerDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreEmployeeManagerDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the EmployeeManagerMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<EmployeeManagerMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}