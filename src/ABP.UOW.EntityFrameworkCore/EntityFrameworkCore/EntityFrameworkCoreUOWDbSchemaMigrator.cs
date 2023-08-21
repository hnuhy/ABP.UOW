using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABP.UOW.Data;
using Volo.Abp.DependencyInjection;

namespace ABP.UOW.EntityFrameworkCore;

public class EntityFrameworkCoreUOWDbSchemaMigrator
    : IUOWDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreUOWDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the UOWDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<UOWDbContext>()
            .Database
            .MigrateAsync();
    }
}
