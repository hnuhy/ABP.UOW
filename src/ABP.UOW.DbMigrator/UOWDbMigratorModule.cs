using ABP.UOW.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ABP.UOW.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(UOWEntityFrameworkCoreModule),
    typeof(UOWApplicationContractsModule)
    )]
public class UOWDbMigratorModule : AbpModule
{
}
