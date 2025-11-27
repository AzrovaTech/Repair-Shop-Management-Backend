using AM.Core.DTOs.Customers;

namespace AM.Core.IServices
{
    public interface ICustomerService
    {
        public Task<CustomersIndexDTO> GetAllCustomers();

        public Task AddCustomer(AddCustomerDTO addCustomer);

        public Task<EditCustomerDTO> GetCustomerEditById(string customerId);

        public Task EditCustomer(EditCustomerDTO editCustomer);

        public Task DeleteCustomer(string customerId);
    }
}
