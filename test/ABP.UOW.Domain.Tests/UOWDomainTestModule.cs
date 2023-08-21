using ABP.UOW.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABP.UOW;

[DependsOn(
    typeof(UOWEntityFrameworkCoreTestModule)
    )]
public class UOWDomainTestModule : AbpModule
{

}
