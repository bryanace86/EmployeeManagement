using EmployeeManager.TimeOffRequests;
using EmployeeManager.Users;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace EmployeeManager.EntityFrameworkCore
{
    public static class EmployeeManagerDbContextModelCreatingExtensions
    {
        public static void ConfigureEmployeeManager(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(EmployeeManagerConsts.DbTablePrefix + "YourEntities", EmployeeManagerConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<TimeOffRequest>(x =>
            {
                x.ToTable(EmployeeManagerConsts.DbTablePrefix + "TimeOffRequests",
                          EmployeeManagerConsts.DbSchema);
                x.ConfigureByConvention(); //auto configure for the base class props
                x.Property(x => x.StartDateTime).IsRequired();
                x.Property(x => x.EndDateTime).IsRequired();
                // ADD THE MAPPING FOR THE RELATION
                x.HasOne<AppUser>().WithMany().HasForeignKey(x => x.CreatorId).IsRequired();
            });

        }
    }
}