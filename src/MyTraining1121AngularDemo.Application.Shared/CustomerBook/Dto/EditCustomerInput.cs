using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using MyTraining1121AngularDemo.PhoneBook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTraining1121AngularDemo.CustomerBook.Dto
{
    public class EditCustomerInput:EntityDto<long>
    {
        [Required]
        [MaxLength(PersonConsts.MaxNameLength)]
        public virtual string Name { get; set; }
        [Required]
        [MaxLength(PersonConsts.MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        public virtual string Address { get; set; }

    }
}
