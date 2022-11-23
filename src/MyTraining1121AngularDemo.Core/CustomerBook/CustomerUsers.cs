using Abp.Domain.Entities.Auditing;
using MyTraining1121AngularDemo.Authorization.Users;
using MyTraining1121AngularDemo.PhoneBook;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTraining1121AngularDemo.CustomerBook
{
    public class CustomerUsers: FullAuditedEntity<long>
    {
        
        public virtual Customer Customer { get; set; }
        [ForeignKey("CustomerId ")]
        public virtual long CustomerId { get; set; }

        public virtual User User { get; set; }
        [ForeignKey("UserId")]
        public virtual long UserId { get; set; }
    }
}
