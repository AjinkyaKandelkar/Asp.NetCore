using MyTraining1121AngularDemo.CustomerBook;
using MyTraining1121AngularDemo.CustomerBook.Dto;
using MyTraining1121AngularDemo.PhoneBook.Dto;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MyTraining1121AngularDemo.Tests.Customer
{
    public class Create_Customer_Test : AppTestBase
    {
        private readonly ICustomerService _customerService;
        [Fact]
        public async Task Should_Create_Customer_With_Valid_Arguments()
        {
            //Act
            await _customerService.CreateCustomer(
                new CreateCustomerInput
                {

                    Name = "Ava",
                    EmailAddress = "abc@gmail.com",
                    Address = "591 Memorial Dr, Chinchopee MA 1020",
                });
            
        }
    }
}
