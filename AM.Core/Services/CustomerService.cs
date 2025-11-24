using AM.Core.DTOs.Customers;
using AM.Core.IServices;
using AM.Data.Repository;
using AM.Domain.Entities.Customer;
using AM.Domain.IRepository;

namespace AM.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        
        public CustomerService(ICustomerRepository customerService)
        {
            _customerRepository = customerService;
        }

        public async Task<CustomersIndexDTO> GetAllCustomers()
        {
            ICollection<Customer> rawCustomers = _customerRepository.GetCustomers().Result.ToList();
            List<CustomerTableDTO> customers = new List<CustomerTableDTO>();
            foreach(var customer in rawCustomers)
            {
                customers.Add(new CustomerTableDTO { 
                    CustomerId = customer.CustomerId,
                    FullName = customer.FullName,
                    PhoneNumber = customer.PhoneNumber,
                    NationalCode = customer.NationalCode,
                    TotalPayment = 400000
                });
            }

            CustomersIndexDTO result = new CustomersIndexDTO
            {
                Customers = customers
            };

            return result;
        }
    }
}
