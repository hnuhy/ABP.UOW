using System.Threading.Tasks;

namespace ABP.UOW.Data;

public interface IUOWDbSchemaMigrator
{
    Task MigrateAsync();
}
