using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyTraining1121AngularDemo.Authorization.Users.Dto;
using MyTraining1121AngularDemo.CustomerBook.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining1121AngularDemo.CustomerBook
{
    public interface ICustomerService:IApplicationService
    {
        ListResultDto<CustomerListDto> GetCustomer(GetCustomerInput input);
        Task<long> CreateCustomer(CreateCustomerInput Input);
        Task DeleteCustomer(EntityDto input);
        List<UserListDto> GetUsers();
    }
}
