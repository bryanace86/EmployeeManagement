using System.Threading.Tasks;

namespace EmployeeManager.Data
{
    public interface IEmployeeManagerDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
