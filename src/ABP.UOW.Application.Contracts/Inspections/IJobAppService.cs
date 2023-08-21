using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ABP.UOW.Inspections
{
    public interface IJobAppService:IApplicationService
    {
        Task<bool> CommitJob();
    }
}
