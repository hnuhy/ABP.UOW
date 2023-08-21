using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace ABP.UOW.Inspections
{
    public class Sample : FullAuditedAggregateRoot<Guid>
    {
        public Guid JobId { get; set; }

        public virtual string Name { get; set; } = string.Empty;

        public virtual string Description { get; set; } = string.Empty;

        public virtual string Status { get; set; } = string.Empty;
    }
}
