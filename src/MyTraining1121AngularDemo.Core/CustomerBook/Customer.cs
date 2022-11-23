using Abp.Domain.Entities.Auditing;
using MyTraining1121AngularDemo.PhoneBook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining1121AngularDemo.CustomerBook
{
    public class Customer : FullAuditedEntity<long>
    {
        [Required]
        [MaxLength(PersonConsts.MaxNameLength)]
        public virtual string Name { get; set; }

        [MaxLength(PersonConsts.MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        public virtual  string Address { get; set; }
        
    }
}
