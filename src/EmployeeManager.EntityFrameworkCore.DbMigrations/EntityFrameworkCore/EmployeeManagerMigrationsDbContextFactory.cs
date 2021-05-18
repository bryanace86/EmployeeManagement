using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EmployeeManager.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class EmployeeManagerMigrationsDbContextFactory : IDesignTimeDbContextFactory<EmployeeManagerMigrationsDbContext>
    {
        public EmployeeManagerMigrationsDbContext CreateDbContext(string[] args)
        {
            EmployeeManagerEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<EmployeeManagerMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new EmployeeManagerMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../EmployeeManager.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
