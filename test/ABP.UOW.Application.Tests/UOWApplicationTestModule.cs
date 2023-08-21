using Volo.Abp.Modularity;

namespace ABP.UOW;

[DependsOn(
    typeof(UOWApplicationModule),
    typeof(UOWDomainTestModule)
    )]
public class UOWApplicationTestModule : AbpModule
{

}
