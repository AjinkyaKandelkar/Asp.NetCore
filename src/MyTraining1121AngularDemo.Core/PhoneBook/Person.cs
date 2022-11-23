
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;

namespace MyTraining1121AngularDemo.PhoneBook
{
    [Table("PbPersons")]
    public class Person : FullAuditedEntity,IMustHaveTenant
    {


            [Required]
            [MaxLength(PersonConsts.MaxNameLength) ]
            public virtual string Name { get; set; }

            [Required]
            [MaxLength(PersonConsts.MaxSurnameLength)]
            public virtual string Surname { get; set; }

            [MaxLength(PersonConsts.MaxEmailAddressLength)]
            public virtual string EmailAddress { get; set; }
            public virtual ICollection<Phone> Phones { get; set; }
            public virtual int TenantId { get; set; }
    }
}


