using Abp.Application.Services.Dto;
using MyTraining1121AngularDemo.PhoneBook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTraining1121AngularDemo.CustomerBook.Dto
{
    public class GetCustomerForOutput: EntityDto<long>
    {
        public virtual string Name { get; set; }

        public virtual string EmailAddress { get; set; }

        public virtual string Address { get; set; }
    }
}
