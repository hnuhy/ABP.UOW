using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABP.UOW.Data;

/* This is used if database provider does't define
 * IUOWDbSchemaMigrator implementation.
 */
public class NullUOWDbSchemaMigrator : IUOWDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
