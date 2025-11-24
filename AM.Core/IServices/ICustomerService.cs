using AM.Core.DTOs.Customers;

namespace AM.Core.IServices
{
    public interface ICustomerService
    {
        public Task<CustomersIndexDTO> GetAllCustomers();
    }
}
