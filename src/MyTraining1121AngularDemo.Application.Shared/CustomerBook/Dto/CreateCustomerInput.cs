using MyTraining1121AngularDemo.PhoneBook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTraining1121AngularDemo.CustomerBook.Dto
{
    public class CreateCustomerInput
    {
        [Required]
        [MaxLength(PersonConsts.MaxNameLength)]
        public string Name { get; set; }
        [Required]
        [MaxLength(PersonConsts.MaxEmailAddressLength)]
        public virtual string EmailAddress { get; set; }
        public virtual string Address { get; set; }
  
    }
}
