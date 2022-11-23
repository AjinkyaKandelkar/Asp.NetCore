using MyTraining1121AngularDemo.PhoneBook;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyTraining1121AngularDemo.CustomerBook.Dto
{
    public class CreateCustomerUserInput
    {
        public virtual long CustomerId { get; set; }
        public virtual long UserId { get; set; }
    }
}
