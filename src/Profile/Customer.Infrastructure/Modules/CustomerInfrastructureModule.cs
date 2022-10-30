using Customer.Domain.Interfaces;
using Customer.Infrastructure.DbContexts;
using Customer.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Customer.Infrastructure.Modules
{
    public static class CustomerInfrastructureModule
    {
        public static IServiceCollection CreateInfrastructureModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CustomerDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CustomerConnectionstring"));
            });

            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            return services;
        }
    }
}
