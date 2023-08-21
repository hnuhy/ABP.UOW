using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABP.UOW;

[Dependency(ReplaceServices = true)]
public class UOWBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "UOW";
}
