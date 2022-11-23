using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyTraining1121AngularDemo.PhoneBook.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining1121AngularDemo.PhoneBook
{
    public interface IPersonAppService:IApplicationService
    {
        ListResultDto<PersonListDto> GetPeople(GetPeopleInput input);
        Task CreatePerson(CreatePersonInput input);
        Task DeletePerson(EntityDto input);
        Task DeletePhone(EntityDto<long> input);
        Task<PhoneInPersonListDto> AddPhone(AddPhoneInput input);
    }
}
