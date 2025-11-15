using AM.Domain.Entities.Category;
using AM.Domain.Entities.Customer;
using AM.Domain.Entities.Order;
using AM.Domain.Entities.User;
using Microsoft.EntityFrameworkCore;

namespace AM.Data.Context
{
    public class AMContext : DbContext
    {
        public AMContext(DbContextOptions<AMContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
