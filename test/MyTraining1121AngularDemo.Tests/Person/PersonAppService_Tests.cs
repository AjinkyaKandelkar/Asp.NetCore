using MyTraining1121AngularDemo.PhoneBook.Dto;
using MyTraining1121AngularDemo.PhoneBook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Shouldly;
using Abp.Runtime.Validation;

namespace MyTraining1121AngularDemo.Tests.Person
{
    public class PersonAppService_Tests:AppTestBase
    {
        private readonly IPersonAppService _personAppService;

        public PersonAppService_Tests()
        {
            _personAppService = Resolve<IPersonAppService>();
        }

        [Fact]
        public void Should_Get_All_People_Without_Any_Filter()
        {
            //Act
            var persons = _personAppService.GetPeople(new GetPeopleInput());

            //Assert
            persons.Items.Count.ShouldBe(2);
        }

        [Fact]
        public async Task Should_Create_Person_With_Valid_Arguments()
        {
            //Act
            await _personAppService.CreatePerson(
                new CreatePersonInput
                {
                    Name = "John",
                    Surname = "Nash",
                    EmailAddress = "john.nash@abeautifulmind.com"
                });

            //Assert
            UsingDbContext(
                context =>
                {
                    var john = context.Persons.FirstOrDefault(p => p.EmailAddress == "john.nash@abeautifulmind.com");
                    john.ShouldNotBe(null);
                    john.Name.ShouldBe("John");
                });

            await Assert.ThrowsAsync<AbpValidationException>(
            async () =>
            {
                await _personAppService.CreatePerson(
                    new CreatePersonInput
                    {
                        Name = "John"
                    });
            });
        }
    }
}
