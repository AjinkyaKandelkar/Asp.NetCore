using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Microsoft.Graph;
using MyTraining1121AngularDemo.Authorization.Users;
using MyTraining1121AngularDemo.Authorization.Users.Dto;
using MyTraining1121AngularDemo.CustomerBook.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User = MyTraining1121AngularDemo.Authorization.Users.User;

namespace MyTraining1121AngularDemo.CustomerBook
{
    public class CustomerUserAppService : MyTraining1121AngularDemoAppServiceBase, ICustomerUserAppService
    {
        private readonly IRepository<CustomerUsers, long> _customerUserRepository;
        private readonly IRepository<User, long> _UserRepo;
        public CustomerUserAppService(IRepository<CustomerUsers, long> customerUserRepository, IRepository<User, long> userRepo)
        {
            _customerUserRepository = customerUserRepository;
            _UserRepo = userRepo;
        }

        public async Task CreateCustomerUser(CreateCustomerUserInput input)
        {
            var customeruser = ObjectMapper.Map<CustomerUsers>(input);
            await _customerUserRepository.InsertAsync(customeruser);

        }

        public ListResultDto<CustomerUserListDto> GetCustomerUser(GetCustomerUserInput input)
        {
            var customerUser = _customerUserRepository.GetAll().ToList();
            return new ListResultDto<CustomerUserListDto>(
                ObjectMapper.Map<List<CustomerUserListDto>>(customerUser));
        }

        public List<GetCustomerUserInfo> GetUserInfo(long customerId)
        {
            var userdetail = (from a in _customerUserRepository.GetAll()
                              join b in _UserRepo.GetAll() on
                              a.UserId equals b.Id
                              where a.CustomerId == customerId
                              select new GetCustomerUserInfo
                              {
                                  Name = b.Name,
                                  Surname = b.Surname,
                                  EmailAddress = b.EmailAddress
                              }
                              ).ToList();
            return userdetail;
            
        }
    }
}
