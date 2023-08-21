using ABP.UOW.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABP.UOW.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class UOWController : AbpControllerBase
{
    protected UOWController()
    {
        LocalizationResource = typeof(UOWResource);
    }
}
