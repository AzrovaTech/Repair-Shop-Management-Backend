using AM.Domain.Entities.Customer;

namespace AM.Domain.IRepository
{
    public interface ICustomerRepository
    {
        public Task<IQueryable<Customer>> GetCustomers();

        public Task<Customer> GetCustomerById(string CustomerId);

        public Task<IQueryable<Customer>> GetCustomerByName(string name);

        public Task InsertCustomer(Customer Customer);

        public Task UpdateCustomer(Customer Customer);

        public Task DeleteCustomer(Customer Customer);

        public Task SaveChanges();
    }
}
