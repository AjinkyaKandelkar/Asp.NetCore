using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyTraining1121AngularDemo.CustomerBook.Dto
{
    public class CustomerListDto    :   FullAuditedEntity<long>
    {
        public virtual string Name { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual string Address { get; set; }
        
    }
}
