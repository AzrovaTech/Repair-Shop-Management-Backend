using AM.Core.IServices;
using AM.Core.Services;
using AM.Data.Repository;
using AM.Domain.IRepository;
using Microsoft.Extensions.DependencyInjection;

namespace AM.IoC
{
    public class DependencyContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            #region Repositories
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            #endregion

            #region Services
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<ICategoryService, CategoryService>();
            #endregion
        }
    }
}
