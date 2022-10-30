using Microsoft.EntityFrameworkCore;

namespace Customer.Infrastructure.DbContexts
{
    public class CustomerDbContext : BaseDbContextOptions<CustomerDbContext>
    {
        public CustomerDbContext(DbContextOptions<BaseDbContextOptions<CustomerDbContext>> options) : base(options)
        {
        }
    }
}
