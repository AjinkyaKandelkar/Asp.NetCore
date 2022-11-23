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
    public interface ICustomerUserAppService : IApplicationService
    {
        ListResultDto<CustomerUserListDto> GetCustomerUser(GetCustomerUserInput input);
        Task CreateCustomerUser(CreateCustomerUserInput input);
        List<GetCustomerUserInfo> GetUserInfo(long customerId);
       
    }
}
