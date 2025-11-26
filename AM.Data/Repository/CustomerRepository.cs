using AM.Data.Context;
using AM.Domain.Entities.Customer;
using AM.Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace AM.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AMContext _context;

        public CustomerRepository(AMContext context)
        {
            _context = context;
        }

        public async Task DeleteCustomer(Customer Customer)
        {
            _context.Customers.Remove(Customer);
        }

        public async Task<Customer> GetCustomerById(string CustomerId)
        {
            return await _context.Customers.FirstOrDefaultAsync(c => c.CustomerId == CustomerId);
        }

        public async Task<IQueryable<Customer>> GetCustomerByName(string name)
        {
            return _context.Customers.Where(c => c.FullName.Contains(name));
        }

        public async Task<IQueryable<Customer>> GetCustomers()
        {
            return _context.Customers;
        }

        public async Task InsertCustomer(Customer Customer)
        {
            await _context.Customers.AddAsync(Customer);
        }

        public async Task UpdateCustomer(Customer Customer)
        {
            _context.Update(Customer);
        }

        public async Task SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
