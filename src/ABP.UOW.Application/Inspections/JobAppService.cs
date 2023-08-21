using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace ABP.UOW.Inspections
{
    public class JobAppService : ApplicationService, IJobAppService
    {
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        private readonly IRepository<Job> _jobRepository;
        private readonly IRepository<Sample> _sampleRepository;

        public JobAppService(IUnitOfWorkManager unitOfWorkManager,IRepository<Job> jobRepository, IRepository<Sample> sampleRepository)
        {
            _unitOfWorkManager = unitOfWorkManager;
            _jobRepository = jobRepository;
            _sampleRepository = sampleRepository;
        }

        public async Task<bool> CommitJob()
        {
            var count = await _jobRepository.CountAsync();
            var job = new Job();
            using (var uow = _unitOfWorkManager.Begin(
                requiresNew: true, isTransactional: true
            ))
            {
                //...这里会操作数据库
                {
                    job = new Job();
                    job.Name = DateTime.Now.Ticks.ToString() + "_1";
                    await _jobRepository.InsertAsync(job);
                }
                await uow.CompleteAsync();
            }

            //后面全在一个事务里
            count = await _jobRepository.CountAsync();

            await CurrentUnitOfWork.SaveChangesAsync();

            count = await _jobRepository.CountAsync();
            if(count > 0)
            {
                job = await _jobRepository.FirstOrDefaultAsync();
                job.Description = DateTime.Now.Ticks.ToString() + "_1";
                await _jobRepository.UpdateAsync(job);
            }
            if (count > 0)
            {
                job = await _jobRepository.FirstOrDefaultAsync();
                job.Description = DateTime.Now.Ticks.ToString() + "_2";
                await _jobRepository.UpdateAsync(job);
            }
            {
                job = await _jobRepository.FirstOrDefaultAsync();
            }

            await CurrentUnitOfWork.SaveChangesAsync();

            {
                job = await _jobRepository.FirstOrDefaultAsync();
            }
            //throw new Exception("t");

            return true;    
        }
    }
}
