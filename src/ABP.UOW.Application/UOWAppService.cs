using System;
using System.Collections.Generic;
using System.Text;
using ABP.UOW.Localization;
using Volo.Abp.Application.Services;

namespace ABP.UOW;

/* Inherit your application services from this class.
 */
public abstract class UOWAppService : ApplicationService
{
    protected UOWAppService()
    {
        LocalizationResource = typeof(UOWResource);
    }
}
