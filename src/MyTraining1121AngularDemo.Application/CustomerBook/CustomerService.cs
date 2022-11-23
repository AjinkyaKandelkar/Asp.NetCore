using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using MyTraining1121AngularDemo.Authorization;
using MyTraining1121AngularDemo.Authorization.Users;
using MyTraining1121AngularDemo.Authorization.Users.Dto;
using MyTraining1121AngularDemo.CustomerBook.Dto;
using NPOI.SS.Formula.Functions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTraining1121AngularDemo.CustomerBook
{
    [AbpAuthorize(AppPermissions.Pages_Tenant_CustomerBook)]
    public class CustomerService : MyTraining1121AngularDemoAppServiceBase, ICustomerService
    {
        private readonly IRepository<Customer,long> _customerRepository;
        private readonly IRepository<User, long> _UserRepo;
        public CustomerService(IRepository<Customer,long> customerRepository, IRepository<User, long> userRepo)
        {
            _customerRepository = customerRepository;
            _UserRepo = userRepo;
        }

        public async Task<long> CreateCustomer(CreateCustomerInput Input)
        {
            var customer = ObjectMapper.Map<Customer>(Input);
            //await _customerRepository.InsertAsync(customer);
            var cid=  await _customerRepository.InsertAndGetIdAsync(customer);
            return cid;
        }

        [AbpAuthorize(AppPermissions.Pages_Tenant_CustomerBook_DeleteCustomer)]
        public async Task DeleteCustomer(EntityDto input)
        {
            await _customerRepository.DeleteAsync(input.Id);
        }

        public ListResultDto<CustomerListDto> GetCustomer(GetCustomerInput input)
        {
            var customer = _customerRepository.GetAll().WhereIf(
                !input.Filter.IsNullOrEmpty(),
                p => p.Name.Contains(input.Filter) ||
                p.Address.Contains(input.Filter) ||
                p.EmailAddress.Contains(input.Filter)
                ).OrderBy(c => c.Name)
                .ToList();
            return new ListResultDto<CustomerListDto>(
                ObjectMapper.Map<List<CustomerListDto>>(customer));
        }


        [AbpAuthorize(AppPermissions.Pages_Tenant_CustomerBook_EditCustomer)]
        public async Task<GetCustomerForOutput> GetCustomerForEdit(GetCustomerForInput input)
        {

            var customer = await _customerRepository.GetAsync(input.Id);
            return ObjectMapper.Map<GetCustomerForOutput>(customer);

        }

        [AbpAuthorize(AppPermissions.Pages_Tenant_CustomerBook_EditCustomer)]
        public async Task EditCustomer(EditCustomerInput input)
        {
            var customer = await _customerRepository.GetAsync(input.Id);
            customer.Name = input.Name;
            customer.Address = input.Address;
            customer.EmailAddress = input.EmailAddress;
            await _customerRepository.UpdateAsync(customer);
        }

        public List<UserListDto> GetUsers()
        {
            var UserList = _UserRepo.GetAll();
            
                var nm=
                new List<UserListDto>(
                ObjectMapper.Map<List<UserListDto>>(UserList)
                );
            return nm;
        }


    }
}
