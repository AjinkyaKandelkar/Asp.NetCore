using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTraining1121AngularDemo.CustomerBook.Dto
{
    public class CustomerUserListDto : FullAuditedEntity<long>
    {
        public virtual long CustomerId { get; set; }
        public virtual long UserId { get; set; }
    }
}
