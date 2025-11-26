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

        public Task AddCustomer(AddCustomerDTO addCustomer)
        {
            Customer customer = new Customer()
            {
                FullName = addCustomer.FullName,
                PhoneNumber = addCustomer.PhoneNumber,
                NationalCode = addCustomer.NationalCode,
                CreateDate = DateTime.Now,
            };

            _customerRepository.InsertCustomer(customer);
            _customerRepository.SaveChanges();

            return Task.CompletedTask;
        }

        public async Task<EditCustomerDTO> GetCustomerEditById(string customerId)
        {
            Customer customer = await _customerRepository.GetCustomerById(customerId);

            EditCustomerDTO editCustomer = new EditCustomerDTO { 
                CustomerId = customerId,
                FullName = customer.FullName,
                PhoneNumber= customer.PhoneNumber,
                NationalCode= customer.NationalCode,
            };

            return editCustomer;
        }

        public async Task EditCustomer(EditCustomerDTO editCustomer)
        {
            Customer customer = new Customer();
            customer = _customerRepository.GetCustomerById(editCustomer.CustomerId).Result;

            if (customer == null) {
                return;
            }

            customer.FullName = editCustomer.FullName;
            customer.PhoneNumber = editCustomer.PhoneNumber;
            customer.NationalCode = editCustomer.NationalCode;

            await _customerRepository.UpdateCustomer(customer);
            await _customerRepository.SaveChanges();
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

        public async Task DeleteCustomer(string customerId)
        {
            Customer customer = _customerRepository.GetCustomerById(customerId).Result;
            await _customerRepository.DeleteCustomer(customer);
            await _customerRepository.SaveChanges();
        }
    }
}
